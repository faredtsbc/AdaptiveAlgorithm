using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoLayerReandomization
{
    class RunGame
    {
        int dsSize = 0;
        int noOfInteractions = 0;

        Defender def;
        Attacker att; 

        List<string> defList = new List<string>();
        List<string> attList = new List<string>();
        List<string> dataSet = new List<string>();


        public RunGame(int dt, int at, int dsSize, int noOfInteractions)
        {
            this.dsSize = dsSize;
            this.noOfInteractions = noOfInteractions;
            def = new Defender(dt);
            att = new Attacker(at);
        }

        public List<string> runDefender(List<string> attackerList)
        {
            for (int i = 0; i < noOfInteractions; i++)
            {
                int j = i;
                if (i==0)
                defList.Add(def.getTargettoDefend(attackerList[i]));
                else
                defList.Add(def.getTargettoDefend(attackerList[--j]));

            }

            return defList;
        }


        public List<string> getDataSet()
        {
            for (int i = 0; i < dsSize; i++)
            {
                dataSet.Add(att.getTargettoAttack());
            }

            return dataSet;
        }

        public List<string> runAttacker()
        {
            for (int i = 0; i < noOfInteractions; i++)
            {
                attList.Add(att.getTargettoAttack());
            }

            return attList;
        }

        public int getTotalCatches()
        {
            int tc = 0;

            for (int i = 0; i < noOfInteractions - 10; i++)
            {
                
                    if ((defList[i] == attList[i]) || (defList[i + 1] == attList[i]) 
                    || (defList[i + 2] == attList[i]) || (defList[i + 3] == attList[i]) 
                    || (defList[i + 4] == attList[i]) || (defList[i + 5] == attList[i]) 
                    || (defList[i + 6] == attList[i]) || (defList[i + 7] == attList[i]) 
                    || (defList[i + 8] == attList[i]) || (defList[i + 9] == attList[i])
                    || (defList[i + 10] == attList[i]))
                        tc++;

            }

            return tc;
        }
    }
}
