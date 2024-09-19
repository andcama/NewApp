namespace NewApp.Models
{
    public class Categoria
    {
        public int nIdCategori { get; set; }
        public string? cNombCateg { get; set; }
        public char cEsActiva { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
