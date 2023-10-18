using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Function;
using Scada.AddIn.Contracts.Screen;

namespace MBT_FunctionRecipeScreenAML
{
    internal class Creator
    {
        IProject myProject = null;
        public Creator(IProject zProject)
        {
            if (zProject == null)
            {
                System.Diagnostics.Debug.Print("No Zenon Reference in Creator Constracted");
            }
            myProject = zProject;
            myProject.Parent.Parent.DebugPrint("Active Project " + myProject + "is successfully called", DebugPrintStyle.Standard);

        }

        public void NewFunction(string zFunctionName , string zScreenName)
        {
            IFunction function = myProject.FunctionCollection[zFunctionName];
            IScreen Screen = myProject.ScreenCollection[zScreenName];
            if (function == null)
            {
                // make a funcuton .....................
                function = myProject.FunctionCollection.Create(zFunctionName, FunctionType.ScreenSwitch); // create a blank screenswtichscreen
                function.SetDynamicProperty(zScreenName, Screen); // set path and parameters 
                


            }
            else
            {
                //Fucntion already exisited ..... !
                myProject.Parent.Parent.DebugPrint("Fucntion" + zFunctionName + "is already existed ........", DebugPrintStyle.Error);
            }
        }
        public void CopyFucntion(string orgFunction, string newFunction, string RecipeSelection)
        {
            IFunction zFun = myProject.FunctionCollection[orgFunction];
            myProject.Parent.Parent.DebugPrint("Org Fucntion name is :" + orgFunction + ":", DebugPrintStyle.Standard);

            try
            {
                IFunction zFctCopy = myProject.FunctionCollection.Create(newFunction, FunctionType.ScreenSwitch);
                myProject.Parent.Parent.DebugPrint("New fucntion name is :" + newFunction + ":", DebugPrintStyle.Standard);

                zFctCopy.Duplicate(zFun);
                myProject.Parent.Parent.DebugPrint("New fucntion : " + newFunction + " is copied from " + orgFunction, DebugPrintStyle.Standard);
                zFctCopy.SetDynamicProperty("PictFilter.Recipe", RecipeSelection);
                myProject.Parent.Parent.DebugPrint("RecipeSelection of " + newFunction + " is changed with " + RecipeSelection, DebugPrintStyle.Standard);

            }
            catch (Exception ex)
            {
                myProject.Parent.Parent.DebugPrint("Error in creation of New Funcion: " + ex.Message, DebugPrintStyle.Error);
                return;
            }
            // Working related to for loop .... 


        }





    }
}
