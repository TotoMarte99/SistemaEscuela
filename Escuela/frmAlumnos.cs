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
    public partial class frmAlumnos : Form
    {
        BindingSource BindingSourceAlumnos = new BindingSource();

        public frmAlumnos()
        {
            InitializeComponent();
        }

        bool BlnNuevo = true;

        string[] formatosFecha = { "dd/MM/yyyy", "d/M/yyyy" };
        DateTime fecha;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtMatricula.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Apellido", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Nombre", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (txtPostal.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Código Postal", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (txtFechaNac.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Fecha de Nacimiento", "Grabado de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "INS_ALUMNO";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;

                        if (string.IsNullOrEmpty(txtFechaNac.Text) & (string.IsNullOrEmpty(txtMatricula.Text)) & (string.IsNullOrEmpty(txtApellido.Text)) & (string.IsNullOrEmpty(txtNombre.Text)) & (string.IsNullOrEmpty(txtDNI.Text))
                            & (string.IsNullOrEmpty(txtPostal.Text)))
                        {
                            MessageBox.Show("Debe rellenar todos los campos solicitados");
                        }
                        else if (DateTime.TryParseExact(txtFechaNac.Text, formatosFecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha))
                        {
                           
                        }
                        else
                        {
                            // Si el formato de la fecha es incorrecto, mostrar el mensaje y vaciar el campo
                            MessageBox.Show("Fecha inválida. Por favor ingrese la fecha en el formato correcto: dd/MM/yyyy.");
                            txtFechaNac.Clear(); // Vacía el campo de texto
                            txtFechaNac.Focus(); // Pone el cursor de vuelta en el campo de texto para que el usuario lo complete de nuevo
                        }

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);
                        cmd.Parameters.AddWithValue("APEALU", txtApellido.Text);
                        cmd.Parameters.AddWithValue("NOMALU", txtNombre.Text);
                        cmd.Parameters.AddWithValue("DNIALU", txtDNI.Text);

                        cmd.Parameters.AddWithValue("POSALU", txtPostal.Text);
                        cmd.Parameters.AddWithValue("FNAALU", txtFechaNac.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtMatricula.Text = "";
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                        txtDNI.Text = "";

                        txtPostal.Text = "";
                        txtFechaNac.Text = "";

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
                        cmd.CommandText = "UPD_ALUMNO";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);
                        cmd.Parameters.AddWithValue("APEALU", txtApellido.Text);
                        cmd.Parameters.AddWithValue("NOMALU", txtNombre.Text);
                        cmd.Parameters.AddWithValue("DNIALU", txtDNI.Text);

                        cmd.Parameters.AddWithValue("POSALU", txtPostal.Text);
                        cmd.Parameters.AddWithValue("FNAALU", txtFechaNac.Text);

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtMatricula.Text = "";
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                        txtDNI.Text = "";

                        txtPostal.Text = "";
                        txtFechaNac.Text = "";


                        CargarDatos();

                    }


                }
            }


        }

        private void CargarDatos()
        {
            // Este es el método que utilizas para volver a cargar los datos en el DataGridView
            BindingSourceAlumnos.DataSource = GetAlumnos("SEL_ALUMNOS");
            dgvAlumnos.DataSource = BindingSourceAlumnos;
            dgvAlumnos.Refresh();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (BlnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar este alumno?", "Borrar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                            cmd.CommandText = "DEL_ALUMNO";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);


                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();

                            txtMatricula.Text = "";
                            txtApellido.Text = "";
                            txtNombre.Text = "";
                            txtDNI.Text = "";

                            txtPostal.Text = "";
                            txtFechaNac.Text = "";


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
            if (txtMatricula.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Búsqueda de alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmd.CommandText = "SEL_ALUMNO";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("MATALU", txtMatricula.Text);

                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAlumno.Read())
                        {
                            txtApellido.Text = DatosAlumno["APEALU"].ToString();
                            txtNombre.Text = DatosAlumno["NOMALU"].ToString();
                            txtDNI.Text = DatosAlumno["DNIALU"].ToString();
                            txtPostal.Text = DatosAlumno["POSALU"].ToString();
                            txtFechaNac.Text = DatosAlumno["FNAALU"].ToString().Substring(0, 10);

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

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            //Asigno a mi fuente de dato, la variable que cree
            dgvAlumnos.DataSource = BindingSourceAlumnos;



            BindingSourceAlumnos.DataSource = GetAlumnos("SEL_ALUMNOS");// metodo datasource soporta
                                                                        // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview
            SetAlumnos();

            dgvAlumnos.Refresh();
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
    }
}
