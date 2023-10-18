using System;
using Scada.AddIn.Contracts;

namespace MBT_Recipes
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("MBT Recipies", "This wizard creates zenon objects", "Training")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior)
        {
            // enter your code which should be executed when starting the SCADA Engineering Studio Wizard
            Creator creator = new Creator(context.Workspace.ActiveProject);
            creator.CreateRGM("RecipeAlarmText", "System.AlarmText");

            string RecipePre = "Help_Alarm ";
            string recipeName = "";

            for (int i = 100; i < 2000; i++)
            {
                string RecipePost = string.Format("{0}", i);
                recipeName = string.Concat(RecipePre, RecipePost);
                creator.CreateRecipe(recipeName, "RecipeAlarmText");
            }
        }
        #endregion
    }

}