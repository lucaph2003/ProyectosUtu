
namespace EDChat.UI
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboMinimizar = new System.Windows.Forms.PictureBox();
            this.pboCerrar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblConPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConNewPassword = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pboMinimizar);
            this.panel1.Controls.Add(this.pboCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 25);
            this.panel1.TabIndex = 0;
            // 
            // pboMinimizar
            // 
            this.pboMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pboMinimizar.Image")));
            this.pboMinimizar.Location = new System.Drawing.Point(341, 3);
            this.pboMinimizar.Name = "pboMinimizar";
            this.pboMinimizar.Size = new System.Drawing.Size(25, 18);
            this.pboMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboMinimizar.TabIndex = 1;
            this.pboMinimizar.TabStop = false;
            this.pboMinimizar.Click += new System.EventHandler(this.pboMinimizar_Click);
            // 
            // pboCerrar
            // 
            this.pboCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pboCerrar.Image")));
            this.pboCerrar.Location = new System.Drawing.Point(372, 3);
            this.pboCerrar.Name = "pboCerrar";
            this.pboCerrar.Size = new System.Drawing.Size(25, 18);
            this.pboCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboCerrar.TabIndex = 0;
            this.pboCerrar.TabStop = false;
            this.pboCerrar.Click += new System.EventHandler(this.pboCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(66, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(253, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cambio de Contraseña";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(25, 115);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(248, 21);
            this.lblOldPassword.TabIndex = 2;
            this.lblOldPassword.Text = "Ingrese su antigua contraseña";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(25, 215);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(234, 21);
            this.lblNewPassword.TabIndex = 3;
            this.lblNewPassword.Text = "Escriba su nueva contraseña";
            // 
            // lblConPassword
            // 
            this.lblConPassword.AutoSize = true;
            this.lblConPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPassword.Location = new System.Drawing.Point(25, 315);
            this.lblConPassword.Name = "lblConPassword";
            this.lblConPassword.Size = new System.Drawing.Size(230, 21);
            this.lblConPassword.TabIndex = 4;
            this.lblConPassword.Text = "Confirme nueva contraseña";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(30, 145);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(243, 20);
            this.txtOldPassword.TabIndex = 5;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(30, 245);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(243, 20);
            this.txtNewPassword.TabIndex = 6;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtConNewPassword
            // 
            this.txtConNewPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNewPassword.Location = new System.Drawing.Point(30, 345);
            this.txtConNewPassword.Name = "txtConNewPassword";
            this.txtConNewPassword.Size = new System.Drawing.Size(243, 20);
            this.txtConNewPassword.TabIndex = 7;
            this.txtConNewPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(82, 404);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(203, 34);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Actualizar Contraseña";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(400, 450);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 30;
            this.lineShape3.X2 = 275;
            this.lineShape3.Y1 = 375;
            this.lineShape3.Y2 = 375;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 30;
            this.lineShape2.X2 = 275;
            this.lineShape2.Y1 = 275;
            this.lineShape2.Y2 = 275;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 30;
            this.lineShape1.X2 = 275;
            this.lineShape1.Y1 = 175;
            this.lineShape1.Y2 = 175;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtConNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblConPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePassword";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboMinimizar;
        private System.Windows.Forms.PictureBox pboCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblConPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}