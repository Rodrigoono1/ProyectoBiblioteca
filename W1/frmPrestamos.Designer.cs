namespace W1
{
    partial class frmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtgDetallePrestamo = new System.Windows.Forms.DataGridView();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblSocio = new System.Windows.Forms.Label();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(510, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(510, 249);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtgDetallePrestamo
            // 
            this.dtgDetallePrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallePrestamo.Location = new System.Drawing.Point(36, 201);
            this.dtgDetallePrestamo.Name = "dtgDetallePrestamo";
            this.dtgDetallePrestamo.Size = new System.Drawing.Size(451, 198);
            this.dtgDetallePrestamo.TabIndex = 3;
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.BackColor = System.Drawing.SystemColors.Control;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(59, 35);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(84, 13);
            this.lblFechaPrestamo.TabIndex = 14;
            this.lblFechaPrestamo.Text = "Fecha Préstamo";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(151, 35);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(89, 20);
            this.dtpFechaPrestamo.TabIndex = 0;
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.BackColor = System.Drawing.SystemColors.Control;
            this.lblSocio.Location = new System.Drawing.Point(59, 80);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(34, 13);
            this.lblSocio.TabIndex = 19;
            this.lblSocio.Text = "Socio";
            // 
            // cmbSocio
            // 
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(151, 77);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(203, 21);
            this.cmbSocio.TabIndex = 1;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.BackColor = System.Drawing.SystemColors.Control;
            this.lblLibro.Location = new System.Drawing.Point(63, 126);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(30, 13);
            this.lblLibro.TabIndex = 21;
            this.lblLibro.Text = "Libro";
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(151, 123);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(203, 21);
            this.cmbLibro.TabIndex = 2;
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 426);
            this.Controls.Add(this.cmbLibro);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.cmbSocio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgDetallePrestamo);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtgDetallePrestamo;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmbLibro;
    }
}