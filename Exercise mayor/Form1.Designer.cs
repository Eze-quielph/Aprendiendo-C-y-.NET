namespace Exercise_mayor
{
    partial class Form1
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
            Submit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            InputNum1 = new TextBox();
            InputNum2 = new TextBox();
            InputNum3 = new TextBox();
            SuspendLayout();
            // 
            // Submit
            // 
            Submit.Location = new Point(70, 193);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 0;
            Submit.Text = "Enviar";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 53);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Num 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 94);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Num 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 132);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Num 3";
            // 
            // InputNum1
            // 
            InputNum1.Location = new Point(79, 50);
            InputNum1.Name = "InputNum1";
            InputNum1.Size = new Size(100, 23);
            InputNum1.TabIndex = 4;
            // 
            // InputNum2
            // 
            InputNum2.Location = new Point(79, 91);
            InputNum2.Name = "InputNum2";
            InputNum2.Size = new Size(100, 23);
            InputNum2.TabIndex = 5;
            // 
            // InputNum3
            // 
            InputNum3.Location = new Point(79, 124);
            InputNum3.Name = "InputNum3";
            InputNum3.Size = new Size(100, 23);
            InputNum3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 261);
            Controls.Add(InputNum3);
            Controls.Add(InputNum2);
            Controls.Add(InputNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Submit;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox InputNum1;
        private TextBox InputNum2;
        private TextBox InputNum3;
    }
}