using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_peças.Modelos
{
    public class Peca
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime DataUltimaModificacao { get; set; }
        public List<PropriedadeDinamica> PropriedadesDinamicas { get; set; } = new();

        public Peca(string nome, string tipo, DateTime dataUltimaModificacao, List<PropriedadeDinamica> propriedadesDinamicas)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Tipo = tipo;
            DataUltimaModificacao = dataUltimaModificacao;
            PropriedadesDinamicas = propriedadesDinamicas;
        }
    }
}
