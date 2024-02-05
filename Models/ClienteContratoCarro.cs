using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ClienteContratoCarro
{
    public int ClienteContratoCarroId { get; set; }

    public required DateTime DataRegistro { get; set; }

    public int? ClienteId { get; set; }

    public int? ContratoId { get; set; }

    [ForeignKey("ClienteId")]
    public virtual Cliente? Cliente { get; set; }

    [ForeignKey("ContratoId")]
    public virtual Contrato? Contrato { get; set; }
}
