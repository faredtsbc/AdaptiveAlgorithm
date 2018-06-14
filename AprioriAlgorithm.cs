using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoLayerReandomization
{
      static class AprioriAlgorithm
    {
        public static int[,] associationMatrix = null;
        static double[] mixedStrategy = new double[10];
        public static double[] getMixedStrategy(int currentAttack)
        {
            int totalRow=0;
            for (int i=1; i<=10; i++)
            {
                totalRow += associationMatrix[currentAttack, i];
            }

            for (int i = 0; i < 10; i++)
            {
                int j = i;
                if (totalRow != 0)
                    mixedStrategy[i] = (double)associationMatrix[currentAttack, ++j] / totalRow;
                else
                    mixedStrategy[i] = 0D;
            }

            return mixedStrategy;
        }

        public  static void CalculateAssociations(List<string> opponentList)
        {
            for (int i = 0; i < opponentList.Count - 1; i++)
            {
                switch (opponentList[i])
                {
                    case "T1":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[1,1]++;
                                break;
                            case "T2":
                                associationMatrix[1, 2]++;
                                break;
                            case "T3":
                                associationMatrix[1, 3]++;
                                break;
                            case "T4":
                                associationMatrix[1, 4]++;
                                break;
                            case "T5":
                                associationMatrix[1, 5]++;
                                break;
                            case "T6":
                                associationMatrix[1, 6]++;
                                break;
                            case "T7":
                                associationMatrix[1, 7]++;
                                break;
                            case "T8":
                                associationMatrix[1, 8]++;
                                break;
                            case "T9":
                                associationMatrix[1, 9]++;
                                break;
                            case "T10":
                                associationMatrix[1, 10]++;
                                break;

                        }
                        break;
                    case "T2":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[2, 1]++;
                                break;
                            case "T2":
                                associationMatrix[2, 2]++;
                                break;
                            case "T3":
                                associationMatrix[2, 3]++;
                                break;
                            case "T4":
                                associationMatrix[2, 4]++;
                                break;
                            case "T5":
                                associationMatrix[2, 5]++;
                                break;
                            case "T6":
                                associationMatrix[2, 6]++;
                                break;
                            case "T7":
                                associationMatrix[2, 7]++;
                                break;
                            case "T8":
                                associationMatrix[2, 8]++;
                                break;
                            case "T9":
                                associationMatrix[2, 9]++;
                                break;
                            case "T10":
                                associationMatrix[2, 10]++;
                                break;

                        }
                        break;
                    case "T3":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[3, 1]++;
                                break;
                            case "T2":
                                associationMatrix[3, 2]++;
                                break;
                            case "T3":
                                associationMatrix[3, 3]++;
                                break;
                            case "T4":
                                associationMatrix[3, 4]++;
                                break;
                            case "T5":
                                associationMatrix[3, 5]++;
                                break;
                            case "T6":
                                associationMatrix[3, 6]++;
                                break;
                            case "T7":
                                associationMatrix[3, 7]++;
                                break;
                            case "T8":
                                associationMatrix[3, 8]++;
                                break;
                            case "T9":
                                associationMatrix[3, 9]++;
                                break;
                            case "T10":
                                associationMatrix[3, 10]++;
                                break;

                        }
                        break;
                    case "T4":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[4, 1]++;
                                break;
                            case "T2":
                                associationMatrix[4, 2]++;
                                break;
                            case "T3":
                                associationMatrix[4, 3]++;
                                break;
                            case "T4":
                                associationMatrix[4, 4]++;
                                break;
                            case "T5":
                                associationMatrix[4, 5]++;
                                break;
                            case "T6":
                                associationMatrix[4, 6]++;
                                break;
                            case "T7":
                                associationMatrix[4, 7]++;
                                break;
                            case "T8":
                                associationMatrix[4, 8]++;
                                break;
                            case "T9":
                                associationMatrix[4, 9]++;
                                break;
                            case "T10":
                                associationMatrix[4, 10]++;
                                break;

                        }
                        break;
                    case "T5":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[5, 1]++;
                                break;
                            case "T2":
                                associationMatrix[5, 2]++;
                                break;
                            case "T3":
                                associationMatrix[5, 3]++;
                                break;
                            case "T4":
                                associationMatrix[5, 4]++;
                                break;
                            case "T5":
                                associationMatrix[5, 5]++;
                                break;
                            case "T6":
                                associationMatrix[5, 6]++;
                                break;
                            case "T7":
                                associationMatrix[5, 7]++;
                                break;
                            case "T8":
                                associationMatrix[5, 8]++;
                                break;
                            case "T9":
                                associationMatrix[5, 9]++;
                                break;
                            case "T10":
                                associationMatrix[5, 10]++;
                                break;

                        }
                        break;
                    case "T6":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[6, 1]++;
                                break;
                            case "T2":
                                associationMatrix[6, 2]++;
                                break;
                            case "T3":
                                associationMatrix[6, 3]++;
                                break;
                            case "T4":
                                associationMatrix[6, 4]++;
                                break;
                            case "T5":
                                associationMatrix[6, 5]++;
                                break;
                            case "T6":
                                associationMatrix[6, 6]++;
                                break;
                            case "T7":
                                associationMatrix[6, 7]++;
                                break;
                            case "T8":
                                associationMatrix[6, 8]++;
                                break;
                            case "T9":
                                associationMatrix[6, 9]++;
                                break;
                            case "T10":
                                associationMatrix[6, 10]++;
                                break;

                        }
                        break;
                    case "T7":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[7, 1]++;
                                break;
                            case "T2":
                                associationMatrix[7, 2]++;
                                break;
                            case "T3":
                                associationMatrix[7, 3]++;
                                break;
                            case "T4":
                                associationMatrix[7, 4]++;
                                break;
                            case "T5":
                                associationMatrix[7, 5]++;
                                break;
                            case "T6":
                                associationMatrix[7, 6]++;
                                break;
                            case "T7":
                                associationMatrix[7, 7]++;
                                break;
                            case "T8":
                                associationMatrix[7, 8]++;
                                break;
                            case "T9":
                                associationMatrix[7, 9]++;
                                break;
                            case "T10":
                                associationMatrix[7, 10]++;
                                break;

                        }
                        break;
                    case "T8":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[8, 1]++;
                                break;
                            case "T2":
                                associationMatrix[8, 2]++;
                                break;
                            case "T3":
                                associationMatrix[8, 3]++;
                                break;
                            case "T4":
                                associationMatrix[8, 4]++;
                                break;
                            case "T5":
                                associationMatrix[8, 5]++;
                                break;
                            case "T6":
                                associationMatrix[8, 6]++;
                                break;
                            case "T7":
                                associationMatrix[8, 7]++;
                                break;
                            case "T8":
                                associationMatrix[8, 8]++;
                                break;
                            case "T9":
                                associationMatrix[8, 9]++;
                                break;
                            case "T10":
                                associationMatrix[8, 10]++;
                                break;

                        }
                        break;
                    case "T9":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[9, 1]++;
                                break;
                            case "T2":
                                associationMatrix[9, 2]++;
                                break;
                            case "T3":
                                associationMatrix[9, 3]++;
                                break;
                            case "T4":
                                associationMatrix[9, 4]++;
                                break;
                            case "T5":
                                associationMatrix[9, 5]++;
                                break;
                            case "T6":
                                associationMatrix[9, 6]++;
                                break;
                            case "T7":
                                associationMatrix[9, 7]++;
                                break;
                            case "T8":
                                associationMatrix[9, 8]++;
                                break;
                            case "T9":
                                associationMatrix[9, 9]++;
                                break;
                            case "T10":
                                associationMatrix[9, 10]++;
                                break;

                        }
                        break;
                    case "T10":
                        switch (opponentList[i+1])
                        {
                            case "T1":
                                associationMatrix[10, 1]++;
                                break;
                            case "T2":
                                associationMatrix[10, 2]++;
                                break;
                            case "T3":
                                associationMatrix[10, 3]++;
                                break;
                            case "T4":
                                associationMatrix[10, 4]++;
                                break;
                            case "T5":
                                associationMatrix[10, 5]++;
                                break;
                            case "T6":
                                associationMatrix[10, 6]++;
                                break;
                            case "T7":
                                associationMatrix[10, 7]++;
                                break;
                            case "T8":
                                associationMatrix[10, 8]++;
                                break;
                            case "T9":
                                associationMatrix[10, 9]++;
                                break;
                            case "T10":
                                associationMatrix[10, 10]++;
                                break;

                        }
                        break;                    

                }
            }
        }
    }
}
