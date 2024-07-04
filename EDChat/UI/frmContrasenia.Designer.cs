
namespace EDChat.UI
{
    partial class frmContrasenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContrasenia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboCerrar = new System.Windows.Forms.PictureBox();
            this.pboMinimizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pboMinimizar);
            this.panel1.Controls.Add(this.pboCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 25);
            this.panel1.TabIndex = 0;
            // 
            // pboCerrar
            // 
            this.pboCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pboCerrar.Image")));
            this.pboCerrar.Location = new System.Drawing.Point(430, 4);
            this.pboCerrar.Name = "pboCerrar";
            this.pboCerrar.Size = new System.Drawing.Size(25, 18);
            this.pboCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCerrar.TabIndex = 1;
            this.pboCerrar.TabStop = false;
            this.pboCerrar.Click += new System.EventHandler(this.pboCerrar_Click);
            // 
            // pboMinimizar
            // 
            this.pboMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pboMinimizar.Image")));
            this.pboMinimizar.Location = new System.Drawing.Point(399, 4);
            this.pboMinimizar.Name = "pboMinimizar";
            this.pboMinimizar.Size = new System.Drawing.Size(25, 18);
            this.pboMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboMinimizar.TabIndex = 2;
            this.pboMinimizar.TabStop = false;
            this.pboMinimizar.Click += new System.EventHandler(this.pboMinimizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(50, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(370, 19);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ingrese una contraseña para el nuevo ususario";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(96, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(275, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Ingrese Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vuelva a ingresar la contraseña";
            // 
            // txtConPassword
            // 
            this.txtConPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPassword.Location = new System.Drawing.Point(96, 295);
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.Size = new System.Drawing.Size(275, 20);
            this.txtConPassword.TabIndex = 4;
            this.txtConPassword.Text = "Confirme Contraseña";
            this.txtConPassword.TextChanged += new System.EventHandler(this.txtConPassword_TextChanged);
            this.txtConPassword.Enter += new System.EventHandler(this.txtConPassword_Enter);
            this.txtConPassword.Leave += new System.EventHandler(this.txtConPassword_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(460, 417);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 96;
            this.lineShape1.X2 = 370;
            this.lineShape1.Y1 = 140;
            this.lineShape1.Y2 = 140;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 96;
            this.lineShape2.X2 = 370;
            this.lineShape2.Y1 = 320;
            this.lineShape2.Y2 = 320;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(460, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContrasenia";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContrasenia";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboMinimizar;
        private System.Windows.Forms.PictureBox pboCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConPassword;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button1;
    }
}