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
    public partial class frmAsignaturas : Form
    {
        BindingSource BindingSourceAsignatura = new BindingSource();

        public frmAsignaturas()
        {
            InitializeComponent();
        }

        bool BlnNuevo = true;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtCODASI.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la Cod Asignatura", "Grabado de Asignatura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNOMASI.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Nombre Asignatura", "Grabado de Asignatura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (BlnNuevo)//Si es un booleano no es necesario poner la asignación
            {
                // Conexión a la BDD
                //Declaro variable con tipo nombre = new..
                using (SqlConnection con = new SqlConnection())
                {
                    //Abrir conexión
                    // cadena de conexión o connect string: donde se tiene q conectar mi programa
                    // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                    con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                    //Conecto 
                    con.Open();

                    //Defino el comando que apunta a ins_alumno
                    //Representa el objeto q vos queres usar en la BDD
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "INS_ASIGNATURA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODASI", txtCODASI.Text);
                        cmd.Parameters.AddWithValue("NOMASI", txtNOMASI.Text);
                      

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCODASI.Text = "";
                        txtNOMASI.Text = "";

                        CargarDatos();

                    }
                }
            }
            else
            {
                //EDITAR REGISTRO
                using (SqlConnection con = new SqlConnection())
                {
                    // cadena de conexión o connect string: donde se tiene q conectar mi programa
                    // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                    con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                    //Conecto 
                    con.Open();

                    //Defino el comando que apunta a ins_alumno
                    //Representa el objeto q vos queres usar en la BDD
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "UPD_ASIGNATURA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODASI", txtCODASI.Text);
                        cmd.Parameters.AddWithValue("NOMASI", txtNOMASI.Text);


                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCODASI.Text = "";
                        txtNOMASI.Text = "";

                       CargarDatos();

                    }
                }
                }

        }

        private void CargarDatos()
        {
            BindingSourceAsignatura.DataSource = GetNotas("SEL_ASIGNATURAS");
            dgvAsignaturas.DataSource = BindingSourceAsignatura;
            dgvAsignaturas.Refresh();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (BlnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar esta Asignatura?", "Borrar Asignatura", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes) //Si presionó el botón SI
                {
                    //Borro registro
                    using (SqlConnection con = new SqlConnection())
                    {
                        //Abrir conexión
                        // cadena de conexión o connect string: donde se tiene q conectar mi programa
                        // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                        con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true";
                        //Conecto 
                        con.Open();

                        //Defino el comando que apunta a del_alumno
                        //Representa el objeto q vos queres usar en la BDD
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            cmd.CommandText = "DEL_ASIGNATURA";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("CODASI", txtCODASI.Text);


                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();

                            txtCODASI.Text = "";
                            txtNOMASI.Text = "";


                            BlnNuevo = true;
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe buscar un alumno para poder borrarlo", "Borrado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCODASI.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la Codigo Asignatura", "Búsqueda de Asignatura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Busca la mat especificada y si la encuentra blnNuevo pasa a false.
            //Si no la encuentra debe permanecer en true.
            using (SqlConnection con = new SqlConnection())
            {
                //Abrir conexión
                // cadena de conexión o connection string: donde se tiene q conectar mi programa
                // a qué servidor, credenciales (nombre de usuario y contraseña o credenciales de usuario de windows)
                con.ConnectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = Escuela; Integrated Security = true"; ; //copiar cadena del botón Grabar
                //Abro conexión
                con.Open();


                //Representa el objeto que utiliza el SP para ejecutarse
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SEL_ASIGNATURA";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("CODASI", txtCODASI.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAlumno.Read())
                        {
                            txtCODASI.Text = DatosAlumno["CODASI"].ToString();
                            txtNOMASI.Text = DatosAlumno["NOMASI"].ToString();
                           

                            BlnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la matrícula ingresada", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BlnNuevo = true;
                    }
                    
                    DatosAlumno.Close();




                }
            }
        }

        private void frmAsignaturas_Load(object sender, EventArgs e)
        {
            //Asigno a mi fuente de dato, la variable que cree
            dgvAsignaturas.DataSource = BindingSourceAsignatura;



            //  BindingSourceAsignatura.DataSource = GetNotas("SEL_ASIGNATURAS");// metodo datasource soporta
            // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview
            CargarDatos();
            SetNotas();
        }

        private void SetNotas()
        {
            dgvAsignaturas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvAsignaturas.Columns[0].HeaderText = "CODIGO ASIGNATURA";
            dgvAsignaturas.Columns[1].HeaderText = "NOMBRE ASIGNATURA";
           


            //Números y fechas van por defecto a la derecha
            ////dgvAsignaturas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ////dgvAsignaturas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ////dgvAsignaturas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            //dgvNotas.Columns[6].Visible = false;
            //dgvNotas.Columns[7].Visible = false;
        }

        private DataTable GetNotas(string SPNombre)
        {

            // Procedimiento pq no devuelve ningun valor
            //SPNombre es el nombre del procedimiento almacenado que llega como parámetro del procedimiento
            DataTable dtAsignaturas = new DataTable();


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
                    SqlDataAdapter daAsignaturas = new SqlDataAdapter();



                    daAsignaturas = new SqlDataAdapter(SPNombre, con);

                    SqlCommandBuilder cbNotas = new SqlCommandBuilder(daAsignaturas);
                    //
                    daAsignaturas.Fill(dtAsignaturas);

                    //

                    return dtAsignaturas;

                }

                catch (SqlException exc)

                {

                    //sólo se ejecuta si se produjo algún error dentro del bloque try
                    MessageBox.Show("No se pudieron recuperar los datos de Asginatura", exc.Message.ToString());


                }
                finally
                {

                    //Con error o sin error se ejecuta


                }

            }
            return dtAsignaturas;
        }
    }
}
