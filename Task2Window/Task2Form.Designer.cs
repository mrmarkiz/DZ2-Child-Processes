namespace Task2Window
{
    partial class Task2Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStart = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            labelCode = new Label();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(135, 54);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(107, 38);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "mspaint", "cmd" });
            comboBox1.Location = new Point(12, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 2;
            label1.Text = "Choose process";
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(12, 9);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(0, 20);
            labelCode.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(135, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 24);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "exit in 5 sec";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Task2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 114);
            Controls.Add(radioButton1);
            Controls.Add(labelCode);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(buttonStart);
            Name = "Task2Form";
            Text = "Task2";
            FormClosed += Task2Form_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private ComboBox comboBox1;
        private Label label1;
        private Label labelCode;
        private RadioButton radioButton1;
    }
}