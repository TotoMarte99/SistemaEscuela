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
    public partial class frmNotas : Form
    {
        bool BlnNuevo = true;

        BindingSource BindingSourceNota = new BindingSource();

        string formatoFecha = "dd/MM/yyyy"; //Formato para fechas nuevas
        DateTime fecha;


        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtMATNOT.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la matrícula", "Grabado de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtASINOT.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Asignatura", "Grabado de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTIPNOT.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Tipo Examen", "Grabado de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (txtFECNOT.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Fecha Nota", "Grabado de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (txtVALNOT.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para Valor Nota", "Grabado de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        cmd.CommandText = "INS_NOTA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;

                       if (string.IsNullOrEmpty(txtFECNOT.Text))
                        {
                            MessageBox.Show("Por favor, ingrese una fecha");
                        }
                       else if (DateTime.TryParseExact(txtFECNOT.Text, formatoFecha, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fecha)){

                        }
                        else
                        {
                            MessageBox.Show("El formato ingresado en la fecha es incorrecto");

                            txtFECNOT.Clear();
                            txtFECNOT.Focus();
                            
                        }

                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATNOT", txtMATNOT.Text);
                        cmd.Parameters.AddWithValue("ASINOT", txtASINOT.Text);
                        cmd.Parameters.AddWithValue("TIPNOT", txtTIPNOT.Text);
                        cmd.Parameters.AddWithValue("FECNOT", txtFECNOT.Text);
                        cmd.Parameters.AddWithValue("VALNOT", txtVALNOT.Text);

                       

                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtMATNOT.Text = "";
                        txtASINOT.Text = "";
                        txtTIPNOT.Text = "";

                        txtFECNOT.Text = "";
                        txtVALNOT.Text = "";


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
                        cmd.CommandText = "UPD_NOTA";//Nombre procedure
                        cmd.CommandType = CommandType.StoredProcedure;//Tipo de comando
                        cmd.Connection = con;



                        //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                        //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT
                        cmd.Parameters.AddWithValue("MATNOT", txtMATNOT.Text);
                        cmd.Parameters.AddWithValue("ASIGNOT", txtASINOT.Text);
                        cmd.Parameters.AddWithValue("TIPNOT", txtTIPNOT.Text);
                        cmd.Parameters.AddWithValue("FECNOT", txtFECNOT.Text);
                        cmd.Parameters.AddWithValue("VALNOT", txtVALNOT.Text);



                        //YO mando datos/insertar, borrar o actualizar
                        cmd.ExecuteNonQuery();

                        txtMATNOT.Text = "";
                        txtASINOT.Text = "";
                        txtTIPNOT.Text = "";

                        txtFECNOT.Text = "";
                        txtVALNOT.Text = "";

                        CargarDatos();
                    }
                }
                }

        }

        private void CargarDatos()
        {
            BindingSourceNota.DataSource = GetNota("SEL_NOTAS");
            dgvNota.DataSource = BindingSourceNota;
            dgvNota.Refresh();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (BlnNuevo == false)//Buscó la matrícula y la encontró
            {
                DialogResult respuesta;

                respuesta = MessageBox.Show("¿Desea borrar esta Nota?", "Borrar Nota", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                            cmd.CommandText = "DEL_NOTA";//Nombre procedure
                            cmd.CommandType = CommandType.StoredProcedure;//Tipo
                            cmd.Connection = con;

                            //SETEO PARAMETROS. ASIGNACION DE VALORES A LOS PARAMETROS
                            //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN EL INPUT - LA PK
                            cmd.Parameters.AddWithValue("MATNOT", txtMATNOT.Text);
                            cmd.Parameters.AddWithValue("ASIGNOT", txtASINOT.Text);
                            cmd.Parameters.AddWithValue("TIPNOT", txtTIPNOT.Text);
                            cmd.Parameters.AddWithValue("FECNOT", txtFECNOT.Text);





                            //EJECUTA EL COMANDO
                            cmd.ExecuteNonQuery();


                            txtMATNOT.Text = "";
                            txtASINOT.Text = "";
                            txtTIPNOT.Text = "";

                            txtFECNOT.Text = "";
                            txtVALNOT.Text = "";


                            BlnNuevo = true;
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe buscar una Nota para poder borrarla", "Borrado de Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtMATNOT.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor para la Codigo Matricula", "Búsqueda de Matricula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    cmd.CommandText = "SEL_NOTA";//Nombre procedure
                    cmd.CommandType = CommandType.StoredProcedure;//Tipo
                    cmd.Connection = con;


                    //LE ASIGNO AL PARAMETRO EL VALOR QUE ESTE EN LA CAJA DE TEXTO
                    cmd.Parameters.AddWithValue("MATNOT", txtMATNOT.Text);
                    cmd.Parameters.AddWithValue("ASIGNOT", txtASINOT.Text);
                    cmd.Parameters.AddWithValue("TIPNOT", txtTIPNOT.Text);
                    cmd.Parameters.AddWithValue("FECNOT", txtFECNOT.Text);


                    //Ejecuta el comando y trata de llenar el data reader que se crea en la misma línea con los datos del registro

                    SqlDataReader DatosAlumno = cmd.ExecuteReader();

                    if (DatosAlumno.HasRows) //trajo algo? Tiene filas?
                    {
                        //Encontré al alumno cuya matrícula es la ingresada
                        while (DatosAlumno.Read())
                        {
                            txtASINOT.Text = DatosAlumno["MATNOT"].ToString();
                            txtASINOT.Text = DatosAlumno["ASIGNOT"].ToString();
                            txtTIPNOT.Text = DatosAlumno["TIPNOT"].ToString();
                            txtFECNOT.Text = DatosAlumno["FECNOT"].ToString();
                            txtVALNOT.Text = DatosAlumno["VALNOT"].ToString();



                            BlnNuevo = false; // Hace que si modifico el registro y grabo, vaya por el else (upd) en el botón Grabar
                        }
                    }
                    else
                    {
                        //NO se encontró la matrícula ingresada
                        //Message box parámetros: mensaje/titulocaja/Boton/Icono
                        MessageBox.Show("No se encontró la matrícula ingresada", "Búsqueda de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BlnNuevo = true;
                    }

                    DatosAlumno.Close();




                }

            }

        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            //Asigno a mi fuente de dato, la variable que cree
            dgvNota.DataSource = BindingSourceNota;



            BindingSourceNota.DataSource = GetNota("SEL_NOTAS");// metodo datasource soporta
                                                                  // o tolera muchos archivos. xml,matrices,vectores,datatable,datareader,dataset,dataview

            SetNota();
        }

        private void SetNota()
        {
            dgvNota.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvNota.Columns[0].HeaderText = "MATRICULA NOTA";
            dgvNota.Columns[1].HeaderText = "ASIGNTATURA";
            dgvNota.Columns[2].HeaderText = "TIPO EXAMEN";
            dgvNota.Columns[3].HeaderText = "FECHA NOTA";
            dgvNota.Columns[4].HeaderText = "VALOR NOTA";


            //Números y fechas van por defecto a la derecha
            dgvNota.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNota.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvNota.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



        }

        private DataTable GetNota(string SPNombre)
        {

            // Procedimiento pq no devuelve ningun valor
            //SPNombre es el nombre del procedimiento almacenado que llega como parámetro del procedimiento
            DataTable dtNota = new DataTable();


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
                    SqlDataAdapter daNota = new SqlDataAdapter();



                    daNota = new SqlDataAdapter(SPNombre, con);

                    SqlCommandBuilder cbNota = new SqlCommandBuilder(daNota);
                    //
                    daNota.Fill(dtNota);

                    //

                    return dtNota;

                }

                catch (SqlException exc)

                {

                    //sólo se ejecuta si se produjo algún error dentro del bloque try
                    MessageBox.Show("No se pudieron recuperar los datos de nota", exc.Message.ToString());


                }
                finally
                {

                    //Con error o sin error se ejecuta


                }

            }
            return dtNota;
        }

    }
}
