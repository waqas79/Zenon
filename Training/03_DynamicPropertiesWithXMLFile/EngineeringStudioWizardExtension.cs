using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Function;

namespace _03_DynamicPropertiesWithXMLFile
{
    /// <summary>
    /// Description of Engineering Studio Wizard Extension.
    /// </summary>
    [AddInExtension("Dynamic_XML", "Here XML file is used to program it ", "Training")]
    public class EngineeringStudioWizardExtension : IEditorWizardExtension
    {
        #region IEditorWizardExtension implementation

        public void Run(IEditorApplication context, IBehavior behavior)
        {
            // enter your code which should be executed when starting the SCADA Engineering Studio Wizard

            // Reading the Function and saving it 
            IFunction myAmlFunction = context.Workspace.ActiveProject.FunctionCollection["MyAML_Function"];
            myAmlFunction.SetDynamicProperty("PictFilter[0].VarFilter", "MyVariableFromAPI");
        }

        #endregion
    }

}