using ComponentFactory.Krypton.Toolkit;
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