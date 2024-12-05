namespace So_BackPropogationNN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.comboBoxNN = new System.Windows.Forms.ComboBox();
            this.btnCreateBPNN = new System.Windows.Forms.Button();
            this.btnTrainNN = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNNType = new System.Windows.Forms.Label();
            this.labelInputCount = new System.Windows.Forms.Label();
            this.numericUpDownInputCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelInput1 = new System.Windows.Forms.Label();
            this.labelInput2 = new System.Windows.Forms.Label();
            this.labelInput3 = new System.Windows.Forms.Label();
            this.textBoxInput3 = new System.Windows.Forms.TextBox();
            this.labelInput4 = new System.Windows.Forms.Label();
            this.textBoxInput4 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelOutput1 = new System.Windows.Forms.Label();
            this.flpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputCount)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput1.MaxLength = 1;
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(120, 20);
            this.textBoxInput1.TabIndex = 0;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(3, 55);
            this.textBoxInput2.MaxLength = 1;
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(120, 20);
            this.textBoxInput2.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AllowDrop = true;
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(120, 20);
            this.textBoxOutput.TabIndex = 2;
            // 
            // comboBoxNN
            // 
            this.comboBoxNN.FormattingEnabled = true;
            this.comboBoxNN.Items.AddRange(new object[] {
            "OR",
            "AND",
            "(NOR)",
            "(NAND)",
            "(XOR)",
            "(XAND)"});
            this.comboBoxNN.Location = new System.Drawing.Point(0, 16);
            this.comboBoxNN.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.comboBoxNN.Name = "comboBoxNN";
            this.comboBoxNN.Size = new System.Drawing.Size(252, 21);
            this.comboBoxNN.TabIndex = 3;
            this.comboBoxNN.SelectedIndexChanged += new System.EventHandler(this.comboBoxNN_SelectedIndexChanged);
            // 
            // btnCreateBPNN
            // 
            this.btnCreateBPNN.Location = new System.Drawing.Point(0, 108);
            this.btnCreateBPNN.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCreateBPNN.Name = "btnCreateBPNN";
            this.btnCreateBPNN.Size = new System.Drawing.Size(252, 23);
            this.btnCreateBPNN.TabIndex = 4;
            this.btnCreateBPNN.Text = "btnCreateBPNN";
            this.btnCreateBPNN.UseVisualStyleBackColor = true;
            this.btnCreateBPNN.Click += new System.EventHandler(this.btnCreateBPNN_Click);
            // 
            // btnTrainNN
            // 
            this.btnTrainNN.Enabled = false;
            this.btnTrainNN.Location = new System.Drawing.Point(0, 305);
            this.btnTrainNN.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnTrainNN.Name = "btnTrainNN";
            this.btnTrainNN.Size = new System.Drawing.Size(252, 23);
            this.btnTrainNN.TabIndex = 5;
            this.btnTrainNN.Text = "btnTrainNN";
            this.btnTrainNN.UseVisualStyleBackColor = true;
            this.btnTrainNN.Click += new System.EventHandler(this.btnTrainNN_Click);
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(0, 334);
            this.btnTest.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(252, 23);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // flpMain
            // 
            this.flpMain.AutoSize = true;
            this.flpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMain.Controls.Add(this.labelNNType);
            this.flpMain.Controls.Add(this.comboBoxNN);
            this.flpMain.Controls.Add(this.labelInputCount);
            this.flpMain.Controls.Add(this.numericUpDownInputCount);
            this.flpMain.Controls.Add(this.textBoxInfo);
            this.flpMain.Controls.Add(this.btnCreateBPNN);
            this.flpMain.Controls.Add(this.flowLayoutPanel3);
            this.flpMain.Controls.Add(this.btnTrainNN);
            this.flpMain.Controls.Add(this.btnTest);
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(9, 9);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(252, 360);
            this.flpMain.TabIndex = 7;
            // 
            // labelNNType
            // 
            this.labelNNType.AutoSize = true;
            this.labelNNType.Location = new System.Drawing.Point(3, 0);
            this.labelNNType.Name = "labelNNType";
            this.labelNNType.Size = new System.Drawing.Size(31, 13);
            this.labelNNType.TabIndex = 10;
            this.labelNNType.Text = "Type";
            // 
            // labelInputCount
            // 
            this.labelInputCount.AutoSize = true;
            this.labelInputCount.Location = new System.Drawing.Point(3, 40);
            this.labelInputCount.Name = "labelInputCount";
            this.labelInputCount.Size = new System.Drawing.Size(133, 13);
            this.labelInputCount.TabIndex = 9;
            this.labelInputCount.Text = "Input Count for new BPNN";
            // 
            // numericUpDownInputCount
            // 
            this.numericUpDownInputCount.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownInputCount.Location = new System.Drawing.Point(0, 56);
            this.numericUpDownInputCount.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.numericUpDownInputCount.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownInputCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownInputCount.Name = "numericUpDownInputCount";
            this.numericUpDownInputCount.Size = new System.Drawing.Size(252, 20);
            this.numericUpDownInputCount.TabIndex = 11;
            this.numericUpDownInputCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.AllowDrop = true;
            this.textBoxInfo.Enabled = false;
            this.textBoxInfo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxInfo.Location = new System.Drawing.Point(0, 82);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(252, 20);
            this.textBoxInfo.TabIndex = 6;
            this.textBoxInfo.Text = "No BPNN created yet";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 137);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(252, 162);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.labelInput1);
            this.flowLayoutPanel2.Controls.Add(this.textBoxInput1);
            this.flowLayoutPanel2.Controls.Add(this.labelInput2);
            this.flowLayoutPanel2.Controls.Add(this.textBoxInput2);
            this.flowLayoutPanel2.Controls.Add(this.labelInput3);
            this.flowLayoutPanel2.Controls.Add(this.textBoxInput3);
            this.flowLayoutPanel2.Controls.Add(this.labelInput4);
            this.flowLayoutPanel2.Controls.Add(this.textBoxInput4);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(126, 156);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // labelInput1
            // 
            this.labelInput1.AutoSize = true;
            this.labelInput1.Location = new System.Drawing.Point(3, 0);
            this.labelInput1.Name = "labelInput1";
            this.labelInput1.Size = new System.Drawing.Size(40, 13);
            this.labelInput1.TabIndex = 4;
            this.labelInput1.Text = "Input 1";
            // 
            // labelInput2
            // 
            this.labelInput2.AutoSize = true;
            this.labelInput2.Location = new System.Drawing.Point(3, 39);
            this.labelInput2.Name = "labelInput2";
            this.labelInput2.Size = new System.Drawing.Size(40, 13);
            this.labelInput2.TabIndex = 5;
            this.labelInput2.Text = "Input 2";
            // 
            // labelInput3
            // 
            this.labelInput3.AutoSize = true;
            this.labelInput3.Location = new System.Drawing.Point(3, 78);
            this.labelInput3.Name = "labelInput3";
            this.labelInput3.Size = new System.Drawing.Size(40, 13);
            this.labelInput3.TabIndex = 6;
            this.labelInput3.Text = "Input 3";
            this.labelInput3.Visible = false;
            // 
            // textBoxInput3
            // 
            this.textBoxInput3.Location = new System.Drawing.Point(3, 94);
            this.textBoxInput3.MaxLength = 1;
            this.textBoxInput3.Name = "textBoxInput3";
            this.textBoxInput3.Size = new System.Drawing.Size(120, 20);
            this.textBoxInput3.TabIndex = 2;
            this.textBoxInput3.Visible = false;
            // 
            // labelInput4
            // 
            this.labelInput4.AutoSize = true;
            this.labelInput4.Location = new System.Drawing.Point(3, 117);
            this.labelInput4.Name = "labelInput4";
            this.labelInput4.Size = new System.Drawing.Size(40, 13);
            this.labelInput4.TabIndex = 7;
            this.labelInput4.Text = "Input 4";
            this.labelInput4.Visible = false;
            // 
            // textBoxInput4
            // 
            this.textBoxInput4.Location = new System.Drawing.Point(3, 133);
            this.textBoxInput4.MaxLength = 1;
            this.textBoxInput4.Name = "textBoxInput4";
            this.textBoxInput4.Size = new System.Drawing.Size(120, 20);
            this.textBoxInput4.TabIndex = 3;
            this.textBoxInput4.Visible = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.labelOutput1);
            this.flowLayoutPanel4.Controls.Add(this.textBoxOutput);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(126, 3);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(126, 39);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // labelOutput1
            // 
            this.labelOutput1.AutoSize = true;
            this.labelOutput1.Location = new System.Drawing.Point(3, 0);
            this.labelOutput1.Name = "labelOutput1";
            this.labelOutput1.Size = new System.Drawing.Size(39, 13);
            this.labelOutput1.TabIndex = 5;
            this.labelOutput1.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(279, 377);
            this.Controls.Add(this.flpMain);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Form1";
            this.flpMain.ResumeLayout(false);
            this.flpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInputCount)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxNN;
        private System.Windows.Forms.Button btnCreateBPNN;
        private System.Windows.Forms.Button btnTrainNN;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxInput3;
        private System.Windows.Forms.TextBox textBoxInput4;
        private System.Windows.Forms.Label labelInput1;
        private System.Windows.Forms.Label labelInput2;
        private System.Windows.Forms.Label labelInput3;
        private System.Windows.Forms.Label labelInput4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label labelOutput1;
        private System.Windows.Forms.Label labelNNType;
        private System.Windows.Forms.Label labelInputCount;
        private System.Windows.Forms.NumericUpDown numericUpDownInputCount;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}

