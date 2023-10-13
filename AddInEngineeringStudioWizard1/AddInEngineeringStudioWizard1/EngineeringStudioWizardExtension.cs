using System;
using Scada.AddIn.Contracts;

namespace AddInEngineeringStudioWizard1
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("Your Engineering Studio Wizard Extension Name", "Your Engineering Studio Wizard Extension Description", "Your Engineering Studio Wizard Extension Category")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior)
        {
            // enter your code which should be executed when starting the SCADA Engineering Studio Wizard

        }

        #endregion
    }

}