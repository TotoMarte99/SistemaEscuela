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
    public partial class frmAlumnosLista : Form
    {

        //Objeto que me permite linkear los datos con la grilla
        BindingSource BindingSourceAlumnos = new BindingSource();


        public frmAlumnosLista()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAlumnosLista_Load(object sender, EventArgs e)
        {
           
        }



        private void SetAlumnos()
        {
            dgvAlumnos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvAlumnos.Columns[0].HeaderText = "Matrícula";
            dgvAlumnos.Columns[1].HeaderText = "Apellido";
            dgvAlumnos.Columns[2].HeaderText = "Nombre";
            dgvAlumnos.Columns[3].HeaderText = "DNI";
            dgvAlumnos.Columns[4].HeaderText = "Código Postal";
            dgvAlumnos.Columns[5].HeaderText = "Fecha de Nacimiento";
            dgvAlumnos.Columns[6].HeaderText = "Fecha carga";
            dgvAlumnos.Columns[7].HeaderText = "Usuario";

            //Números y fechas van por defecto a la derecha
            dgvAlumnos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAlumnos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAlumnos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAlumnos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dgvAlumnos.Columns[6].Visible = false;
            dgvAlumnos.Columns[7].Visible = false;
        }


        private DataTable GetAlumnos(string SPNombre)
        {

            // Procedimiento pq no devuelve ningun valor
            //SPNombre es el nombre del procedimiento almacenado que llega como parámetro del procedimiento
            DataTable dtAlumnos = new DataTable();


            using (SqlConnection con = new SqlConnection())
            {
                //Abrir conexión
                // cadena de conexión o connect string: donde se tiene q conectar mi programa
                // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                //Conecto 
                con.Open();


                try
                {
                    //se ejecuta completo en tanto no haya ningún error

                    // definimos un dataadapter llamado daAlumnos
                    SqlDataAdapter daAlumnos = new SqlDataAdapter();



                    daAlumnos = new SqlDataAdapter(SPNombre, con);

                    SqlCommandBuilder cbAlumnos = new SqlCommandBuilder(daAlumnos);
                    //
                    daAlumnos.Fill(dtAlumnos);

                    //

                    return dtAlumnos;

                }

                catch (SqlException exc)

                {

                    //sólo se ejecuta si se produjo algún error dentro del bloque try
                    MessageBox.Show("No se pudieron recuperar los datos de alumnos", exc.Message.ToString());


                }
                finally
                {

                    //Con error o sin error se ejecuta


                }

            }
            return dtAlumnos;
        }

        private void dgvAlumnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAlumnosLista_Load_1(object sender, EventArgs e)
        {
            ////Asigno a mi fuente de dato, la variable que cree
            //dgvAlumnos.DataSource = BindingSourceAlumnos;



            //BindingSourceAlumnos.DataSource = GetAlumnos("SEL_ALUMNOS");// metodo datasource soporta
            //                                                            // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview

            //SetAlumnos();
        }

        private void frmAlumnosLista_Load_2(object sender, EventArgs e)
        {
            //Asigno a mi fuente de dato, la variable que cree
            dgvAlumnos.DataSource = BindingSourceAlumnos;



            BindingSourceAlumnos.DataSource = GetAlumnos("SEL_ALUMNOS");// metodo datasource soporta
                                                                        // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview

            SetAlumnos();
        }
    }


}

