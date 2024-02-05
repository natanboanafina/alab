// using System.Numerics;
using System.ComponentModel.DataAnnotations.Schema;

public class Plano
{
    public int PlanoId { get; set; }
    public required float Valor { get; set; }
    public required string Periodo { get; set; }
    public int? CarroId { get; set; }

    [ForeignKey("CarroId")]
    public virtual Carro? Carro { get; set; }

}
