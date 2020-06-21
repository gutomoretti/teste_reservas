using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Estapar.Reservas.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        [Display(Name = "Manobrista")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
        [Display(Name = "Data Entrada")]
        public DateTime? DataInicio { get; set; }
        [Display(Name = "Data Saída")]
        public DateTime? DataFim { get; set; }
        [Display(Name = "Finalizada")]
        public bool Inativo { get; set; }
    }
}
