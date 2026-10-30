namespace ProgramacionWebTrabajoPracticoN3.DTOs
{
    public class IngresoProductoRequestDTO
    {
        public int ProveedorId { get; set; }
        public int UsuarioId { get; set; }
        public List<DetalleMovimientoRequestDTO> Detalles { get; set; } = new();
    }
}