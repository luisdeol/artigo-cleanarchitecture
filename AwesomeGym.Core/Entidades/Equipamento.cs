using AwesomeGym.Core.Enums;
using System;

namespace AwesomeGym.Core.Entidades
{
    public class Equipamento
    {
        protected Equipamento() { }
        public Equipamento(string nome, string descricao, DateTime adquiridoEm)
        {
            Nome = nome;
            Descricao = descricao;
            AdquiridoEm = adquiridoEm;
            Status = StatusEquipamentoEnum.EmEstoque;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime AdquiridoEm { get; private set; }
        public StatusEquipamentoEnum Status { get; private set; }
    }
}
