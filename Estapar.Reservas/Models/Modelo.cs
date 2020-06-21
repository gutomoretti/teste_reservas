using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estapar.Reservas.Models
{
    public class Modelo
    {
        public int Id { get; set; }
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public string Descricao { get; set; }
        [Display(Name = "Status")]
        public bool Inativo { get; set; }
    }
}
