using Scada.AddIn.Contracts;

namespace _02_DynamicProperties
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("DynamicProperties2", "This is the demonstrtaion of eamples ", "Training")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior) 
        {   
            // setting button text via dynamic properties
            context.Workspace.ActiveProject.ScreenCollection["MyScreen"].ScreenElementCollection["Button_1"].SetDynamicProperty("Text1", "This text was written by me");

            context.Workspace.ActiveProject.ScreenCollection["MyScreen"].ScreenElementCollection["Button_1"].FillColor = 800000;
            context.Workspace.ActiveProject.ScreenCollection["MyScreen"].ScreenElementCollection["Rectangle_2"].FillColor = 80900;
            




        }
        #endregion
    }

}