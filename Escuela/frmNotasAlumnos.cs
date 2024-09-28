using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmNotasAlumno : Form
    {
        BindingSource BindingSourceNotas = new BindingSource();

        public frmNotasAlumno()
        {
            InitializeComponent();
        }

        private void frmNotasAlumno_Load(object sender, EventArgs e)
        {
            dgvNotas.DataSource = BindingSourceNotas;

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtIngreso.Text = "";
            lblCP.Text = "";
            lblFN.Text = "";
            txtNotMin.Text = "";
            txtNotMax.Text = "";
            txtPromedio.Text = "";

            dgvNotas.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            dgvNotas.Visible = false;


            if (txtMatricula.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";

                con.Open();



                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_ALUMNO";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;



                    cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);



                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows)
                    {

                        while (DatosAlumno.Read())
                        {
                            txtApellido.Text = DatosAlumno["APEALU"].ToString();   //Asignación de campo de un data reader a una caja de texto
                            txtNombre.Text = DatosAlumno["NOMALU"].ToString();
                            //txtIngreso.Text = DatosAlumno["FEAALU"].ToString();
                            lblCP.Text = DatosAlumno["POSALU"].ToString();
                            lblFN.Text = DatosAlumno["FNAALU"].ToString().Substring(0, 10);

                            GetNotas("SEL_NOTAS_ALUMNO");



                            dgvNotas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                            dgvNotas.Columns[0].HeaderText = "Fecha";
                            dgvNotas.Columns[1].HeaderText = "Asignatura";
                            dgvNotas.Columns[2].HeaderText = "Tipo Examen";
                            dgvNotas.Columns[3].HeaderText = "Nota";



                            dgvNotas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgvNotas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



                            //Antes de sacar el promedio, me fijo si traje notas
                            if (dgvNotas.Visible)
                            {
                                Promedio();
                            }

                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la matrícula ingresada", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    DatosAlumno.Close();

                }
            }


        }
        private void Promedio()
        {
            using (SqlConnection con = new SqlConnection())
            {

                con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";

                con.Open();


                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_NOTAS_PROMEDIO";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("MATNOT", txtMatricula.Text);

                    SqlDataReader NotasAlumno = cmd.ExecuteReader();

                    if (NotasAlumno.HasRows)
                    {
                        while (NotasAlumno.Read())
                        {
                            txtPromedio.Text = NotasAlumno["PROMEDIO"].ToString();
                            txtNotMin.Text = NotasAlumno["MINIMO"].ToString();
                            txtNotMax.Text = NotasAlumno["MAXIMO"].ToString();
                        }

                    }

                }

            }
        }

        ///PROCEDIMIENTO/FUNCION APARTE

        private void GetNotas(string SPnombre)
        {
            //Procedimiento porque no devuelve ningún valor
            //Void en este contexto es null/nada
            //SPnombre es el nombre del procedimiento almacenado que llega como parámetro de ESTE procedimiento

            try
            {

                SqlConnection cn = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true");
                //Se ejecuta completo en tanto no haya errores


                SqlCommand cmd = new SqlCommand();
                //Creo una datatable (matriz) - no permite modificar/solo mostrar
                DataTable dtNotas = new DataTable();

                //Instancio un obj de clase dataadapter (nueva variable)
                SqlDataAdapter daNotas = new SqlDataAdapter();


                cmd.CommandText = "SEL_NOTAS_ALUMNO";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("MATNOT", txtMatricula.Text);
                cmd.Connection.Open();

                daNotas.SelectCommand = cmd;

                //Conecta a la bdd y llena la datatable
                daNotas.Fill(dtNotas);

                //Me fijo si mi tabla tiene filas, si tiene muestro la grilla cambiando el boolean a true
                if (dtNotas.Rows.Count > 0)
                {
                    dgvNotas.Visible = true;
                }
                else
                {
                    txtPromedio.Text = "Sin notas";
                    txtNotMin.Text = "Sin notas";
                    txtNotMax.Text = "Sin notas";

                    //Otra opción: agregar un message box
                }

                //Le asigno al bindign mi datatable llena y así se muestran finalmente
                BindingSourceNotas.DataSource = dtNotas;

                cmd.Connection.Close();
                cmd.Dispose();
                daNotas.Dispose();
                dtNotas.Dispose();
                cn.Close();
                cn.Dispose();

            }
            catch (SqlException exc)
            {
                //Sólo se ejecuta en caso de error dentro del bloque try
                MessageBox.Show(exc.Message.ToString());

            }
            finally
            {
                //Con error o sin error se ejecuta
            }


        }

    }
}
