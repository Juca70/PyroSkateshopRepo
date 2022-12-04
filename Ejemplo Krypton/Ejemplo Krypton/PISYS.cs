using ComponentFactory.Krypton.Toolkit;
using Ejemplo_Krypton.Controlador;
using Ejemplo_Krypton.Modelo.Entidad;
using System;

namespace Ejemplo_Krypton
{
    public partial class PISYS : KryptonForm
    {
        public PISYS()
        {
            InitializeComponent();
            
        }

        private void PlantillaDeFormulario_Load(object sender, EventArgs e)
        {
            IniciarSesion form = new IniciarSesion();
            form.ShowDialog();

            if (Utils.Usuario == null && Utils.Usuario.TipoUsuario != "Administrador")
            {
                this.Dispose();
            }
        }

        private void kryptonButtonAgregarArticulo_Click(object sender, EventArgs e)
        {
            kryptonPanelInicio.Visible = false;
            kryptonPanelAgregarArticulo.Visible = true;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            kryptonPanelAgregarArticulo.Visible = false;
            kryptonPanelInicio.Visible = false;
            
        }
    }
}