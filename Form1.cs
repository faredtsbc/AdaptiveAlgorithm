using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SolverFoundation.Services;

namespace TwoLayerReandomization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value != 0)
            {
                listBox1.DataSource = null;
                listBox2.DataSource = null;

                Lbltc.Text = "0";
                lblavg.Text = "0";
                int attackerType = 0;
                int defenderType = 0;
                List<string> dataSet = null;
                List<string> attackerList;
                int totalNoOfCatches = 0;

                RadioButton attackerRB = groupBox3.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                RadioButton defenderRB = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                attackerType = Convert.ToInt16(attackerRB.Tag);
                defenderType = Convert.ToInt16(defenderRB.Tag);


           if (rdbtnadaptivewsb.Checked)
                {
                    AprioriAlgorithm.associationMatrix = new int[11, 11]
                   {
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7},
                {0, 7, 7, 19, 7, 7, 7, 7, 25, 7, 7}
                  };

                }

             RunGame runGame = new RunGame(defenderType, attackerType, (int)numericUpDown1.Value, (int)numericUpDown2.Value);

                    if (rdbtnadaptivewsb.Checked)
                    {
                       dataSet = runGame.getDataSet();
                        AprioriAlgorithm.CalculateAssociations(dataSet);
                    }

                    attackerList = runGame.runAttacker();
                    listBox2.DataSource = attackerList;
                    listBox1.DataSource = runGame.runDefender(attackerList);
                    totalNoOfCatches  = runGame.getTotalCatches();

       
                Lbltc.Text = ( totalNoOfCatches) + " / " + numericUpDown2.Value.ToString();
                lblavg.Text = ((totalNoOfCatches / numericUpDown2.Value) * 100).ToString("#.##") + " %";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decision mixedStrategy = SBFollower.SBFF();
            listBox2.Items.Clear();
            listBox2.Items.Add(" ");
            foreach (object[] value in mixedStrategy.GetValues())
            {
                listBox2.Items.Add(value[1].ToString() + " : " + ((double)value[0]).ToString("P2"));
                listBox2.Items.Add("-------------------------------------------------");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbltcatches_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
