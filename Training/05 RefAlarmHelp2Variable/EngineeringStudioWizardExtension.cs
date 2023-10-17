using System;
using System.Collections.Generic;
using Scada.AddIn.Contracts;

namespace _05_RefAlarmHelp2Variable
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("05 AlarmText2Variablelink", "This wizard creates zenon objects", "Training")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation
        public void Run(IEditorApplication context, IBehavior behavior)
        {
            Creator creator = new Creator(context.Workspace.ActiveProject);
            // ELB Error indexing
            creator.Helptext_loop("ELB_Error_010", 2201);
            creator.Helptext_loop("ELB_Error_020", 2217);
            creator.Helptext_loop("ELB_Error_030", 2233);
            creator.Helptext_loop("ELB_Error_040", 2249);
            creator.Helptext_loop("ELB_Error_050", 2265);

        }
        #endregion
    }
}