namespace MainWindow
{
    partial class MenuForm
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
            buttonTask1 = new Button();
            buttonTask2 = new Button();
            buttonTask4 = new Button();
            buttonTask3 = new Button();
            SuspendLayout();
            // 
            // buttonTask1
            // 
            buttonTask1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTask1.Location = new Point(12, 12);
            buttonTask1.Name = "buttonTask1";
            buttonTask1.Size = new Size(111, 76);
            buttonTask1.TabIndex = 0;
            buttonTask1.Tag = "1";
            buttonTask1.Text = "Task1";
            buttonTask1.UseVisualStyleBackColor = true;
            buttonTask1.Click += buttonTask_Click;
            // 
            // buttonTask2
            // 
            buttonTask2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTask2.Location = new Point(129, 12);
            buttonTask2.Name = "buttonTask2";
            buttonTask2.Size = new Size(111, 76);
            buttonTask2.TabIndex = 1;
            buttonTask2.Tag = "2";
            buttonTask2.Text = "Task2";
            buttonTask2.UseVisualStyleBackColor = true;
            buttonTask2.Click += buttonTask_Click;
            // 
            // buttonTask4
            // 
            buttonTask4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTask4.Location = new Point(129, 94);
            buttonTask4.Name = "buttonTask4";
            buttonTask4.Size = new Size(111, 76);
            buttonTask4.TabIndex = 3;
            buttonTask4.Tag = "4";
            buttonTask4.Text = "Task4";
            buttonTask4.UseVisualStyleBackColor = true;
            buttonTask4.Click += buttonTask_Click;
            // 
            // buttonTask3
            // 
            buttonTask3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTask3.Location = new Point(12, 94);
            buttonTask3.Name = "buttonTask3";
            buttonTask3.Size = new Size(111, 76);
            buttonTask3.TabIndex = 2;
            buttonTask3.Tag = "3";
            buttonTask3.Text = "Task3";
            buttonTask3.UseVisualStyleBackColor = true;
            buttonTask3.Click += buttonTask_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 181);
            Controls.Add(buttonTask4);
            Controls.Add(buttonTask3);
            Controls.Add(buttonTask2);
            Controls.Add(buttonTask1);
            Name = "MenuForm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTask1;
        private Button buttonTask2;
        private Button buttonTask4;
        private Button buttonTask3;
    }
}