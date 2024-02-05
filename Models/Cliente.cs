using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

public class Cliente
{
    public int ClienteId { get; set; }

    public required string Nome { get; set; }
    public required string Sobrenome { get; set; }
    public required DateTime DataNascimento { get; set; }
    public required string CPF { get; set; }
    public required string EstadoCivil { get; set; }
    public required float Renda { get; set; }
    public required string Contrato { get; set; }
    public int? ConjugeId { get; set; }

    // [ForeignKey("ConjugeId")]
    // public virtual Cliente? Conjuge { get; set; }
}
