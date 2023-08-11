namespace Gestion_de_cliente
{
    partial class GestionUsuario
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
            listView=new ListBox();
            txtName=new Label();
            InputName=new TextBox();
            btnSave=new Button();
            btnDelete=new Button();
            InputLastName=new TextBox();
            label1=new Label();
            InputTelefono=new TextBox();
            label2=new Label();
            InputAddres=new TextBox();
            label3=new Label();
            SuspendLayout();
            // 
            // listView
            // 
            listView.FormattingEnabled=true;
            listView.ItemHeight=15;
            listView.Location=new Point(12, 12);
            listView.Name="listView";
            listView.Size=new Size(184, 304);
            listView.TabIndex=0;
            // 
            // txtName
            // 
            txtName.AutoSize=true;
            txtName.Location=new Point(310, 61);
            txtName.Name="txtName";
            txtName.Size=new Size(42, 15);
            txtName.TabIndex=1;
            txtName.Text="Name:";
            // 
            // InputName
            // 
            InputName.Location=new Point(379, 53);
            InputName.Name="InputName";
            InputName.Size=new Size(100, 23);
            InputName.TabIndex=2;
            // 
            // btnSave
            // 
            btnSave.Location=new Point(390, 169);
            btnSave.Name="btnSave";
            btnSave.Size=new Size(75, 23);
            btnSave.TabIndex=3;
            btnSave.Text="Save";
            btnSave.UseVisualStyleBackColor=true;
            btnSave.Click+=btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location=new Point(64, 322);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new Size(75, 24);
            btnDelete.TabIndex=4;
            btnDelete.Text="Delete";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // InputLastName
            // 
            InputLastName.Location=new Point(379, 82);
            InputLastName.Name="InputLastName";
            InputLastName.Size=new Size(100, 23);
            InputLastName.TabIndex=6;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(310, 90);
            label1.Name="label1";
            label1.Size=new Size(64, 15);
            label1.TabIndex=5;
            label1.Text="Last name:";
            // 
            // InputTelefono
            // 
            InputTelefono.Location=new Point(379, 111);
            InputTelefono.Name="InputTelefono";
            InputTelefono.Size=new Size(100, 23);
            InputTelefono.TabIndex=8;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(310, 119);
            label2.Name="label2";
            label2.Size=new Size(55, 15);
            label2.TabIndex=7;
            label2.Text="Telefono:";
            // 
            // InputAddres
            // 
            InputAddres.Location=new Point(379, 140);
            InputAddres.Name="InputAddres";
            InputAddres.Size=new Size(100, 23);
            InputAddres.TabIndex=10;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(310, 148);
            label3.Name="label3";
            label3.Size=new Size(50, 15);
            label3.TabIndex=9;
            label3.Text="Addres: ";
            // 
            // GestionUsuario
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(517, 450);
            Controls.Add(InputAddres);
            Controls.Add(label3);
            Controls.Add(InputTelefono);
            Controls.Add(label2);
            Controls.Add(InputLastName);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(InputName);
            Controls.Add(txtName);
            Controls.Add(listView);
            Name="GestionUsuario";
            Text="Form1";
            Load+=GestionUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listView;
        private Label txtName;
        private TextBox InputName;
        private Button btnSave;
        private Button btnDelete;
        private TextBox InputLastName;
        private Label label1;
        private TextBox InputTelefono;
        private Label label2;
        private TextBox InputAddres;
        private Label label3;
    }
}