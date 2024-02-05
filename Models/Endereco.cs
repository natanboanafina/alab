using System.ComponentModel.DataAnnotations.Schema;

public class Endereco
{
    public int EnderecoId { get; set; }
    public required string Rua { get; set; }
    public required string Numero { get; set; }
    public required string Bairro { get; set; }
    public required string Complemento { get; set; }
    // Default não é obrigatório. Ele instancia um valor padrão.
    public required string Estado { get; set; } = default!;
    public required string Cidade { get; set; }
    public required string Cep { get; set; }
    public required string UF { get; set; }
    public required string Pais { get; set; }

    public int? ClienteId { get; set; }
    [ForeignKey("ClienteId")]
    public virtual Cliente? Cliente { get; set; }
}
