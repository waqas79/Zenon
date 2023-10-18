using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.RecipeGroupManager;
using Scada.AddIn.Contracts.Variable;

namespace MBT_Recipes
{
    internal class Creator
    {
        IProject myProject = null;
        public Creator(IProject zProject)
        {
            if (zProject == null)
            {
                System.Diagnostics.Debug.Print("No Zenon Reference in Creator Constracted");
            }
            myProject = zProject;
            myProject.Parent.Parent.DebugPrint("Activ project is called successfully", DebugPrintStyle.Standard);
        }

        public void CreateRGM(string recipeGroupName, string varRecipe)
        {
            myProject.Parent.Parent.DebugPrint("00 Create RGM is called....", DebugPrintStyle.Standard);
            // Retrieve the recipe group collection.
            IRecipeGroup myRGM = myProject.RecipeGroupCollection[recipeGroupName];
            try
            {
                if (myRGM == null)
                {
                    // The specified recipe group collection does not exist,
                    myRGM = myProject.RecipeGroupCollection.Create(recipeGroupName);
                    myProject.Parent.Parent.DebugPrint("Recipe Group Manager : " + recipeGroupName + " is created....", DebugPrintStyle.Standard);
                }
                else
                {
                    myProject.Parent.Parent.DebugPrint("Recipe Group Manager : " + recipeGroupName + " already exists....", DebugPrintStyle.Warning);
                }
            }
            catch (Exception ex)
            {
                myProject.Parent.Parent.DebugPrint("Error in creation of Recipe Group Manager: " + ex.Message, DebugPrintStyle.Error);
                return;
            }

            IVariable myReccipeVar = myProject.VariableCollection[varRecipe];
            bool bFlag = myRGM.AddVariable(myReccipeVar);
            myProject.Parent.Parent.DebugPrint("New Variable is Added successfully....: " + bFlag + " ", DebugPrintStyle.Standard);

        }

        public void CreateRecipe(string recipeName, string recipeGroupName)
        {
            // Retrieve the recipe group collection.
            myProject.Parent.Parent.DebugPrint("CreateRecipe Function is called  !  ", DebugPrintStyle.Standard);
            IRecipeGroup myRGM = myProject.RecipeGroupCollection[recipeGroupName];

            if (myRGM == null)
            {
                // The specified recipe group collection does not exist,                
                myProject.Parent.Parent.DebugPrint("Recipe Group Manager named " + recipeGroupName + " is Not exists....", DebugPrintStyle.Warning);
                return;
            }

            // Retrieve or create the recipe within the recipe group.
            IRecipe myRecipe = myRGM[recipeName];
            IRecipeGroup myRecipeGroup = myRGM[recipeName] as IRecipeGroup;

            if (myRecipe == null)
            {
                myRecipe = myRGM.CreateRecipe(recipeName);
                myProject.Parent.Parent.DebugPrint("Recipe named :" + recipeName + " is created....", DebugPrintStyle.Standard);
            }
            else
            {
                myProject.Parent.Parent.DebugPrint("Recipe named " + recipeName + " already exists....", DebugPrintStyle.Warning);
            }
        }





    }
}
