using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace Ejemplo_Krypton
{
    public partial class IniciarSesion : KryptonForm
    {
        public IniciarSesion()
        {
            InitializeComponent();
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
            this.Hide();
            PISYS form = new PISYS();
            form.ShowDialog();
        }
    }
}
