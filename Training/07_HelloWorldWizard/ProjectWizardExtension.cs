using System;
using Scada.AddIn.Contracts;

namespace _07_HelloWorldWizard
{
    /// <summary>
    /// Description of Project Wizard Extension.
    /// </summary>
    [AddInExtension("HelloWorldCEL", "This only print Hellow World!")]
    public class ProjectWizardExtension : IProjectWizardExtension
    {
        #region IProjectWizardExtension implementation

        public void Run(IProject context, IBehavior behavior)
        {
            context.ChronologicalEventList.AddEventEntry("HelloWorld!");
            // enter your code which should be executed on triggering the function "Execute Project Wizard Extension" in the SCADA Service Engine

        }

        #endregion
    }

}