using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Function;
using Scada.AddIn.Contracts.Variable;

namespace _05_RefAlarmHelp2Variable
{
    internal class subHelpText2Alarm
    {
        IProject myproject = null;
        public subHelpText2Alarm(IProject zproject)
        {
            if (zproject == null)
            {
                System.Diagnostics.Debug.Print("No Zenon Reference in Creator Constracted");
            }
            myproject = zproject;
            zproject.Parent.Parent.DebugPrint("Twisting skills", DebugPrintStyle.Standard);
        }
        //myproject.Parent.Parent.DebugPrint("Twisting skills", DebugPrintStyle.Standard);
        
        public void HelpText2Varabile(string targetVariable , string targetFucntion)
        {
            try
            {
                myproject.Parent.Parent.DebugPrint("The method is called ......", DebugPrintStyle.Standard);
                IVariable zVariable = myproject.VariableCollection[targetVariable];

                if (zVariable == null)
                {
                    myproject.Parent.Parent.DebugPrint("Variable is not available .... ", DebugPrintStyle.Error);
                }
                else
                {
                    myproject.Parent.Parent.DebugPrint("Variable" + targetVariable + "is available .... ", DebugPrintStyle.Standard);
                }

                IFunction zFucntion = myproject.FunctionCollection[targetFucntion];
                if (zFucntion == null) { myproject.Parent.Parent.DebugPrint(targetFucntion, DebugPrintStyle.Error); }

                zVariable.SetDynamicProperty("Limits[1].FunctionAML", targetFucntion);
                myproject.Parent.Parent.DebugPrint("Variable:" + targetVariable + ": now linked to :" + targetFucntion  , DebugPrintStyle.Standard);
            }
            catch(Exception ex)
            {
                myproject.Parent.Parent.DebugPrint("Error in Help Text to Variable : " + ex.Message, DebugPrintStyle.Error);
                return;
            }
            


        }

        

    }
}
