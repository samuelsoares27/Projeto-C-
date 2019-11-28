using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalhoo.Models
{
    [Dapper.Contrib.Extensions.Table("contas")]
    public class Princi
    {
        [Column("id")]
        [Dapper.Contrib.Extensions.Key]
        public long Id { get; set; }
        [Column("valor")]
        public float Valor { get; set; }
        [Column("tipo")]
        public TipoDaConta Tipo { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("vencimento")]
        public DateTime Vencimento { get; set; }
        [Column("lancamento")]
        public DateTime Lancamento { get; set; }
        [Column("efetuada")]
        public bool Efetuada { get; set; }
    }
}
