using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Text.Json;

namespace HelloWorldService.Models
{
    public class Addition : IAddition
    {
        public double Wert1 { get; set; }
        public double Wert2 { get; set; }

        public Addition(double wert1, double wert2)
        {
            this.Wert1 = wert1;
            this.Wert2 = wert2;
        }

        public double Ergebnis()
        {
            return this.Wert1 + this.Wert2;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}