using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Examen_PrimerParcial

{
    class Empleado : INotifyPropertyChanged 
    {
        private string id;
        private string nombre;
        private int horasTrabajadas;
        private double pagoxHora;
        private int horasExtras;
        private double pagoxHoraExtra;

        private double sueldoSinDeduccion;
        private double sueldoxExtra;
        private double deducciones;
        private double sueldoTotal;

        public double SueldoSinDeduccion ()
        {

        }

















        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

    }
}
