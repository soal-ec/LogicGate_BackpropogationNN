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

        int[] hiddenNeuronCount = { 1, 1, 2 };
        // [ inputCount-2 ], for inputs 2, 3 and 4
        // 2 inputs => 4/10 = 0.4 ~> 1
        // 3 inputs => 9/10 = 0.9 ~> 1
        // 4 inputs => 16/10 = 1.6 ~> 2
        
        int[,] epochsPerClick = { { 720, 850 }, { 0, 0 }, { 1250, 1700 } };
        // [ inputCount-2 , nnType ]
        // { { 2in OR, 2in AND }, { 3in OR, 3in AND }, { 4in OR, 4in AND } }

        int trainCount = 0;
        double tempData = 0.0;

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

            // 2 inputs, (estimated) n hidden layers, 1 output
            nn = new NeuralNet(inputCount, hiddenNeuronCount[nnType], 1);
            
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
            textBoxInfo.Text = $"{s} {inputCount} inputs ({hiddenNeuronCount[inputCount - 2]} hidden neurons)" + Environment.NewLine +
                $"{epochsPerClick[inputCount - 2, nnType]} epochs";

            btnTest.Enabled = true;
            btnTrainNN.Enabled = true;
            textBoxOutput.Clear();
            trainCount = 0;
            btnTrainNN.Text = "Train";
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
                            for (int x = 0; x < epochsPerClick[inputCount - 2, nnType]; x++)
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
                            for (int x = 0; x < epochsPerClick[inputCount - 2, nnType]; x++)
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
                            for (int x = 0; x < epochsPerClick[inputCount - 2, nnType]; x++)
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
                            for (int x = 0; x < epochsPerClick[inputCount - 2, nnType]; x++)
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
            trainCount++;
            btnTrainNN.Text = $"Train({trainCount})"; 
            
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

            tempData = nn.getOuputData(0);
            textBoxOutput.Text = "" + tempData;
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

        private void btnAve_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double successSum = 0;
            for (int i = 0; i < 1000; i++)
            {
                btnCreateBPNN_Click(sender, e);
                btnTrainNN_Click(sender, e);
                if (nnType == 0)
                {
                    textBoxInput1.Text = "" + 0;
                    textBoxInput2.Text = "" + 0;
                    textBoxInput3.Text = "" + 0;
                    textBoxInput4.Text = "" + 0;
                    btnTest_Click(sender, e);
                    sum += tempData;
                    if (tempData < .5)
                    {
                        successSum += 1;
                    }
                    else
                    {
                        successSum += 0;
                    }
                }
                else
                {
                    textBoxInput1.Text = "" + 1;
                    textBoxInput2.Text = "" + 1;
                    textBoxInput3.Text = "" + 1;
                    textBoxInput4.Text = "" + 1;
                    btnTest_Click(sender, e);
                    sum += tempData;
                    if (tempData > .5)
                    {
                        successSum += 1;
                    }
                    else
                    {
                        successSum += 0;
                    }
                }
            }
            labelAve.Visible = true;
            labelAve.Text = $"Ave: {sum/1000}, Success rate: {successSum/10}%";

        }
    }
}
