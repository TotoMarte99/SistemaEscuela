
namespace Escuela
{
    partial class frmTiposExamen
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtCODTIP = new System.Windows.Forms.TextBox();
            this.form1 = new System.Windows.Forms.Label();
            this.txtNOMTIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTipoExamen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoExamen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(320, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(26, 454);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(134, 146);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(26, 146);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtCODTIP
            // 
            this.txtCODTIP.Location = new System.Drawing.Point(148, 48);
            this.txtCODTIP.Name = "txtCODTIP";
            this.txtCODTIP.Size = new System.Drawing.Size(143, 20);
            this.txtCODTIP.TabIndex = 7;
            // 
            // form1
            // 
            this.form1.AutoSize = true;
            this.form1.Location = new System.Drawing.Point(23, 51);
            this.form1.Name = "form1";
            this.form1.Size = new System.Drawing.Size(105, 13);
            this.form1.TabIndex = 6;
            this.form1.Text = "Codigo Tipo Examen";
            // 
            // txtNOMTIP
            // 
            this.txtNOMTIP.Location = new System.Drawing.Point(148, 105);
            this.txtNOMTIP.Name = "txtNOMTIP";
            this.txtNOMTIP.Size = new System.Drawing.Size(143, 20);
            this.txtNOMTIP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Tipo Examen";
            // 
            // dgvTipoExamen
            // 
            this.dgvTipoExamen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoExamen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTipoExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoExamen.Location = new System.Drawing.Point(26, 183);
            this.dgvTipoExamen.Name = "dgvTipoExamen";
            this.dgvTipoExamen.Size = new System.Drawing.Size(516, 253);
            this.dgvTipoExamen.TabIndex = 10;
            // 
            // frmTiposExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(560, 528);
            this.Controls.Add(this.dgvTipoExamen);
            this.Controls.Add(this.txtNOMTIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCODTIP);
            this.Controls.Add(this.form1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTiposExamen";
            this.Text = "Tipos de Examen";
            this.Load += new System.EventHandler(this.frmTiposExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoExamen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtCODTIP;
        private System.Windows.Forms.Label form1;
        private System.Windows.Forms.TextBox txtNOMTIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipoExamen;
    }
}