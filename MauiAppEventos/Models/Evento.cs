using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    internal class Evento
    {
        public string nome { get; set; }
        public string local { get; set; }
        public int numeroDeParticipantes { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public double precoPorParticipante { get; set; }
        public int intervalo
        {
            get
            {
                return (dataFim - dataInicio).Days;
            }
        }
        public double precoFinal
        {
            get
            {
                return numeroDeParticipantes * precoPorParticipante;
            }
        }
    }
}
