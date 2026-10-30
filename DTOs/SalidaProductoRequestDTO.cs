namespace ProgramacionWebTrabajoPracticoN3.DTOs
{
    public class SalidaProductoRequestDTO
    {
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public string? EmailManual { get; set; } // Propiedad agregada
        public List<DetalleMovimientoRequestDTO> Detalles { get; set; } = new();
    }
}