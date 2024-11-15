using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEventos.Models
{
    public class DadosInformados
    {
        public string NomeEvento { get; set; }
        public Local LocalSelecionado { get; set; }
        public double QntParticipante { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int Duracao
        {
            get => DataTermino.Subtract(DataInicio).Days;
        }
        public double ValorTotal
        {
            get
            {
                double valor_participante = QntParticipante * LocalSelecionado.ValorParticipante;

                double total = valor_participante * Duracao;
                return total;
            }
        }
    }
}
