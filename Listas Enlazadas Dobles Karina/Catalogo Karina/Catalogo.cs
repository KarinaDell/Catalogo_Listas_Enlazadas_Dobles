using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Karina
{
    class Catalogo
    {
        private Producto primero = null;

        public void Agregar(Producto nuevo)
        {
            if (primero == null)
                primero = nuevo;
            else
                agregar(nuevo, primero);
        }

        private void agregar(Producto nuevo, Producto t)
        {
            if (t._siguiente != null)
                agregar(nuevo, t._siguiente);
            else
                t._siguiente = nuevo;
        }

        public void AgregarInicio(Producto nuevo)
        {
            nuevo._siguiente = primero;
            primero = nuevo;
        }

        public Producto Buscar(int _codigo)
        {
            if (primero == null)
                return null;
            else if (primero.Codigo == _codigo)
                return primero;
            else
                return buscar(_codigo, primero._siguiente);
        }

        private Producto buscar(int _codigo, Producto t)
        {
            if (t == null)
                return null;
            else if (t.Codigo == _codigo)
                return t;
            else
                return buscar(_codigo, t._siguiente);
        }

        public void Eliminar(int _codigo)
        {
            if (_codigo == primero.Codigo)
                EliminarPrimero();
            else
                eliminar(_codigo, primero);
        }

        private void eliminar(int _codigo, Producto t)
        {
            if (_codigo == t._siguiente.Codigo)
                t._siguiente = t._siguiente._siguiente;
            else
                eliminar(_codigo, t._siguiente);
        }

        public void EliminarPrimero() => primero = primero._siguiente;

        public void EliminarUltimo()
        {
            Producto producto = primero;
            if (primero._siguiente._siguiente == null)
                primero._siguiente = null;
            else
                eliminarUltimo(primero._siguiente);
        }

        private void eliminarUltimo(Producto t)
        {
            if (t._siguiente._siguiente == null)
                t._siguiente = null;
            else
                eliminarUltimo(t._siguiente);
        }

        public void Insertar(Producto nuevo, int posicion)
        {
            int cont = 1;
            Producto producto = primero;
            if (posicion == 1)
            {
                AgregarInicio(nuevo);
            }
            else
            {
                while (cont != posicion - 1)
                {
                    producto = producto._siguiente;
                    cont++;
                }
                nuevo._siguiente = producto._siguiente;
                producto._siguiente = nuevo;
            }
        }

        public string Listar()
        {
            string s = "";
            Producto producto = primero;
            while (producto != null)
            {
                s += producto.ToString() + Environment.NewLine;
                producto = producto._siguiente;
            }
            return s;
        }

        public string ReporteInverso()
        {
            if (primero == null)
                return "";
            else
                return reporteInverso(primero);
        }

        private string reporteInverso(Producto t)
        {
            if (t._siguiente != null)
                return reporteInverso(t._siguiente) + t.ToString() + Environment.NewLine;
            else
                return t.ToString() + Environment.NewLine;
        }

        public void InvertirLista()
        {
            Producto newInicio = getNewInicio();
            Producto producto = newInicio;
            while (primero._siguiente != null)
            {
                while (producto._siguiente != null)
                    producto = producto._siguiente;
                producto._siguiente = getUltimo();
            }
            eliminarInicio(newInicio);
        }

        private Producto getNewInicio()
        {
            Producto producto = primero;
            Producto newInicio = null;
            while (producto._siguiente._siguiente != null)
                producto = producto._siguiente;
            newInicio = producto._siguiente;
            producto._siguiente = null;
            return newInicio;
        }

        private Producto getUltimo()
        {
            Producto producto = primero;
            Producto productoDos = primero;
            while (producto._siguiente._siguiente != null)
                producto = producto._siguiente;
            productoDos = producto._siguiente;
            producto._siguiente = null;
            return productoDos;
        }

        private void eliminarInicio(Producto newInicio)
        {
            Producto producto = newInicio;
            while (producto._siguiente != null)
                producto = producto._siguiente;
            producto._siguiente = primero;
            primero = newInicio;
        }
    }
}
