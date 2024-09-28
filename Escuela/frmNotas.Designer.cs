
namespace Escuela
{
    partial class frmNotas
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
            this.form1 = new System.Windows.Forms.Label();
            this.txtMATNOT = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtASINOT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTIPNOT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFECNOT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVALNOT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.SuspendLayout();
            // 
            // form1
            // 
            this.form1.AutoSize = true;
            this.form1.Location = new System.Drawing.Point(31, 39);
            this.form1.Name = "form1";
            this.form1.Size = new System.Drawing.Size(50, 13);
            this.form1.TabIndex = 0;
            this.form1.Text = "Matrìcula";
            // 
            // txtMATNOT
            // 
            this.txtMATNOT.Location = new System.Drawing.Point(101, 36);
            this.txtMATNOT.Name = "txtMATNOT";
            this.txtMATNOT.Size = new System.Drawing.Size(143, 20);
            this.txtMATNOT.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(265, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(157, 251);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(689, 415);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(34, 251);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtASINOT
            // 
            this.txtASINOT.Location = new System.Drawing.Point(101, 72);
            this.txtASINOT.Name = "txtASINOT";
            this.txtASINOT.Size = new System.Drawing.Size(143, 20);
            this.txtASINOT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Asignatura";
            // 
            // txtTIPNOT
            // 
            this.txtTIPNOT.Location = new System.Drawing.Point(101, 115);
            this.txtTIPNOT.Name = "txtTIPNOT";
            this.txtTIPNOT.Size = new System.Drawing.Size(143, 20);
            this.txtTIPNOT.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo Examen";
            // 
            // txtFECNOT
            // 
            this.txtFECNOT.Location = new System.Drawing.Point(101, 160);
            this.txtFECNOT.Name = "txtFECNOT";
            this.txtFECNOT.Size = new System.Drawing.Size(143, 20);
            this.txtFECNOT.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha Nota";
            // 
            // txtVALNOT
            // 
            this.txtVALNOT.Location = new System.Drawing.Point(101, 206);
            this.txtVALNOT.Name = "txtVALNOT";
            this.txtVALNOT.Size = new System.Drawing.Size(143, 20);
            this.txtVALNOT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor Nota";
            // 
            // dgvNota
            // 
            this.dgvNota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNota.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNota.Location = new System.Drawing.Point(265, 75);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.Size = new System.Drawing.Size(511, 286);
            this.dgvNota.TabIndex = 14;
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.txtVALNOT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFECNOT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTIPNOT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtASINOT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMATNOT);
            this.Controls.Add(this.form1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotas";
            this.Text = "Notas ";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label form1;
        private System.Windows.Forms.TextBox txtMATNOT;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtASINOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTIPNOT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFECNOT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVALNOT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNota;
    }
}