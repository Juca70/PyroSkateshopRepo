using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBoxUsuario_Enter(object sender, System.EventArgs e)
        {
            if(textBoxUsuario.Text == "Nombre de usuario")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.Black;
            }
        }

        private void textBoxUsuario_Leave(object sender, System.EventArgs e)
        {
            if(textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Nombre de usuario";
                textBoxUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textBoxContrasena_Enter(object sender, System.EventArgs e)
        {
            if (textBoxContrasena.Text == "Contraseña")
            {
                textBoxContrasena.Text = "";
                textBoxContrasena.ForeColor = Color.Black;
                textBoxContrasena.UseSystemPasswordChar = true;
            }
        }

        private void textBoxContrasena_Leave(object sender, System.EventArgs e)
        {
            if (textBoxContrasena.Text == "")
            {
                textBoxContrasena.Text = "Contraseña";
                textBoxContrasena.ForeColor = Color.DimGray;
                textBoxContrasena.UseSystemPasswordChar = false;
            }
        }

        private void pictureBoxCerrarVentana_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimizarVentana_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxCerrarVentana_MouseHover(object sender, System.EventArgs e)
        {
            pictureBoxCerrarVentana.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxCerrarVentana_MouseLeave(object sender, System.EventArgs e)
        {
            pictureBoxCerrarVentana.BackColor = Color.White;
        }

        private void pictureBoxMinimizarVentana_MouseHover(object sender, System.EventArgs e)
        {
            pictureBoxMinimizarVentana.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxMinimizarVentana_MouseLeave(object sender, System.EventArgs e)
        {
            pictureBoxMinimizarVentana.BackColor= Color.White;
        }

        private void labelRecuperarContrasena_MouseHover(object sender, System.EventArgs e)
        {

        }
    }
}
