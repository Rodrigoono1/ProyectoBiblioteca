namespace W1
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDevolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditorial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUsuario,
            this.tsmLibro,
            this.tsmAutor,
            this.tsmEditorial});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // tsmUsuario
            // 
            this.tsmUsuario.Name = "tsmUsuario";
            this.tsmUsuario.Size = new System.Drawing.Size(180, 22);
            this.tsmUsuario.Text = "Usuario";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPrestamo,
            this.tsmDevolucion});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // tsmPrestamo
            // 
            this.tsmPrestamo.Name = "tsmPrestamo";
            this.tsmPrestamo.Size = new System.Drawing.Size(180, 22);
            this.tsmPrestamo.Text = "Préstamo";
            // 
            // tsmDevolucion
            // 
            this.tsmDevolucion.Name = "tsmDevolucion";
            this.tsmDevolucion.Size = new System.Drawing.Size(180, 22);
            this.tsmDevolucion.Text = "Devolución";
            // 
            // tsmLibro
            // 
            this.tsmLibro.Name = "tsmLibro";
            this.tsmLibro.Size = new System.Drawing.Size(180, 22);
            this.tsmLibro.Text = "Libro";
            // 
            // tsmAutor
            // 
            this.tsmAutor.Name = "tsmAutor";
            this.tsmAutor.Size = new System.Drawing.Size(180, 22);
            this.tsmAutor.Text = "Autor";
            // 
            // tsmEditorial
            // 
            this.tsmEditorial.Name = "tsmEditorial";
            this.tsmEditorial.Size = new System.Drawing.Size(180, 22);
            this.tsmEditorial.Text = "Editorial";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 467);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuario;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestamo;
        private System.Windows.Forms.ToolStripMenuItem tsmDevolucion;
        private System.Windows.Forms.ToolStripMenuItem tsmLibro;
        private System.Windows.Forms.ToolStripMenuItem tsmAutor;
        private System.Windows.Forms.ToolStripMenuItem tsmEditorial;
    }
}