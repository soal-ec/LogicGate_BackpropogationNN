using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace So_BackPropogationNN
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        int nnType = 0;
        int inputCount = 2;
        int[,] epochsPerClick = { { 600, 1200 }, { 50, 100 } };
        int hiddenNeuronCountEz = 1;
        int[,] hiddenNeuronCount = { {1, 2}, {1, 2} };
        public Form1()
        {
            InitializeComponent();
            comboBoxNN.SelectedIndex = 0;

        }

        private void btnCreateBPNN_Click(object sender, EventArgs e)
        {
            switch (numericUpDownInputCount.Value)
            {
                case 2:
                    textBoxInput3.Visible = false;
                    labelInput3.Visible = false;
                    textBoxInput4.Visible = false;
                    labelInput4.Visible = false;
                    inputCount = 2;
                    break;
                //case 3:
                //    textBoxInput3.Visible = true;
                //    labelInput3.Visible = true;
                //    textBoxInput4.Visible = false;
                //    labelInput4.Visible = false;
                //    inputCount = 3;
                //    break;
                case 4:
                    textBoxInput3.Visible = true;
                    labelInput3.Visible = true;
                    textBoxInput4.Visible = true;
                    labelInput4.Visible = true;
                    inputCount = 4;
                    break;
            }
            
            //nn = new NeuralNet(inputCount, hiddenNeuronCount[nnType, (int)numericUpDownInputCount.Value], 1);
            nn = new NeuralNet(inputCount, hiddenNeuronCountEz, 1);
            // 2 inputs, (estimated) n hidden layers, 1 output
            
            String s = "";
            switch (nnType)
            {
                case 0: // OR
                    s += "OR gate with";
                    break;
                case 1: // AND
                    s += "AND gate with";
                    break;
            }
            textBoxInfo.Text = $"{s} {inputCount} inputs";

            btnTest.Enabled = true;
            btnTrainNN.Enabled = true;
            textBoxOutput.Clear();
        }

        private void btnTrainNN_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                Console.WriteLine("NN not created");
                return;
            }
            switch (nnType)
            {
                case 0: // OR
                    switch (inputCount)
                    {
                        case 2: // OR 2
                            for (int x = 0; x < epochsPerClick[nnType, 0]; x++)
                            {
                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();
                            }
                            break;
                        case 4: // OR 4
                            for (int x = 0; x < epochsPerClick[nnType, 1]; x++)
                            {
                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();
                            }
                            break;
                    }
                    break;
                case 1: // AND
                    switch (inputCount)
                    {
                        case 2: // AND 2
                            for (int x = 0; x < epochsPerClick[nnType, 0]; x++)
                            {
                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();
                            }
                            break;
                        case 4: // AND 4
                            for (int x = 0; x < epochsPerClick[nnType, 1]; x++)
                            {
                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 0.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 0.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 0.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 0.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 0.0);
                                nn.learn();

                                nn.setInputs(0, 1.0);
                                nn.setInputs(1, 1.0);
                                nn.setInputs(2, 1.0);
                                nn.setInputs(3, 1.0);
                                nn.setDesiredOutput(0, 1.0);
                                nn.learn();
                            }
                            break;
                    }
                    break;
            }
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (nn == null)
            {
                Console.WriteLine("NN not created");
                return;
            }
            if (textBoxInput1.Text.Equals("") || textBoxInput2.Text.Equals(""))
            {
                Console.WriteLine("Missing Inputs");
                return;
            }
            nn.setInputs(0, Convert.ToDouble(textBoxInput1.Text));
            nn.setInputs(1, Convert.ToDouble(textBoxInput2.Text));
            if (inputCount == 4)
            {
                if (textBoxInput3.Text.Equals("") || textBoxInput4.Text.Equals(""))
                {
                    Console.WriteLine("Missing Inputs");
                    return;
                }
                nn.setInputs(2, Convert.ToDouble(textBoxInput3.Text));
                nn.setInputs(3, Convert.ToDouble(textBoxInput4.Text));
            }
            nn.run();

            textBoxOutput.Text = "" + nn.getOuputData(0);
        }

        private void comboBoxNN_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxNN.SelectedIndex)
            {
                case 0: // OR
                    nnType = 0;
                    break;
                case 1: // AND
                    nnType = 1;
                    break;
                //case 2: // NOR
                //    break;
                //case 3: // NAND
                //    break;
                //case 4: // XOR
                //    break;
                //case 5: // XAND
                //    break;
                default:
                    break;
            }
        }


    }
}
