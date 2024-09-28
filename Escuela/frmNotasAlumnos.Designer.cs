namespace Escuela
{
    partial class frmNotasAlumno
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnBucar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labell = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.Label();
            this.txtNotMax = new System.Windows.Forms.Label();
            this.txtNotMin = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtIngreso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(94, 25);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(167, 20);
            this.txtMatricula.TabIndex = 2;
            // 
            // btnBucar
            // 
            this.btnBucar.Location = new System.Drawing.Point(278, 25);
            this.btnBucar.Name = "btnBucar";
            this.btnBucar.Size = new System.Drawing.Size(73, 20);
            this.btnBucar.TabIndex = 3;
            this.btnBucar.Text = "BUSCAR";
            this.btnBucar.UseVisualStyleBackColor = true;
            this.btnBucar.Click += new System.EventHandler(this.btnBucar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Location = new System.Drawing.Point(34, 82);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(47, 13);
            this.labell.TabIndex = 5;
            this.labell.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre:";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(110, 82);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(54, 13);
            this.txtApellido.TabIndex = 8;
            this.txtApellido.Text = "lblApellido";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(110, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(54, 13);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "lblNombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Promedio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Nota Maxima:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(335, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Nota Minima:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.AutoSize = true;
            this.txtPromedio.Location = new System.Drawing.Point(420, 82);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(61, 13);
            this.txtPromedio.TabIndex = 14;
            this.txtPromedio.Text = "lblPromedio";
            // 
            // txtNotMax
            // 
            this.txtNotMax.AutoSize = true;
            this.txtNotMax.Location = new System.Drawing.Point(421, 124);
            this.txtNotMax.Name = "txtNotMax";
            this.txtNotMax.Size = new System.Drawing.Size(60, 13);
            this.txtNotMax.TabIndex = 15;
            this.txtNotMax.Text = "lblNotaMax";
            // 
            // txtNotMin
            // 
            this.txtNotMin.AutoSize = true;
            this.txtNotMin.Location = new System.Drawing.Point(421, 165);
            this.txtNotMin.Name = "txtNotMin";
            this.txtNotMin.Size = new System.Drawing.Size(57, 13);
            this.txtNotMin.TabIndex = 16;
            this.txtNotMin.Text = "lblNotaMin";
            // 
            // dgvNotas
            // 
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(31, 243);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(479, 189);
            this.dgvNotas.TabIndex = 17;
            this.dgvNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 448);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtIngreso
            // 
            this.txtIngreso.AutoSize = true;
            this.txtIngreso.Location = new System.Drawing.Point(112, 165);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(52, 13);
            this.txtIngreso.TabIndex = 22;
            this.txtIngreso.Text = "lblIngreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Codigo Postal:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(115, 205);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(79, 13);
            this.lblCP.TabIndex = 24;
            this.lblCP.Text = "lblCodigoPostal";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(410, 205);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(100, 13);
            this.lblFN.TabIndex = 26;
            this.lblFN.Text = "lblFechaNacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ingreso:";
            // 
            // frmNotasAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(536, 489);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.txtNotMin);
            this.Controls.Add(this.txtNotMax);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBucar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNotasAlumno";
            this.Text = "Notas Alumno";
            this.Load += new System.EventHandler(this.frmNotasAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnBucar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtPromedio;
        private System.Windows.Forms.Label txtNotMax;
        private System.Windows.Forms.Label txtNotMin;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label txtIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    }
}