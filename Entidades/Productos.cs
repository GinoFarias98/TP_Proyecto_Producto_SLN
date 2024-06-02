using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Entidades
{
    public class Productos
    {

        private DataTable ProductosLista = new DataTable();

        public DataTable P_ProductosLista
        {
            set { ProductosLista = value; }
            get { return ProductosLista; }
        }

        public Productos()
        {
                P_ProductosLista.TableName = "Tabla_Productos";
                P_ProductosLista.Columns.Add("Codigo");
                P_ProductosLista.Columns.Add("Descripcion");
                P_ProductosLista.Columns.Add("Stock");
                Validador();          
        }


        private void Validador()
        {
            if(System.IO.File.Exists("Tabla_Productos")) 
            {
                P_ProductosLista.ReadXml("Tabla_Productos");
            }
        }

        public void InsertProd(Producto aProducto)
        {         
            P_ProductosLista.Rows.Add();
            int NuevoRenglon = P_ProductosLista.Rows.Count - 1;           
            P_ProductosLista.Rows[NuevoRenglon]["Codigo"] = aProducto.P_Codigo;
            P_ProductosLista.Rows[NuevoRenglon]["Descripcion"] = aProducto.P_Descripcion;
            P_ProductosLista.Rows[NuevoRenglon]["Stock"] = aProducto.P_Stock;

            P_ProductosLista.WriteXml("Tabla_Productos");
        }

        public Producto BuscarProducto(string CodProd)
        {
            string bCodigo = CodProd;
            Producto ProductoSegunCodigo = new Producto();

            foreach (DataRow fila in P_ProductosLista.Rows) 
            {
                if (fila["Codigo"].ToString().Equals(bCodigo))
                {
                    ProductoSegunCodigo.P_Codigo = (fila["Codigo"].ToString());
                    ProductoSegunCodigo.P_Descripcion = (fila["Descripcion"].ToString());
                    ProductoSegunCodigo.P_Stock = (Convert.ToInt32(fila["Stock"]));
                    break;
                }
            }
            return ProductoSegunCodigo;
        }

        public Producto ModificarProducto(string CodProd, int aStockModif, bool aIngresar)
        {
           
            

            foreach(DataRow fila in P_ProductosLista.Rows)
            {
                if (fila["Codigo"].ToString().Equals(CodProd))
                {

                    Producto ProductoSegunCodigo = new Producto();
                    { 

                     ProductoSegunCodigo.P_Codigo = (fila["Codigo"].ToString());
                     ProductoSegunCodigo.P_Descripcion = (fila["Descripcion"].ToString());
                     ProductoSegunCodigo.P_Stock = (Convert.ToInt32(fila["Stock"]));
                    };

                    if (aIngresar)
                    {
                        ProductoSegunCodigo.Ingresar(aStockModif);
                    }
                    else
                    {
                        if (!ProductoSegunCodigo.Retirar(aStockModif))
                        {
                            return null; // Retiro no exitoso
                        }
                    }
                    fila["Stock"] = ProductoSegunCodigo.P_Stock;
                    P_ProductosLista.WriteXml("Tabla_Productos");
                    return ProductoSegunCodigo;
                }
            }            
            return null;
        }

        public void EliminarProducto(string CodProd)
        {

            foreach(DataRow fila in P_ProductosLista.Rows)
            {
                if (fila["Codigo"].ToString().Equals(CodProd))
                {
                    P_ProductosLista.Rows.Remove(fila);
                    break;
                }
            }
            P_ProductosLista.WriteXml("Tabla_Productos");
        }
    }
}
