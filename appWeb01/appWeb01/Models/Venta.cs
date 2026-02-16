using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace appWeb01.Models
{
    public class Venta
    {   
        // Atributos
        public int Boleta { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; } = DateTime.Today;
        public string Nombre { get; set; }
        public string Mueble { get; set; }
        public double Precio { get; set; }

        // Constructor
        public Venta() { }

        // Metodos
        public double Descuento()
        {
            if (Precio>500) 
            {
                return Precio * 0.1;
            }
            return Precio*0.02;

        }

        public double Total()
            { return Precio - Descuento(); }

    }

}