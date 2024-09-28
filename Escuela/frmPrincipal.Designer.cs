
namespace Escuela
{
    partial class frmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiònDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiònDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(783, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiònDeAlumnosToolStripMenuItem,
            this.listadoDeAlumnosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // gestiònDeAlumnosToolStripMenuItem
            // 
            this.gestiònDeAlumnosToolStripMenuItem.Name = "gestiònDeAlumnosToolStripMenuItem";
            this.gestiònDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gestiònDeAlumnosToolStripMenuItem.Text = "Gestiòn de Alumnos";
            this.gestiònDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.gestiònDeAlumnosToolStripMenuItem_Click);
            // 
            // listadoDeAlumnosToolStripMenuItem
            // 
            this.listadoDeAlumnosToolStripMenuItem.Name = "listadoDeAlumnosToolStripMenuItem";
            this.listadoDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listadoDeAlumnosToolStripMenuItem.Text = "Listado de Alumnos";
            this.listadoDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAlumnosToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiònDeNotasToolStripMenuItem,
            this.notasDeAlumnoToolStripMenuItem,
            this.listaDeNotasToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // gestiònDeNotasToolStripMenuItem
            // 
            this.gestiònDeNotasToolStripMenuItem.Name = "gestiònDeNotasToolStripMenuItem";
            this.gestiònDeNotasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.gestiònDeNotasToolStripMenuItem.Text = "Gestiòn de Notas";
            this.gestiònDeNotasToolStripMenuItem.Click += new System.EventHandler(this.gestiònDeNotasToolStripMenuItem_Click);
            // 
            // notasDeAlumnoToolStripMenuItem
            // 
            this.notasDeAlumnoToolStripMenuItem.Name = "notasDeAlumnoToolStripMenuItem";
            this.notasDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.notasDeAlumnoToolStripMenuItem.Text = "Notas de Alumno";
            this.notasDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.notasDeAlumnoToolStripMenuItem_Click);
            // 
            // listaDeNotasToolStripMenuItem
            // 
            this.listaDeNotasToolStripMenuItem.Name = "listaDeNotasToolStripMenuItem";
            this.listaDeNotasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listaDeNotasToolStripMenuItem.Text = "Lista de Notas";
            this.listaDeNotasToolStripMenuItem.Click += new System.EventHandler(this.listaDeNotasToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciudadesToolStripMenuItem,
            this.asignaturasToolStripMenuItem,
            this.tiposDeExamenToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // asignaturasToolStripMenuItem
            // 
            this.asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            this.asignaturasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.asignaturasToolStripMenuItem.Text = "Asignaturas";
            this.asignaturasToolStripMenuItem.Click += new System.EventHandler(this.asignaturasToolStripMenuItem_Click);
            // 
            // tiposDeExamenToolStripMenuItem
            // 
            this.tiposDeExamenToolStripMenuItem.Name = "tiposDeExamenToolStripMenuItem";
            this.tiposDeExamenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.tiposDeExamenToolStripMenuItem.Text = "Tipos de Examen";
            this.tiposDeExamenToolStripMenuItem.Click += new System.EventHandler(this.tiposDeExamenToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sistema de Escuela";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiònDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiònDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeNotasToolStripMenuItem;
    }
}

