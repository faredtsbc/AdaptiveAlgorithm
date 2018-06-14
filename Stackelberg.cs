using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SolverFoundation.Services;

namespace TwoLayerReandomization
{
    public class Stackelberg
    {

        public static Decision SBFD()
        {


            // -----------------------------Game Matrix-------------------------------------------
            IEnumerable<TheModelStructure> pStrategies = new List<TheModelStructure>()
           {

                new TheModelStructure() {tName = "T1", uDC = 5, uAU = 5, uDU = -20, uAC = -24},
                new TheModelStructure() {tName = "T2", uDC = 2, uAU = 2, uDU = -8, uAC = -12},
                new TheModelStructure() {tName = "T3", uDC = 6, uAU = 6, uDU = -24, uAC = -28},
                new TheModelStructure() {tName = "T4", uDC = 2, uAU = 1, uDU = -8, uAC = -12},
                new TheModelStructure() {tName = "T5", uDC = 4, uAU = 4, uDU = -16, uAC = -20},
                new TheModelStructure() {tName = "T6", uDC = 3, uAU = 3, uDU = -9, uAC = -13},
                new TheModelStructure() {tName = "T7", uDC = 3, uAU = 3, uDU = -12, uAC = -16},
                new TheModelStructure() {tName = "T8", uDC = 8, uAU = 7, uDU = -32, uAC = -36},
                new TheModelStructure() {tName = "T9", uDC = 2, uAU = 2, uDU = -8, uAC = -12},
                new TheModelStructure() {tName = "T10", uDC = 6, uAU = 6, uDU = -24, uAC = -28}
                //new TheModelStructure() {tableName = "Table11", tableValue = 5},
                //new TheModelStructure() {tableName = "Table12", tableValue = 3},
                //new TheModelStructure() {tableName = "Table13", tableValue = 4},
                //new TheModelStructure() {tableName = "Table14", tableValue = 3},
                //new TheModelStructure() {tableName = "Table15", tableValue = 4},
                //new TheModelStructure() {tableName = "Table16", tableValue = 7},
                //new TheModelStructure() {tableName = "Table17", tableValue = 5},
                //new TheModelStructure() {tableName = "Table18", tableValue = 8},
                //new TheModelStructure() {tableName = "Table19", tableValue = 4},
                //new TheModelStructure() {tableName = "Table20", tableValue = 5}
           };

            //---------------------------Intilizing the solver----------------------------------------------
            SolverContext context = SolverContext.GetContext();
            Model model = context.CreateModel();
            Set modelStructure = new Set(Domain.Any, "game");

            //----------------------------Game parameters----------------------------------------------------
            Parameter uDC = new Parameter(Domain.Integer, "uDC", modelStructure);
            uDC.SetBinding(pStrategies, "uDC", "tName"); // bind to the  field.
            model.AddParameters(uDC);

            Parameter uDU = new Parameter(Domain.Integer, "uDU", modelStructure);
            uDU.SetBinding(pStrategies, "uDU", "tName"); // bind to the  field.
            model.AddParameters(uDU);


            Parameter uAU = new Parameter(Domain.Integer, "uAU", modelStructure);
            uAU.SetBinding(pStrategies, "uAU", "tName"); // bind to the  field.
            model.AddParameters(uAU);

            Parameter uAC = new Parameter(Domain.Integer, "uAC", modelStructure);
            uAC.SetBinding(pStrategies, "uAC", "tName"); // bind to the  field.
            model.AddParameters(uAC);



            //---------------------------Decision Variables------------------------------------------------
            Decision vMS = new Decision(Domain.RealRange(0.07, 0.25), "vFMS", modelStructure);
            model.AddDecision(vMS);



            //----------------------------Objective function----------------------------------------------

            model.AddGoal("dGoal", GoalKind.Maximize, Model.Sum(
                 Model.ForEach(modelStructure, i => ((uAU[i]) / 40) * vMS[i] * uDC[i] + (1 - vMS[i]) * uDU[i])));

         


            model.AddConstraint("vms",
            Model.Sum(Model.ForEach(modelStructure, i => vMS[i])) == 1);
          


            //-------------------------------Solvig the game------------------------------------
            try
            {
                var solution = context.Solve();
            }
            catch (Exception e)
            {
                throw e;
            }

            context.ClearModel();

            return vMS;

        }
    }

    class TheModelStructure
    {
        public string tName { get; set; }
        public int uDC { get; set; }
        public int uDU { get; set; }

        public int uAU { get; set; }
        public int uAC { get; set; }

        public double dMS { get; set; }


        public TheModelStructure() { }
    }

}
