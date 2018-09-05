using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoLayerReandomization
{
    class Defender2
    {
         Modes mode;
        Random random;

        public Defender2(int mode)
        {
            if (mode ==1)
            {
                this.mode = Modes.singleRandomization;
            }
            else if (mode ==2)
            {
                this.mode = Modes.twoLayerReandomization;
            }
            else if (mode == 3)
            {
                this.mode = Modes.uniformRandomization;
            }

            random = new Random();
        }

        public string getTargettoDefend()
        {
         

            if (this.mode == Modes.singleRandomization)
            {
                return optimizedRandomization();
            }
            else if (this.mode == Modes.twoLayerReandomization)
            {
                int os = random.Next(1, 100);
                int ros = 100 - os;
                List<string> firstLS = new List<string>();

                for (int i=0; i<os; i++)
                {
                    firstLS.Add("os");
                }

                for (int i = 0; i < ros; i++)
                {
                    firstLS.Add("ros");
                }

                int index = random.Next(1, firstLS.Count);

                if (firstLS[index] == "os")
                {
                    return optimizedRandomization();
                }
                else
                {
                    return reverseOptimizedRandomization();
                }
               
            }
            else
            {
                return uniformRandomization();
            }
        }

        private string uniformRandomization()
        {
            int index = -1;
            string[] targets = Targets.getTargets();

            index = random.Next(0, targets.Length);
            return targets[index];
        }

        private string optimizedRandomization()
        {
            int index = -1;

            string[] targets = Targets.getTargets();
            double[] mixedStartegy = new double[] { 0.25, 0.25, 0.1, 0.1, 0.05, 0.07, 0.07, 0.07, 0.02, 0.02 };
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

        private string reverseOptimizedRandomization()
        {
            int index = -1;

            string[] targets = Targets.getTargets();
            double[] mixedStartegy = new double[] { 0.02, 0.02, 0.1, 0.1, 0.05, 0.07, 0.07, 0.07, 0.25, 0.25 };
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
            singleRandomization, 
            twoLayerReandomization,
            uniformRandomization,
        };  
    }
}
