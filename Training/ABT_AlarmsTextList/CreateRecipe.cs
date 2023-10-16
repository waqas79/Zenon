using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Variable;

namespace ABT_AlarmsTextList
{
    internal class CreateRecipe
    {
        

        public CreateRecipe(IProject zProject)
            // check the active project and assign it to varable myproject ... 
        {
            if (zProject == null)
            {
                System.Diagnostics.Debug.Print("None is CreateRecipe");
            }
            
        }


    }
}
