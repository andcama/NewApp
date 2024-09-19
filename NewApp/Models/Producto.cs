namespace NewApp.Models
{
    public class Producto
    {
        public int nIdProduct { get; set; }
        public string? cNombProdu { get; set; }
        public decimal nPrecioProd { get; set; }
        public int nIdCategori { get; set; }
        public Categoria Categoria { get; set; }
    }

}
