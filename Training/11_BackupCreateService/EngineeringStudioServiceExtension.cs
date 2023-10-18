using System;
using Scada.AddIn.Contracts;

namespace _11_BackupCreateService
{
    /// <summary>
    /// Description of Engineering Studio Service Extension.
    /// </summary>
    [AddInExtension("BackupCreator", "Create a autobackup when running RT Files")]
    public class EngineeringStudioServiceExtension : IEditorServiceExtension
    {
        #region IEditorServiceExtension implementation

        IWorkspace myWorkspace;

        public void Start(IEditorApplication context, IBehavior behavior)
        {
            // enter your code which should be executed when starting the SCADA Engineering Studio Service
            // install set services
            myWorkspace = context.Workspace;
            myWorkspace.RuntimeFilesCreated += MyWorkspace_RuntimeFilesCreated;

        }

        private void MyWorkspace_RuntimeFilesCreated(object sender, RuntimeFilesCreatedEventArgs e)
        {
            // create an automatic backups
            string projectName = myWorkspace.ActiveProject.Name;
            string filePath = @"C:\Users\m.aslam\OneDrive - cts GmbH\Projektdaten\07_Software und Robotik\03 Allgemein(ABT+MBT)\07 Zenon\09 AutoBackups\" + projectName + "_" + DateTime.Now.ToString("yyyy -MM-dd_hh-mmss" + ".Zip");
            bool sucess = myWorkspace.CreateProjectBackup(projectName, filePath, "Working Progress ", true);
            if(sucess)
            {
                myWorkspace.Parent.DebugPrint("Project backup was successfully created!", DebugPrintStyle.Standard);
                myWorkspace.Parent.DebugPrint(filePath, DebugPrintStyle.Standard);
            }
            else
            {
                myWorkspace.Parent.DebugPrint("Could not create a Project backup !", DebugPrintStyle.Warning);
            }

        }

        public void Stop()
        {
            myWorkspace.RuntimeFilesCreated -= MyWorkspace_RuntimeFilesCreated; 
            myWorkspace.Parent.DebugPrint("Service was stoped!", DebugPrintStyle.Standard);

        }

        #endregion
    }

}