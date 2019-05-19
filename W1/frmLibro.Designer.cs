namespace W1
{
    partial class frmLibro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAñoPublicacion = new System.Windows.Forms.TextBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(24, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(24, 65);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(334, 65);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 2;
            this.lblEditorial.Text = "Editorial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Año de Publicación";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(137, 23);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(121, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtAñoPublicacion
            // 
            this.txtAñoPublicacion.Location = new System.Drawing.Point(137, 139);
            this.txtAñoPublicacion.Name = "txtAñoPublicacion";
            this.txtAñoPublicacion.Size = new System.Drawing.Size(121, 20);
            this.txtAñoPublicacion.TabIndex = 5;
            // 
            // cmbAutor
            // 
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(137, 65);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(121, 21);
            this.cmbAutor.TabIndex = 6;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(406, 62);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(121, 21);
            this.cmbEditorial.TabIndex = 7;
            // 
            // dgvLibro
            // 
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(27, 224);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.Size = new System.Drawing.Size(348, 150);
            this.dgvLibro.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(416, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(416, 266);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(416, 307);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(416, 345);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(24, 105);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 13;
            this.lblIdioma.Text = "Idioma";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(137, 102);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 21);
            this.cmbIdioma.TabIndex = 14;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(334, 105);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 15;
            this.lblGenero.Text = "Género";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(406, 102);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 21);
            this.cmbGenero.TabIndex = 16;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(334, 26);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 17;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(406, 23);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(121, 20);
            this.txtISBN.TabIndex = 18;
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 526);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.cmbEditorial);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.txtAñoPublicacion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmLibro";
            this.Text = "Libro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAñoPublicacion;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
    }
}

