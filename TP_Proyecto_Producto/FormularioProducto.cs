using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TP_Proyecto_Producto
{
    public partial class FormularioProducto : Form
    {
        #region Inicio programa
        Productos ListaProductos { get; set; } = new Productos();
        public FormularioProducto()
        {
            InitializeComponent();
            txtCodModif.Text = "Ingrese código de producto a modificar";
            txtCodModif.Enter += txtCodModif_Enter;
            txtCodModif.Leave += txtCodModif_Leave;
        }

        private void txtCodModif_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodModif.Text))
            {
                txtCodModif.Text = "Ingrese código de producto a modificar";
                txtCodModif.ForeColor = Color.Gray;
            }
        }

        private void txtCodModif_Enter(object sender, EventArgs e)
        {
            if (txtCodModif.Text == "Ingrese código de producto a modificar")
            {
                txtCodModif.Text = "";
                txtCodModif.ForeColor = Color.Black;
            }
        }
        #endregion

        #region Alternativa carga de producto usando un constructor con args.
        //Alternativa usando el constructor con argumentos...

        //private void btCargar_Click(object sender, EventArgs e)
        //{
        //    Producto Newproducto = new Producto((txtCodigo.Text, txtDesc.Text, Convert.ToInt32(txtStock.Text));
        //
        //    ListaProductos.InsertProd(Newproducto);
        //    MessageBox.Show("Producto cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        #endregion 

        #region Botones Datagridview
        private void btBorrarDatos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void btMostrarDatos_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml("Tabla_Productos.");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.ReadOnly = true;
        }

        #endregion

        #region Botones y metodos de la lista
        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto Newproducto = new Producto();
                Newproducto.Agregar(txtCodigo.Text, txtDesc.Text, Convert.ToInt32(txtStock.Text));
                ListaProductos.InsertProd(Newproducto);
                MessageBox.Show("Producto cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(FormatException) 
            {
                MessageBox.Show("Campos vacios o error en formatos. \r\nFormatos validos:\r\n \r\n Codigo: Alfanumerico.\r\n Descripcion: Alfanumerico.\r\n Stock: Numerico", "Campo vacio o error en formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizadorProductoBuscado(Producto aProductobuscado)
        {
            lblDescModif.Text = aProductobuscado.P_Descripcion;
            lblStockModif.Text = aProductobuscado.P_Stock.ToString();
        }

        private void btSelectProd_Click(object sender, EventArgs e)
        {
            // ProductoBuscado = new Producto();
            Producto ProductoBuscado = ListaProductos.BuscarProducto(txtCodModif.Text);
            
            if (ProductoBuscado != null && !string.IsNullOrEmpty(ProductoBuscado.P_Codigo)) 
               {
                ActualizadorProductoBuscado(ProductoBuscado);          
               }
            else
            {
                MessageBox.Show("Producto no encontrado","Error de busqueda",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
        }

        #endregion

        #region Metodos modif producto.

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int CantidadAModif = Convert.ToInt32(txtCantidadAModif.Text);
                Producto ProductoAModif = ListaProductos.BuscarProducto(txtCodModif.Text);

                if(ProductoAModif != null)
                {
                    bool esIngreso = rbIngreso.Checked;
                    Producto ProdModificado = ListaProductos.ModificarProducto(ProductoAModif.P_Codigo, CantidadAModif, esIngreso);

                    if(ProdModificado != null)
                    {
                        MessageBox.Show("Producto modificado", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No puede retirar una cantidad mayor al stock", "Error de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido para la cantidad", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        #endregion

        private void btEliminar_Click(object sender, EventArgs e)
        {

            string Cod = txtCodModif.Text;
                        
            DialogResult Result = MessageBox.Show($"¿Realmente desea eliminar el producto {Cod} ?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(Result == DialogResult.Yes)
            {
                Producto ProductoABorrar = ListaProductos.BuscarProducto(txtCodModif.Text);
                ListaProductos.EliminarProducto(ProductoABorrar.P_Codigo);
                MessageBox.Show("Producto eliminado","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
