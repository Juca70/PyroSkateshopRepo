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

            /*Articulo a = new Articulo();
            a.Id = 22;

            Categoria c = new Categoria();
            c.Id = 3;

            a.Categoria = c;
            a.Descripcion = "Patineta Bien Padre";
            a.Marca = "La mejor";
            a.Medida = "XXX";
            a.CantExistencia = 100;
            a.CostoCompra = 500;
            a.CostoDolares = 20;
            a.PrecioVenta = 750;
            a.Estado = "Activo";

            manager.ArticuloTable.Modifificar(a);*/
            
            List<Articulo> lista = manager.ArticuloTable.ObtenerPorTipo("Hardgoods");


            foreach (Articulo a in lista)
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = a.Id;
                dataGridView1.Rows[row].Cells[1].Value = a.Categoria.Descripcion;
                dataGridView1.Rows[row].Cells[2].Value = a.Categoria.Tipo;
                dataGridView1.Rows[row].Cells[3].Value = a.Descripcion;
                dataGridView1.Rows[row].Cells[4].Value = a.Marca;
                dataGridView1.Rows[row].Cells[5].Value = a.Medida;
                dataGridView1.Rows[row].Cells[6].Value = a.CantExistencia;
                dataGridView1.Rows[row].Cells[7].Value = a.CostoCompra;
                dataGridView1.Rows[row].Cells[8].Value = a.CostoDolares;
                dataGridView1.Rows[row].Cells[9].Value = a.PrecioVenta;
                dataGridView1.Rows[row].Cells[10].Value = a.Estado;
            }
        }
    }
}
