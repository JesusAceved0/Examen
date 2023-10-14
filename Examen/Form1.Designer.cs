namespace Examen
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
            btnInsertar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(545, 173);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 125);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Identificadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 125);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtId
            // 
            txtId.Location = new Point(154, 173);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(379, 173);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsertar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
    }
}