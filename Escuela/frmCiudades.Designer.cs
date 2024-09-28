
namespace Escuela
{
    partial class frmCiudades
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPOSCIU = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNOMCIU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Postal";
            // 
            // txtPOSCIU
            // 
            this.txtPOSCIU.Location = new System.Drawing.Point(112, 43);
            this.txtPOSCIU.Name = "txtPOSCIU";
            this.txtPOSCIU.Size = new System.Drawing.Size(137, 20);
            this.txtPOSCIU.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(31, 133);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(138, 133);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(29, 466);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(296, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNOMCIU
            // 
            this.txtNOMCIU.Location = new System.Drawing.Point(112, 95);
            this.txtNOMCIU.Name = "txtNOMCIU";
            this.txtNOMCIU.Size = new System.Drawing.Size(137, 20);
            this.txtNOMCIU.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre Ciudad";
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCiudades.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Location = new System.Drawing.Point(29, 173);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.Size = new System.Drawing.Size(440, 278);
            this.dgvCiudades.TabIndex = 9;
            // 
            // frmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(495, 538);
            this.Controls.Add(this.dgvCiudades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNOMCIU);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtPOSCIU);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCiudades";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.frmCiudades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPOSCIU;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNOMCIU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCiudades;
    }
}