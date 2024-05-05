using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Gas_Station.Clases
{
    internal class Bomba
    {
        private int id;
        private bool estaOcupada;
        private double cantidadDispensada;

        public int Id { get => id; set => id = value; }
        public bool EstaOcupada { get => estaOcupada; set => estaOcupada = value; }
        public double CantidadDispensada { get => cantidadDispensada; set => cantidadDispensada = value; }

        public void IniciarAbastecimiento(double cantidad)
        {
            EstaOcupada = true;
            CantidadDispensada = cantidad;
        }

        public void DetenerAbastecimiento()
        {
            EstaOcupada = false;
        }
    }
}
