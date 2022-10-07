using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Folhas.Models
{
    public class FolhaPagamento
    {
        public int FolhaPagamentoId { get; set; }

        public double ValorHora {get; set;}

        public double QuantidadeHoras {get; set;}

/*
        public double SalarioBruto {get; set;}

        public double ImpostoRenda{get; set;}

        public double ImpostoInnss {get; set;}

        public double ImpostoFgts {get; set;}

        public double SalarioLiquido {get; set;}

        public DateTime CriadoEm {get; set;}

*/
        [ForeignKey("Funcionario")]
        [Column("Funcionario")]
        public int Funcionario_Id {get; set;}
        public virtual Funcionario Funcionario {get; set;}

    }
}