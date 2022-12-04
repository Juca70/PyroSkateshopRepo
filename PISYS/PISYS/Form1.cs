using PISYS.modelo;
using PISYS.modelo.Entidades;
using PISYS.modelo.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TableManager manager = new TableManager();

            /*List<Articulo> lista = manager.ArticuloTable.ObtenerTodos();

            foreach (Articulo articulo in lista)
            {
                int row = kryptonDataGridView1.Rows.Add();

                kryptonDataGridView1.Rows[row].Cells[0].Value = articulo.Id;
                kryptonDataGridView1.Rows[row].Cells[1].Value = articulo.Categoria.Descripcion;
                kryptonDataGridView1.Rows[row].Cells[2].Value = articulo.Categoria.Tipo;
                kryptonDataGridView1.Rows[row].Cells[3].Value = articulo.Descripcion;
                kryptonDataGridView1.Rows[row].Cells[4].Value = articulo.Marca;
                kryptonDataGridView1.Rows[row].Cells[5].Value = articulo.Medida;
                kryptonDataGridView1.Rows[row].Cells[6].Value = articulo.CantExistencia;
                kryptonDataGridView1.Rows[row].Cells[7].Value = articulo.CostoCompra;
                kryptonDataGridView1.Rows[row].Cells[8].Value = articulo.CostoDolares;
                kryptonDataGridView1.Rows[row].Cells[9].Value = articulo.PrecioVenta;
                kryptonDataGridView1.Rows[row].Cells[10].Value = articulo.Estado;
            }*/

            Usuario usuario = manager.UsuarioTable.Obtener("Admin", "12345");

            
            
            MessageBox.Show("Usuario: " + usuario.Nombre + " "+ usuario.Contraseña);
            
        }
    }
}
