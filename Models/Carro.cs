public class Carro
{
    public int CarroId { get; set; }

    public required string Nome { get; set; }
    public required string Cor { get; set; }
    public required DateTime AnoFabricacao { get; set; }
    public required string Fabricante { get; set; }
    public required int Quantidade { get; set; }
    public required string Especificacoes { get; set; }
    public required float Preco { get; set; }

}
