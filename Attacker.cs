using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoLayerReandomization
{
    class Attacker
    {
        Modes mode;
        Random random;

        public Attacker(int mode)
        {
            if (mode == 1)
            {
                this.mode = Modes.random;
            }
            else if (mode == 2)
            {
                this.mode = Modes.sBF;
            }
            else if (mode == 3)
            {
                this.mode = Modes.hiValue;
            }
            else if (mode == 4)
            {
                this.mode = Modes.pattrenMode;
            }
            random = new Random(Guid.NewGuid().GetHashCode());
        }

        public string getTargettoAttack()
        {
            if (this.mode == Modes.random)
            {
                return getRandomTarget();
            }
            else if (this.mode == Modes.sBF)
            {
                return playSBF();
            }
            else if (this.mode == Modes.hiValue)
            {
                return playHiValue();
            }
            else 
            {
                return getPattrenTarget();
            }
        }

        private string getPattrenTarget()
        {
            int index = -1;

            string[] targets = Targets.getTargets();
            double[] mixedStartegy = new double[] { 0.0, 0.25, 0.00, 0.75, 0.0, 0.0, 0.0, 0.00, 0.0, 0.0};
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

        private string playSBF()
        {
            int index = -1;

            string[] targets = Targets.getTargets();
            double[] mixedStartegy = new double[] { 0.03, 0.36, 0.03, 0.40, 0.03, 0.03, 0.03, 0.03, 0.03, 0.03};
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

        private string playHiValue()
        {
            int index = -1;

            string[] targets = Targets.getTargets();
            double[] mixedStartegy = new double[] { 0.007, 0.007, 0.25, 0.007, 0.007, 0.007, 0.007, 0.45, 0.008, 0.25 };
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
        private string getRandomTarget()
        {
            int index = -1;
            string[] targets = Targets.getTargets();

            index = random.Next(0, targets.Length);
            return targets[index];
        }
        enum Modes
        {
            random,
            sBF,
            hiValue,
            pattrenMode
        };  
    }
}
