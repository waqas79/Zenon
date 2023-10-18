using System;
using Scada.AddIn.Contracts;

namespace MBT_FunctionRecipeScreenAML
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("MBT FucntionRecipeScrAML", "This wizard creates 1500 fucntions to link specific recipes", "Training")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior)
        {
            // enter your code which should be executed when starting the SCADA Engineering Studio Wizard
            Creator creator = new Creator(context.Workspace.ActiveProject);





            /*
            string orgFuncName = "00 - 04 - 01 _ 1 _AlarmHelpText_RecScreen";

            string newFuncName_p1 = "00 - 04 - 01 _ ";
            string newFuncName_p3 = " _AlarmHelpText_RecScreen";

            string Recipe_P1 = "Help_Alarm ";

            for (int i = 50; i < 5001; i++)
            {
                string i_looping = string.Format("{0}", i);
                string newFuncName = string.Concat(newFuncName_p1, i_looping, newFuncName_p3);
                string RecipeName = string.Concat(Recipe_P1, i_looping);
                creator.CopyFucntion(orgFuncName, newFuncName, RecipeName);
            }
            */


        }

        #endregion
    }

}