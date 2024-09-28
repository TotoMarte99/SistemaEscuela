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
    public partial class frmTiposExamen : Form
    {
        BindingSource BindingSourceTipoExamen= new BindingSource();

        bool BlnNuevo = true;

        public frmTiposExamen()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtCODTIP.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Codigo Tipo Examen", "Examen Cargado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNOMTIP.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Nombre Tipo Examen", "Examen Cargado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "INS_TIPO_EXAMEN";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODTIP", txtCODTIP.Text);
                        cmd.Parameters.AddWithValue("NOMTIP", txtNOMTIP.Text);
                       

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCODTIP.Text = "";
                        txtNOMTIP.Text = "";

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
                        cmd.CommandText = "UPD_TIPO_EXAMEN";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("CODTIP", txtCODTIP.Text);
                        cmd.Parameters.AddWithValue("NOMTIP", txtNOMTIP.Text);


                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtCODTIP.Text = "";
                        txtNOMTIP.Text = "";

                        CargarDatos();
                    }

                }
            }
        }

        private void CargarDatos()
        {
            BindingSourceTipoExamen.DataSource = GetTipoExamen("SEL_TIPOS_EXAMEN");
            dgvTipoExamen.DataSource = BindingSourceTipoExamen;
            dgvTipoExamen.Refresh();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (BlnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar este Examen?", "Borrar Examen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                            cmd.CommandText = "DEL_TIPO_EXAMEN";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("CODTIP", txtCODTIP.Text);


                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();


                            txtCODTIP.Text = "";
                            txtNOMTIP.Text = "";


                            BlnNuevo = true;
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe buscar un examen para poder borrarlo", "Borrado de Examen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCODTIP.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la Codigo Tipo Examen", "Búsqueda de Examen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmd.CommandText = "SEL_TIPO_EXAMEN";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("CODTIP", txtCODTIP.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAlumno.Read())
                        {
                            txtCODTIP.Text = DatosAlumno["CODTIP"].ToString();
                            txtNOMTIP.Text = DatosAlumno["NOMTIP"].ToString();
                            

                            BlnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró el Codigo de Examen ingresado", "Búsqueda de Examen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BlnNuevo = true;
                    }

                    DatosAlumno.Close();


                }
            }

        }

        private void frmTiposExamen_Load(object sender, EventArgs e)
        {
            //Asigno a mi fuente de dato, la variable que cree
            dgvTipoExamen.DataSource = BindingSourceTipoExamen;



            BindingSourceTipoExamen.DataSource = GetTipoExamen("SEL_TIPOS_EXAMEN");// metodo datasource soporta
                                                                           // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview

            SetTipoExamen();
        }

        private void SetTipoExamen()
        {
            dgvTipoExamen.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvTipoExamen.Columns[0].HeaderText = "CODIGO EXAMEN";
            dgvTipoExamen.Columns[1].HeaderText = "NOMBRE EXAMEN";



            //Números y fechas van por defecto a la derecha
            ////dgvAsignaturas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ////dgvAsignaturas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ////dgvAsignaturas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            //dgvNotas.Columns[6].Visible = false;
            //dgvNotas.Columns[7].Visible = false;
        }

        private DataTable GetTipoExamen(string SPNombre)
        {

            // Procedimiento pq no devuelve ningun valor
            //SPNombre es el nombre del procedimiento almacenado que llega como parámetro del procedimiento
            DataTable dtTipoExamen = new DataTable();


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
                    SqlDataAdapter daTipoExamen = new SqlDataAdapter();



                    daTipoExamen = new SqlDataAdapter(SPNombre, con);

                    SqlCommandBuilder cbNotas = new SqlCommandBuilder(daTipoExamen);
                    //
                    daTipoExamen.Fill(dtTipoExamen);

                    //

                    return dtTipoExamen;

                }

                catch (SqlException exc)

                {

                    //sólo se ejecuta si se produjo algún error dentro del bloque try
                    MessageBox.Show("No se pudieron recuperar los datos de Examen", exc.Message.ToString());


                }
                finally
                {

                    //Con error o sin error se ejecuta


                }

            }
            return dtTipoExamen;
        }
    }
}