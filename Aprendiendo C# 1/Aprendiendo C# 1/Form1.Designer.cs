namespace Aprendiendo_C__1
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
            submit = new Button();
            LabelAge = new Label();
            InputPeso = new TextBox();
            LabelChange = new Label();
            InputAltura = new TextBox();
            SuspendLayout();
            // 
            // submit
            // 
            submit.Location = new Point(141, 158);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 0;
            submit.Text = "Enviar";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // LabelAge
            // 
            LabelAge.AutoSize = true;
            LabelAge.Location = new Point(100, 86);
            LabelAge.Name = "LabelAge";
            LabelAge.Size = new Size(35, 15);
            LabelAge.TabIndex = 1;
            LabelAge.Text = "Peso:";
            // 
            // InputPeso
            // 
            InputPeso.Location = new Point(141, 83);
            InputPeso.Name = "InputPeso";
            InputPeso.Size = new Size(100, 23);
            InputPeso.TabIndex = 2;
            InputPeso.Text = "Ingrese su edad...";
            // 
            // LabelChange
            // 
            LabelChange.AutoSize = true;
            LabelChange.Location = new Point(100, 125);
            LabelChange.Name = "LabelChange";
            LabelChange.Size = new Size(42, 15);
            LabelChange.TabIndex = 4;
            LabelChange.Text = "Altura:";
            // 
            // InputAltura
            // 
            InputAltura.Location = new Point(141, 117);
            InputAltura.Name = "InputAltura";
            InputAltura.Size = new Size(100, 23);
            InputAltura.TabIndex = 5;
            InputAltura.Text = "Ingrese su altura...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 263);
            Controls.Add(InputAltura);
            Controls.Add(LabelChange);
            Controls.Add(InputPeso);
            Controls.Add(LabelAge);
            Controls.Add(submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button submit;
        private Label LabelAge;
        private TextBox InputPeso;
        private Label LabelChange;
        private TextBox InputAltura;
    }
}