using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabSysCloud.Domain.Entities.ValueObjects
{
    public class Contato : EntidadeBase
    {
        public string? Email { get; set; }
        public int DDDResidencial { get; set; }
        public string? TelefoneResidencial { get; set; }
        public int DDDCelular { get; set; }
        public string? Celular { get; set; }
    }
}