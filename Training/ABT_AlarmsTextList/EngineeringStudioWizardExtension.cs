using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Frame;
using System.Windows.Forms;
using System;


namespace ABT_AlarmsTextList
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("ABT_AlarmTextList", "Making recipies and then the alarmsfunction for each alarm", "00 ABT")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation
       
       
        public void Run(IEditorApplication context, IBehavior behavior)
        {
            // enter your code which should be executed when starting the SCADA Engineering Studio Wizard
            MessageBox.Show(" Initiallization of Creating new Recipies 5  ");
            // constructor ALARMLIST passing project 
            CreateRecipe alarmList = new CreateRecipe(context.Workspace.ActiveProject);
            // constructor ALARMLIST passing project 






        }
















        #endregion
    }

}