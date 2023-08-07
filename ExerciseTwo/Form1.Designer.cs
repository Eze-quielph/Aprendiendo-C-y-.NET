namespace ExerciseTwo
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
            submit=new Button();
            InputOne=new TextBox();
            InputTwo=new TextBox();
            InputThree=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            SuspendLayout();
            // 
            // submit
            // 
            submit.Location=new Point(66, 184);
            submit.Name="submit";
            submit.Size=new Size(85, 32);
            submit.TabIndex=0;
            submit.Text="Enviar";
            submit.UseVisualStyleBackColor=true;
            submit.Click+=submit_Click;
            // 
            // InputOne
            // 
            InputOne.Location=new Point(119, 61);
            InputOne.Name="InputOne";
            InputOne.Size=new Size(100, 23);
            InputOne.TabIndex=1;
            // 
            // InputTwo
            // 
            InputTwo.Location=new Point(119, 103);
            InputTwo.Name="InputTwo";
            InputTwo.Size=new Size(100, 23);
            InputTwo.TabIndex=2;
            // 
            // InputThree
            // 
            InputThree.Location=new Point(119, 145);
            InputThree.Name="InputThree";
            InputThree.Size=new Size(100, 23);
            InputThree.TabIndex=3;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(12, 64);
            label1.Name="label1";
            label1.Size=new Size(82, 15);
            label1.TabIndex=4;
            label1.Text="Ingrese num 1";
            label1.Click+=label1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(12, 106);
            label2.Name="label2";
            label2.Size=new Size(82, 15);
            label2.TabIndex=5;
            label2.Text="Ingrese num 2";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(12, 148);
            label3.Name="label3";
            label3.Size=new Size(82, 15);
            label3.TabIndex=6;
            label3.Text="Ingrese num 3";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(231, 287);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(InputThree);
            Controls.Add(InputTwo);
            Controls.Add(InputOne);
            Controls.Add(submit);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit;
        private TextBox InputOne;
        private TextBox InputTwo;
        private TextBox InputThree;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}