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
            // SAFEty Error indexing
            creator.Helptext_loop("Safety_Error_01", 4001);
            creator.Helptext_loop("Safety_Error_02", 4017);
            creator.Helptext_loop("Safety_Error_03", 4033);
            creator.Helptext_loop("Safety_Error_04", 4049);
            creator.Helptext_loop("Safety_Error_05", 4065);
            creator.Helptext_loop("Safety_Error_06", 4081);
            creator.Helptext_loop("Safety_Error_07", 4097);
            creator.Helptext_loop("Safety_Error_08", 4113);
            creator.Helptext_loop("Safety_Error_09", 4129);
            creator.Helptext_loop("Safety_Error_10", 4145);
            creator.Helptext_loop("Safety_Error_11", 4161);
            creator.Helptext_loop("Safety_Error_12", 4177);

            // ELB Error indexing
            creator.Helptext_loop("ELB_Error_010", 2201);
            creator.Helptext_loop("ELB_Error_020", 2217);
            creator.Helptext_loop("ELB_Error_030", 2233);
            creator.Helptext_loop("ELB_Error_040", 2249);
            creator.Helptext_loop("ELB_Error_050", 2265);

            // CSS Error indexing
            creator.Helptext_loop("CSS_Error_010", 2401);
            creator.Helptext_loop("CSS_Error_020", 2417);

            // AUX Error indexing
            creator.Helptext_loop("AUX_Error_010", 2301);
            creator.Helptext_loop("AUX_Error_020", 2317);

            // ROB1 Error indexing
            creator.Helptext_loop("ROB1_Error_10", 3401);
            creator.Helptext_loop("ROB1_Error_20", 3417);

            // ROB2 Error indexing
            creator.Helptext_loop("ROB2_Error_10", 3433);
            creator.Helptext_loop("ROB2_Error_20", 3449);

            // DR1 Error indexing
            creator.Helptext_loop("DR1_Error_010", 2001);
            creator.Helptext_loop("DR1_Error_020", 2017);

            // DR2 Error indexing
            creator.Helptext_loop("DR2_Error_010", 3201);
            creator.Helptext_loop("DR2_Error_020", 3217);

            // DR3 Error indexing
            creator.Helptext_loop("DR3_Error_010", 3301);
            creator.Helptext_loop("DR3_Error_020", 3317);
            creator.Helptext_loop("DR3_Error_030", 3333);
            creator.Helptext_loop("DR3_Error_040", 3349);
            creator.Helptext_loop("DR3_Error_050", 3365);

            // VAK1 Error indexing
            creator.Helptext_loop("VAK1_Error_01", 801);
            creator.Helptext_loop("VAK1_Error_02", 817);
            creator.Helptext_loop("VAK1_Error_03", 833);
            creator.Helptext_loop("VAK1_Error_04", 849);
            creator.Helptext_loop("VAK1_Error_05", 865);
            creator.Helptext_loop("VAK1_Error_06", 881);

            // VAK2 Error indexing
            creator.Helptext_loop("VAK2_Error_01", 1801);
            creator.Helptext_loop("VAK2_Error_02", 1817);
            creator.Helptext_loop("VAK2_Error_03", 1833);
            creator.Helptext_loop("VAK2_Error_04", 1849);
            creator.Helptext_loop("VAK2_Error_05", 1865);
            creator.Helptext_loop("VAK2_Error_06", 1881);

            // FLK1 Error indexing
            creator.Helptext_loop("FLK1_Error_01", 3101);
            creator.Helptext_loop("FLK1_Error_02", 3117);

            // FLK2 Error indexing
            creator.Helptext_loop("FLK2_Error_01", 2501);

            // UGR1 Error indexing
            creator.Helptext_loop("UGR1_Error_010", 2601);
            // UGR2 Error indexing
            creator.Helptext_loop("UGR2_Error_010", 2633);

            // IO Error indexing
            creator.Helptext_loop("IO_Error_01", 2701);
            creator.Helptext_loop("IO_Error_02", 2717);

            // NIO Error indexing
            creator.Helptext_loop("NIO_Error_01", 2801);
            creator.Helptext_loop("NIO_Error_02", 2817);

            // LCK Error indexing
            creator.Helptext_loop("LCK_Error_01", 2901);
            creator.Helptext_loop("LCK_Error_02", 2917);
            creator.Helptext_loop("LCK_Error_03", 2933);
            // TMB Error indexing
            creator.Helptext_loop("TMB_Error_01", 2101 );
            creator.Helptext_loop("TMB_Error_02", 2117 );
            // Anlage Error indexing
            creator.Helptext_loop("Anlage_Error_01", 01);
            creator.Helptext_loop("Anlage_Error_02", 17);
            creator.Helptext_loop("Anlage_Error_03", 33);
            creator.Helptext_loop("Anlage_Error_04", 49);
            creator.Helptext_loop("Anlage_Error_05", 65);
            creator.Helptext_loop("Anlage_Error_06", 81);
            creator.Helptext_loop("Anlage_Error_07", 97);
            creator.Helptext_loop("Anlage_Error_08", 13);
            creator.Helptext_loop("Anlage_Error_11", 201);
            creator.Helptext_loop("Anlage_Error_12", 217);
            creator.Helptext_loop("Anlage_Error_13", 233);
            creator.Helptext_loop("Anlage_Error_14", 249);
            creator.Helptext_loop("Anlage_Error_15", 265);
            /*
            // Anlage Hint indexing
            creator.Helptext_loop("Anlage_Hint_01", 5101);
            creator.Helptext_loop("Anlage_Hint_02", 5117);
            creator.Helptext_loop("Anlage_Hint_03", 5133);
            creator.Helptext_loop("Anlage_Hint_04", 5149);
            // Anlage Warning indexing
            creator.Helptext_loop("Anlage_Warning_01", 5001);
            creator.Helptext_loop("Anlage_Warning_02", 5017);
            creator.Helptext_loop("Anlage_Warning_03", 5033);
            creator.Helptext_loop("Anlage_Warning_04", 5049);
            */

            // BAG1 Error indexing
            creator.Helptext_loop("BAG1_Allg_Error_010", 401);
            creator.Helptext_loop("BAG1_Allg_Error_020", 417);
            creator.Helptext_loop("BAG1_Allg_Error_030", 433);
            creator.Helptext_loop("BAG1_ASE_Error_010",  545);
            creator.Helptext_loop("BAG1_ASE_Error_020",  561);
            creator.Helptext_loop("BAG1_DRT_Error_010",  513);
            creator.Helptext_loop("BAG1_DRT_Error_020",  529);
            creator.Helptext_loop("BAG1_FALT_Error_010", 641);
            creator.Helptext_loop("BAG1_FALT_Error_020", 657);
            creator.Helptext_loop("BAG1_HOH_Error_010",  673);
            creator.Helptext_loop("BAG1_HOH_Error_020",  689);
            creator.Helptext_loop("BAG1_MAG_Error_010",  449);
            creator.Helptext_loop("BAG1_MAG_Error_020",  465);
            creator.Helptext_loop("BAG1_SEP_Error_010",  481);
            creator.Helptext_loop("BAG1_SEP_Error_020",  497);
            creator.Helptext_loop("BAG1_SWO_Error_010",  577);
            creator.Helptext_loop("BAG1_SWO_Error_020",  593);
            creator.Helptext_loop("BAG1_SWU_Error_010",  609);
            creator.Helptext_loop("BAG1_SWU_Error_020",  625);
            // BAG2 Error indexing
            creator.Helptext_loop("BAG2_Allg_Error_010",1401);
            creator.Helptext_loop("BAG2_Allg_Error_020",1417);
            creator.Helptext_loop("BAG2_Allg_Error_030",1433);
            creator.Helptext_loop("BAG2_ASE_Error_010", 1545);
            creator.Helptext_loop("BAG2_ASE_Error_020", 1561);
            creator.Helptext_loop("BAG2_DRT_Error_010", 1513);
            creator.Helptext_loop("BAG2_DRT_Error_020", 1529);
            creator.Helptext_loop("BAG2_FALT_Error_010",1641);
            creator.Helptext_loop("BAG2_FALT_Error_020",1657);
            creator.Helptext_loop("BAG2_HOH_Error_010", 1673);
            creator.Helptext_loop("BAG2_HOH_Error_020", 1689);
            creator.Helptext_loop("BAG2_MAG_Error_010", 1449);
            creator.Helptext_loop("BAG2_MAG_Error_020", 1465);
            creator.Helptext_loop("BAG2_SEP_Error_010", 1481);
            creator.Helptext_loop("BAG2_SEP_Error_020", 1497);
            creator.Helptext_loop("BAG2_SWO_Error_010", 1577);
            creator.Helptext_loop("BAG2_SWO_Error_020", 1593);
            creator.Helptext_loop("BAG2_SWU_Error_010", 1609);
            creator.Helptext_loop("BAG2_SWU_Error_020", 1625);





        }
        #endregion
    }
}