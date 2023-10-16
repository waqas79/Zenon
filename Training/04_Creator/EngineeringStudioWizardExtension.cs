using System;
using System.Diagnostics;
using System.Windows.Forms;
using Scada.AddIn.Contracts;
//using Process;

namespace _04_Creator
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("04 Creator", "This wizard creates zenon objects", "Training")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation
        public void Run(IEditorApplication context, IBehavior behavior)
        {
            //Enter your code which should be executed when starting the SCADA Engineering Studio Wizard
            //MessageBox.Show("04 creator is calling into operation");
            //System.Diagnostics.Debug.Print("No Zenon Reference in Creator Constracted");
            Creator creator = new Creator(context.Workspace.ActiveProject);
            //creator.CreateFrame("03_Bildbereich");
            //creator.CreateFrame("01_Global_Top_Ribbon", 0, 0, 1920, 90);
            //creator.CreateScreen("000 Testing Screen", "03_bildbereich");
            //creator.CreateDriver("TestDriver", "3S_V3");
            //creator.CreateVariable("System.testingAPI", "TestDriver", Scada.AddIn.Contracts.Variable.ChannelType.DriverVariable, "INT");
            //creator.CreateRGM("RecipeAlarmText", "System.AlarmText");
            /*
            string RecipePre = "Help_Alarm ";
            string recipeName = "";

            for (int i = 1; i < 5001; i++)
            {
                string RecipePost = string.Format("{0}", i);
                recipeName = string.Concat(RecipePre, RecipePost);
                creator.CreateRecipe(recipeName, "RecipeAlarmText");
            }
            */

            string orgFuncName = "00 - 04 - 01 _ 1 _AlarmHelpText_RecScreen";

            string newFuncName_p1 = "00 - 04 - 01 _ ";
            string newFuncName_p3 = " _AlarmHelpText_RecScreen";

            string Recipe_P1 = "Help_Alarm ";

            for (int i = 2; i < 51; i++)
            {
                string i_looping = string.Format("{0}", i);
                string newFuncName = string.Concat(newFuncName_p1, i_looping , newFuncName_p3);
                string RecipeName = string.Concat(Recipe_P1, i_looping);
                creator.CopyFucntion(orgFuncName, newFuncName, RecipeName);
            }
            


        }
        #endregion
    }
}