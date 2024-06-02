using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private string Codigo;
        private string Descripcion;
        private int Stock;
        #endregion

        #region Propiedades

        public string P_Codigo
        {           
            set { Codigo = value; }
            get { return Codigo; }
        }

        public string P_Descripcion
        {
            set { Descripcion = value; }
            get { return Descripcion; }
        }

        public int P_Stock
        {
            set { Stock = value; }
            get { return Stock; }
        }

        #endregion

        #region Constructores
        public Producto()
        {

        }
        
        public Producto(string Cod, string Desc)
        {
            Codigo = Cod;
            Descripcion = Desc;
            Stock = 0;
        }
        #endregion

        #region Metodos
        public void Ingresar(int Cant)
        {
            P_Stock += Cant;
        }

        public bool Retirar(int Cant)
        {
            if(Cant > P_Stock)
            {
                return false;
            }

            P_Stock -= Cant;
            return true;
        }

        public void Agregar(string aCodigo, string aDesc, int aStock)
        {
            P_Codigo = aCodigo;
            P_Descripcion = aDesc;
            P_Stock = aStock;
        }
        #endregion

    }
}
