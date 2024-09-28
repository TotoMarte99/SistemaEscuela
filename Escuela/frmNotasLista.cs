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
    public partial class frmNotasLista : Form
    {

        //Objeto que me permite linkear los datos con la grilla
        BindingSource BindingSourceNotas = new BindingSource();

        public frmNotasLista()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNotasLista_Load(object sender, EventArgs e)
        {
            //Asigno a mi fuente de dato, la variable que cree
            dgvNotas.DataSource = BindingSourceNotas;



            BindingSourceNotas.DataSource = GetNotas("SEL_NOTAS");// metodo datasource soporta
                                                                        // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview

            SetNotas();
        }

        private void SetNotas()
        {
            dgvNotas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvNotas.Columns[0].HeaderText = "MATRICULA NOTA";
            dgvNotas.Columns[1].HeaderText = "NOTA ASIGNTATURA";
            dgvNotas.Columns[2].HeaderText = "TIPO NOTA";
            dgvNotas.Columns[3].HeaderText = "FECHA NOTA";
            dgvNotas.Columns[4].HeaderText = "VALOR NOTA";
            

            //Números y fechas van por defecto a la derecha
            dgvNotas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNotas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNotas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            //dgvNotas.Columns[6].Visible = false;
            //dgvNotas.Columns[7].Visible = false;
        }

        private DataTable GetNotas(string SPNombre)
        {

            // Procedimiento pq no devuelve ningun valor
            //SPNombre es el nombre del procedimiento almacenado que llega como parámetro del procedimiento
            DataTable dtNotas = new DataTable();


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
                    SqlDataAdapter daNotas = new SqlDataAdapter();



                    daNotas = new SqlDataAdapter(SPNombre, con);

                    SqlCommandBuilder cbNotas = new SqlCommandBuilder(daNotas);
                    //
                    daNotas.Fill(dtNotas);

                    //

                    return dtNotas;

                }

                catch (SqlException exc)

                {

                    //sólo se ejecuta si se produjo algún error dentro del bloque try
                    MessageBox.Show("No se pudieron recuperar los datos de notas", exc.Message.ToString());


                }
                finally
                {

                    //Con error o sin error se ejecuta


                }

            }
            return dtNotas;
        }
    }
}
