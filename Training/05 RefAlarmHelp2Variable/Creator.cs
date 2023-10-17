using System;
using System.Collections.Generic;
using Scada.AddIn.Contracts;


namespace _05_RefAlarmHelp2Variable
{
    internal class Creator
    {
        IProject myproject = null;
        public Creator(IProject zproject)
        {
            if(zproject == null)
            {
                System.Diagnostics.Debug.Print("No Zenon Reference in Creator Constracted");
            }
            myproject = zproject;
            myproject.Parent.Parent.DebugPrint("creator is called", DebugPrintStyle.Standard);
            
            
        }
        public void Helptext_loop (string errorName , int FirstErrorNo )
        {
            subHelpText2Alarm Sis = new subHelpText2Alarm(myproject);

            string errorName_p1 = errorName + "[";
            string errorName_p3 = "]";

            string newFuncName_p1 = "00 - 04 - 01 _ ";
            string newFuncName_p3 = " _AlarmHelpText_RecScreen";
           



            for (int i = 0; i < 16; i++)
            {
                string i_string = string.Format("{0}", i);
                string new_errorName = string.Concat(errorName_p1, i_string, errorName_p3);

                int i_factor = i + FirstErrorNo;
                string i_errorIndex = string.Format("{0}", i_factor);
                string newFuncName = string.Concat(newFuncName_p1, i_errorIndex, newFuncName_p3);

                Sis.HelpText2Varabile(new_errorName, newFuncName);

            }





            


                
            myproject.Parent.Parent.DebugPrint("creator is Terminated", DebugPrintStyle.Standard);
        }

        

        
        

        
    }
}
