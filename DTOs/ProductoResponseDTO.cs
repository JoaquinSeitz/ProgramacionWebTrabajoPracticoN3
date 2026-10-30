namespace ProgramacionWebTrabajoPracticoN3.DTOs
{
    public class ProductoResponseDTO
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}