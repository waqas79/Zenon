using System;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Frame;
using Scada.AddIn.Contracts.Screen;
using Scada.AddIn.Contracts.Variable;
using Scada.AddIn.Contracts.RecipeGroupManager;
using Scada.AddIn.Contracts.Function;
using System.Diagnostics.Eventing.Reader;
using System.Collections.Generic;
using System.Diagnostics;

namespace _04_Creator
{
    internal class Creator
    {
        IProject myProject = null;
        public Creator(IProject zProject)
        {
            if(zProject == null)
            {
                System.Diagnostics.Debug.Print("No Zenon Reference in Creator Constracted");
            }
            myProject = zProject;
            
        }
        public bool CreateFrame(string FrameName)
        {
            IFrame myFrame = myProject.FrameCollection[FrameName];
            try
            {
                if (myFrame == null)
                {
                    myFrame = myProject.FrameCollection.Create(FrameName, true);
                    myProject.Parent.Parent.DebugPrint("New Frame is created:   " + myFrame.Name, DebugPrintStyle.Standard);
                    return true;
                }
                else
                {
                    myProject.Parent.Parent.DebugPrint("Frame:  " + myFrame.Name + "is already existed and not overwritten. ", DebugPrintStyle.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                myProject.Parent.Parent.DebugPrint("Frame creation Error : " + ex.Message, DebugPrintStyle.Error);
                return false;
            }
        }
        public bool CreateFrame(string FrameName, int iLeft, int iTop,int iRight,int iBottom)
        {
            IFrame myFrame = myProject.FrameCollection[FrameName];
            try
            {


                if (myFrame == null)
                {
                    myFrame = myProject.FrameCollection.Create(FrameName, true);
                    myFrame.Top = iTop;
                    myFrame.Bottom = iBottom;
                    myFrame.Left = iLeft;
                    myFrame.Right = iRight; 


                    myProject.Parent.Parent.DebugPrint("New Frame is created:   " + myFrame.Name, DebugPrintStyle.Standard);
                    return true;
                }
                else
                {
                    myProject.Parent.Parent.DebugPrint("Frame:  " + myFrame.Name + "is already existed and not overwritten. ", DebugPrintStyle.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                myProject.Parent.Parent.DebugPrint("Frame creation Error : " + ex.Message, DebugPrintStyle.Error);
                return false;
            }
        }
        public void CreateScreen(string screenName, string frameName)
        {
            IScreen myScreen = myProject.ScreenCollection[screenName];
            try
            {
                if (myScreen == null)
                {
                    myScreen = myProject.ScreenCollection.Create(screenName, frameName, ScreenType.Standard);
                    myProject.Parent.Parent.DebugPrint("Screen: " + screenName + "already exists!", DebugPrintStyle.Standard);
                }
                else
                {
                    myProject.Parent.Parent.DebugPrint("Screen: " + screenName + "already exists!", DebugPrintStyle.Warning);
                }

            }
            catch(Exception ex)
            {
                myProject.Parent.Parent.DebugPrint("Screen: " + screenName + "already exists!   " + ex.Message, DebugPrintStyle.Error);
            }
            
        }
        public void CreateDriver(string driverName, string driverExe)
        {
           IDriver myDriver = myProject.DriverCollection[driverName];

            if(myDriver == null)
            {
                myDriver = myProject.DriverCollection.Create(driverName, driverExe, false);
                myProject.Parent.Parent.DebugPrint("Driver:  " + driverName + "is created", DebugPrintStyle.Standard);
            }
            else
            {
                myProject.Parent.Parent.DebugPrint("Driver:  " + driverName + "is created", DebugPrintStyle.Warning);
            }
        }
        public void CreateVariable(string variableName, string driverName , ChannelType varChannelType, string DataType)
        {
            try
            {
                IDataType myDataType = myProject.DataTypeCollection[DataType];
                if (myDataType == null)
                {
                    myProject.Parent.Parent.DebugPrint("DataType is not found ... ", DebugPrintStyle.Error);
                    return;
                }
                IDriver myDriver = myProject.DriverCollection[driverName];
                if (myDriver == null)
                {
                    myProject.Parent.Parent.DebugPrint("Driver does not exist in the project!", DebugPrintStyle.Warning);
                    return;
                }
                IVariable myVariable = myProject.VariableCollection[variableName];

                if (myVariable != null)
                {
                    myProject.Parent.Parent.DebugPrint("Variable is already in the project!", DebugPrintStyle.Error);
                    return;
                }
                else
                {
                    myProject.VariableCollection.Create(variableName, myDriver, varChannelType, myDataType);
                    myProject.Parent.Parent.DebugPrint("Variable is created in the project!", DebugPrintStyle.Standard);

                }
            }
            catch(Exception ex)
            {
                myProject.Parent.Parent.DebugPrint("Error in creation of variable : "+ ex.Message, DebugPrintStyle.Error); 
                return;
            }
            
        }
        public void CreateRGM(string recipeGroupName , string varRecipe)
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
        public void CopyFucntion(string orgFunction , string newFunction, string RecipeSelection)
        {
            IFunction zFun = myProject.FunctionCollection[orgFunction];
            myProject.Parent.Parent.DebugPrint("Org Fucntion name is :"+ orgFunction + ":", DebugPrintStyle.Standard);

            try
            {
                IFunction zFctCopy = myProject.FunctionCollection.Create(newFunction, FunctionType.ScreenSwitch);
                myProject.Parent.Parent.DebugPrint("New fucntion name is :" + newFunction + ":", DebugPrintStyle.Standard);

                zFctCopy.Duplicate(zFun);
                myProject.Parent.Parent.DebugPrint("New fucntion : " + newFunction + " is copied from " + orgFunction, DebugPrintStyle.Standard);
                zFctCopy.SetDynamicProperty("PictFilter.Recipe", RecipeSelection);
                myProject.Parent.Parent.DebugPrint("RecipeSelection of " + newFunction + " is changed with " + RecipeSelection, DebugPrintStyle.Standard);

            }
            catch (Exception ex) 
            {
                myProject.Parent.Parent.DebugPrint("Error in creation of New Funcion: " + ex.Message, DebugPrintStyle.Error);
                return;
            }
            // Working related to for loop .... 
            
           
        }

    }
}
