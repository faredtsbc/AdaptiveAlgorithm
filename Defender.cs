using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoLayerReandomization
{
    class Defender
    {
        Modes mode;
        Random random;

        public Defender(int mode)
        {
            if (mode ==1)
            {
                this.mode = Modes.stackelbergLeader;
            }
            else if (mode == 3)
            {
                this.mode = Modes.uniformRandomization;
            }
            else if (mode == 4)
            {
                this.mode = Modes.adaptivemodewsb;
            }

            random = new Random();
        }

        public string getTargettoDefend(string attackerLastTarget)
        {
         

            if (this.mode == Modes.stackelbergLeader)
            {
                return pSBL();
            }
            else if (this.mode == Modes.adaptivemodewsb)
            {
                return getAdaptiveTarget(attackerLastTarget);
            }
            else
            {
                return uniformRandomization();
            }
        }

        private String getAdaptiveTarget(string attackLastTarget)
        {
            int index = -1;
            int attackLT = 0;
            
            switch(attackLastTarget)
            {
                case "T1":
                    attackLT = 1;
                    break;
                case "T2":
                    attackLT = 2;
                    break;
                case "T3":
                    attackLT = 3;
                    break;
                case "T4":
                    attackLT = 4;
                    break;
                case "T5":
                    attackLT = 5;
                    break;
                case "T6":
                    attackLT = 6;
                    break;
                case "T7":
                    attackLT = 7;
                    break;
                case "T8":
                    attackLT = 8;
                    break;
                case "T9":
                    attackLT = 9;
                    break;
                case "T10":
                    attackLT = 10;
                    break;
            }
            string[] targets = Targets.getTargets();
            double[] mixedStartegy = AprioriAlgorithm.getMixedStrategy(attackLT);
            List<string> transformedTargets = new List<string>();

            for (int j = 0; j < mixedStartegy.Length; j++)
            {
                for (int i = 0; i < mixedStartegy[j] * 1000; i++)
                {
                    transformedTargets.Add(targets[j]);
                }
            }

            index = random.Next(0, transformedTargets.Count);

            return transformedTargets[index];
        }
        private string uniformRandomization()
        {
            int index = -1;
            string[] targets = Targets.getTargets();

            index = random.Next(0, targets.Length);
            return targets[index];
        }

        private string pSBL()
        {
            int index = -1;

            string[] targets = Targets.getTargets();
            double[] mixedStartegy = new double[] { 0.08, 0.08, 0.15, 0.08, 0.08, 0.08, 0.08, 0.21, 0.08, 0.08 };
            List<string> transformedTargets = new List<string>();

            for (int j = 0; j < mixedStartegy.Length; j++)
            {
                for (int i = 0; i < mixedStartegy[j] * 1000; i++)
                {
                    transformedTargets.Add(targets[j]);
                }
            }

            index = random.Next(0, transformedTargets.Count);

            return transformedTargets[index];
        }

        enum Modes 
        { 
            stackelbergLeader, 
            uniformRandomization,
            adaptivemodewsb
        };  
    }
}
