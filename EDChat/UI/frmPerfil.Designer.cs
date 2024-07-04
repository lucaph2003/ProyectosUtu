
namespace EDChat.UI
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.pboImagen = new System.Windows.Forms.PictureBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.pboGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1059, 584);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 506;
            this.lineShape4.X2 = 808;
            this.lineShape4.Y1 = 229;
            this.lineShape4.Y2 = 229;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 506;
            this.lineShape3.X2 = 808;
            this.lineShape3.Y1 = 148;
            this.lineShape3.Y2 = 148;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 1059;
            this.lineShape1.Y1 = 57;
            this.lineShape1.Y2 = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foto de Perfil";
            // 
            // pboImagen
            // 
            this.pboImagen.Image = ((System.Drawing.Image)(resources.GetObject("pboImagen.Image")));
            this.pboImagen.Location = new System.Drawing.Point(84, 122);
            this.pboImagen.Name = "pboImagen";
            this.pboImagen.Size = new System.Drawing.Size(170, 161);
            this.pboImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboImagen.TabIndex = 3;
            this.pboImagen.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(214, 248);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(40, 35);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "...";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(504, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 19);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre : ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(504, 180);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(83, 19);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido :";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(508, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(302, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(508, 202);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(302, 20);
            this.txtApellido.TabIndex = 14;
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.AutoSize = true;
            this.lnkChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkChangePassword.Location = new System.Drawing.Point(518, 441);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(253, 21);
            this.lnkChangePassword.TabIndex = 18;
            this.lnkChangePassword.TabStop = true;
            this.lnkChangePassword.Text = "Desea cambiar la contrasenia?";
            this.lnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // pboGuardar
            // 
            this.pboGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pboGuardar.Image")));
            this.pboGuardar.Location = new System.Drawing.Point(753, 294);
            this.pboGuardar.Name = "pboGuardar";
            this.pboGuardar.Size = new System.Drawing.Size(57, 50);
            this.pboGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboGuardar.TabIndex = 19;
            this.pboGuardar.TabStop = false;
            this.pboGuardar.Click += new System.EventHandler(this.pboGuardar_Click);
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1059, 584);
            this.Controls.Add(this.pboGuardar);
            this.Controls.Add(this.lnkChangePassword);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.pboImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfil";
            this.Text = "frmPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.pboImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboImagen;
        private System.Windows.Forms.Button btnSeleccionar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
        private System.Windows.Forms.PictureBox pboGuardar;
    }
}