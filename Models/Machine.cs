using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace siemens.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public int MaxTemperature { get; set; }
        public int MinVoltage { get; set; }
    }
}
