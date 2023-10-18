using System;
using Scada.AddIn.Contracts;

namespace _06_SymbolService
{
    /// <summary>
    /// Description of Engineering Studio Service Extension.
    /// </summary>
    [AddInExtension("1st Symbol Service", "Service for parameterization ...")]
    public class EngineeringStudioServiceExtension : IEditorServiceExtension
    {
        #region IEditorServiceExtension implementation

        IWorkspace myWorkspace;

        public void Start(IEditorApplication context, IBehavior behavior)
        {
            myWorkspace = context.Workspace;
            myWorkspace.Parent.DebugPrint("Symbol service started", DebugPrintStyle.Standard);
            // Subscribe to symbol event!
            myWorkspace.ScreenElementCreated += MyWorkspace_ScreenElementCreated;
        }

        private void MyWorkspace_ScreenElementCreated(object sender, ScreenElementCreatedEventArgs e)
        {
            if (e.Element.Name.StartsWith("CustomSymbol"))
            {
                SymbolWindow myWindow = new SymbolWindow(e.Element);
                myWindow.Show();
            }
        }

        public void Stop()
        {
            myWorkspace.ScreenElementCreated += MyWorkspace_ScreenElementCreated;
            myWorkspace.Parent.DebugPrint("Symbol service Stoped", DebugPrintStyle.Standard);
        }

        #endregion
    }

}