using ComponentFactory.Krypton.Toolkit;
using Ejemplo_Krypton.Controlador;
using Ejemplo_Krypton.Modelo.Entidad;
using Ejemplo_Krypton.Modelo.Table;
using System;
using System.Windows.Forms;

namespace Ejemplo_Krypton
{
    public partial class IniciarSesion : KryptonForm
    {
        TableManager manager;

        public IniciarSesion()
        {
            InitializeComponent();
            manager = new TableManager();
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }

        private void kryptonSeparator2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void labelo_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            PISYS form = new PISYS();
            form.ShowDialog();*/

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username.Length>0 && password.Length>0)
            {
                Utils.Usuario = manager.UsuarioTable.Obtener(username, password);

                if (Utils.Usuario != null)
                {
                    MessageBox.Show("Bienvenido al sistema", "Mensaje");
                    this.Dispose();
                }
                else
                {
                    labelIncorrecto.Text = "Contraseña o nombre de usuario incorrectos";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Los dos campos deben de estar llenos", "Error");
            }

        }
    }
}
