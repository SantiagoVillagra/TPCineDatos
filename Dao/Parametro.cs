using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_proyecto.Dao
{
    internal class Parametro
    {

        private string nombre;
        private object valor;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public Parametro(string nombre, object valor)
        {
            this.nombre = nombre;
            this.valor = valor;
        }

    }
}
