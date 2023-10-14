
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace db
{




    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection
           
        SqlCommand comando = new SqlCommand();

        public Form1()
        {
            InitializeComponent();

            conexion.ConnectionString = @"Data Source=.;Initial Catalog=programacion;Integrated Security=True;TrustServerCertificate=true";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try

            {
                comando.Connection = conexion;
                comando.CommandText = "insert into alumno(id,nombre) values(@txtId,@txtNombre)";
                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@txtId", txtId.Text);
                comando.Parameters.AddWithValue("@txtNombre", txtNombre.Text);

                int NFilas = comando.ExecuteNonQuery();
                if (NFilas > 0)
                {

                    MessageBox.Show("Lo logramos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("CREEME, HICISTE UN DISPARATE:" + ex);
            }



            finally


            {

                conexion.Close();
                txtNombre.Text = " ";
                txtId.Text = " ";

            }



            //conexion.Close();
            //conexion.Dispose();

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}