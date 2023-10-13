using Scada.AddIn.Contracts;
using System.Windows.Forms;

namespace _01_HelloWorld
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("HelloWorld", "This wiyard will display the message Hello World", "Training")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior)
        {
            MessageBox.Show("Hello World! * * * * * *");

        }

        #endregion
    }

}