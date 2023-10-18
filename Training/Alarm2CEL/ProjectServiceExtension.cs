using System;
using Scada.AddIn.Contracts;

namespace Alarm2CEL
{
    /// <summary>
    /// Description of Project Service Extension.
    /// </summary>
    [AddInExtension("AlarmToCEL", "This sends alarm to CEL")]
    public class ProjectServiceExtension : IProjectServiceExtension
    {
        #region IProjectServiceExtension implementation
        IProject activeProject;

        public void Start(IProject context, IBehavior behavior)
        {
            activeProject = context;
            activeProject.AlarmMessageList.AlarmEntryReceived += AlarmMessageList_AlarmEntryReceived;
        }

        private void AlarmMessageList_AlarmEntryReceived(object sender, Scada.AddIn.Contracts.AlarmMessageList.AlarmEntryReceivedEventArgs e)
        {
            // Print to CEL
            //activeProject.ChronologicalEventList.AddEventEntry()
        }

        public void Stop()
        {
            // enter your code which should be executed when stopping the service for the SCADA Service Engine
        }

        #endregion
    }
}