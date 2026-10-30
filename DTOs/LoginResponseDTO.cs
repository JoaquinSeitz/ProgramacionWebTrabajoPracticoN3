using System.Text.Json.Serialization;

namespace ProgramacionWebTrabajoPracticoN3.DTOs
{
    public class LoginResponseDTO
    {
        // Usamos JsonPropertyName por si tu backend serializa todo en minúsculas
        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        [JsonPropertyName("usuarioId")]
        public int UsuarioId { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [JsonPropertyName("rol")]
        public string Rol { get; set; } = string.Empty;
    }
}