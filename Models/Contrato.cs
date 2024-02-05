using System.ComponentModel.DataAnnotations.Schema;

public class Contrato
{
    public int ContratoId { get; set; }
    public required bool Cancelado { get; set; }
    public required string Plano { get; set; }
    public required DateTime DataInicio { get; set; }
    public required DateTime DataFim { get; set; }
    public required float Valor { get; set; }
    public required int QuantidadeCarros { get; set; }
}
