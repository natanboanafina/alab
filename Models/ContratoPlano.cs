using System.ComponentModel.DataAnnotations.Schema;

public class ContratoPlano
{
    public int ContratoPlanoId { get; set; }

    public required float Valor { get; set; }

    public int? ContratoId { get; set; }

    [ForeignKey("ContratoId")]
    public virtual Contrato? Contrato { get; set; }

}
