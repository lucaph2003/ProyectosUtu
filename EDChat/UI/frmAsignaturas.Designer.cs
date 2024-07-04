
namespace EDChat.UI
{
    partial class frmAsignaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignaturas));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaAsignaturas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboCantHoras = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantHoras = new System.Windows.Forms.Label();
            this.pboEliminar = new System.Windows.Forms.PictureBox();
            this.pboModificar = new System.Windows.Forms.PictureBox();
            this.pboLimpiar = new System.Windows.Forms.PictureBox();
            this.pboGuardar = new System.Windows.Forms.PictureBox();
            this.pboRefrescar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRefrescar)).BeginInit();
            this.SuspendLayout();
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
            this.shapeContainer1.Size = new System.Drawing.Size(1043, 545);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 690;
            this.lineShape3.X2 = 885;
            this.lineShape3.Y1 = 240;
            this.lineShape3.Y2 = 240;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 690;
            this.lineShape2.X2 = 885;
            this.lineShape2.Y1 = 180;
            this.lineShape2.Y2 = 180;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 1059;
            this.lineShape1.Y1 = 57;
            this.lineShape1.Y2 = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignaturas";
            // 
            // ListaAsignaturas
            // 
            this.ListaAsignaturas.BackColor = System.Drawing.Color.LightGray;
            this.ListaAsignaturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaAsignaturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaAsignaturas.FormattingEnabled = true;
            this.ListaAsignaturas.ItemHeight = 21;
            this.ListaAsignaturas.Location = new System.Drawing.Point(70, 84);
            this.ListaAsignaturas.Name = "ListaAsignaturas";
            this.ListaAsignaturas.Size = new System.Drawing.Size(391, 441);
            this.ListaAsignaturas.TabIndex = 2;
            this.ListaAsignaturas.SelectedIndexChanged += new System.EventHandler(this.ListaAsignaturas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ABM Asignaturas";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(690, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // cboCantHoras
            // 
            this.cboCantHoras.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCantHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCantHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCantHoras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCantHoras.FormattingEnabled = true;
            this.cboCantHoras.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboCantHoras.Location = new System.Drawing.Point(690, 210);
            this.cboCantHoras.Name = "cboCantHoras";
            this.cboCantHoras.Size = new System.Drawing.Size(195, 29);
            this.cboCantHoras.TabIndex = 10;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(531, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 21);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblCantHoras
            // 
            this.lblCantHoras.AutoSize = true;
            this.lblCantHoras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantHoras.Location = new System.Drawing.Point(531, 213);
            this.lblCantHoras.Name = "lblCantHoras";
            this.lblCantHoras.Size = new System.Drawing.Size(142, 21);
            this.lblCantHoras.TabIndex = 12;
            this.lblCantHoras.Text = "Cantidad Horas :";
            // 
            // pboEliminar
            // 
            this.pboEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pboEliminar.Image")));
            this.pboEliminar.Location = new System.Drawing.Point(525, 357);
            this.pboEliminar.Name = "pboEliminar";
            this.pboEliminar.Size = new System.Drawing.Size(59, 50);
            this.pboEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboEliminar.TabIndex = 15;
            this.pboEliminar.TabStop = false;
            this.pboEliminar.Click += new System.EventHandler(this.pboEliminar_Click);
            // 
            // pboModificar
            // 
            this.pboModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboModificar.Image = ((System.Drawing.Image)(resources.GetObject("pboModificar.Image")));
            this.pboModificar.Location = new System.Drawing.Point(625, 357);
            this.pboModificar.Name = "pboModificar";
            this.pboModificar.Size = new System.Drawing.Size(59, 50);
            this.pboModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboModificar.TabIndex = 16;
            this.pboModificar.TabStop = false;
            this.pboModificar.Click += new System.EventHandler(this.pboModificar_Click);
            // 
            // pboLimpiar
            // 
            this.pboLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("pboLimpiar.Image")));
            this.pboLimpiar.Location = new System.Drawing.Point(720, 357);
            this.pboLimpiar.Name = "pboLimpiar";
            this.pboLimpiar.Size = new System.Drawing.Size(76, 50);
            this.pboLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboLimpiar.TabIndex = 17;
            this.pboLimpiar.TabStop = false;
            this.pboLimpiar.Click += new System.EventHandler(this.pboLimpiar_Click);
            // 
            // pboGuardar
            // 
            this.pboGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pboGuardar.Image")));
            this.pboGuardar.Location = new System.Drawing.Point(830, 357);
            this.pboGuardar.Name = "pboGuardar";
            this.pboGuardar.Size = new System.Drawing.Size(67, 50);
            this.pboGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboGuardar.TabIndex = 18;
            this.pboGuardar.TabStop = false;
            this.pboGuardar.Click += new System.EventHandler(this.pboGuardar_Click);
            // 
            // pboRefrescar
            // 
            this.pboRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("pboRefrescar.Image")));
            this.pboRefrescar.Location = new System.Drawing.Point(437, 60);
            this.pboRefrescar.Name = "pboRefrescar";
            this.pboRefrescar.Size = new System.Drawing.Size(24, 21);
            this.pboRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboRefrescar.TabIndex = 19;
            this.pboRefrescar.TabStop = false;
            this.pboRefrescar.Click += new System.EventHandler(this.pboRefrescar_Click);
            // 
            // frmAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1043, 545);
            this.Controls.Add(this.pboRefrescar);
            this.Controls.Add(this.pboGuardar);
            this.Controls.Add(this.pboLimpiar);
            this.Controls.Add(this.pboModificar);
            this.Controls.Add(this.pboEliminar);
            this.Controls.Add(this.lblCantHoras);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboCantHoras);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListaAsignaturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsignaturas";
            this.Text = "frmAsignaturas";
            ((System.ComponentModel.ISupportInitialize)(this.pboEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboRefrescar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListaAsignaturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboCantHoras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantHoras;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.PictureBox pboEliminar;
        private System.Windows.Forms.PictureBox pboModificar;
        private System.Windows.Forms.PictureBox pboLimpiar;
        private System.Windows.Forms.PictureBox pboGuardar;
        private System.Windows.Forms.PictureBox pboRefrescar;
    }
}