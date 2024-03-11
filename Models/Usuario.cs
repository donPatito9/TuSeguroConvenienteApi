namespace TuSeguroConvenienteApi.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Telefono {  get; set; }
        public string? TipoSeguro { get; set; }
        public bool IsCliente { get; set; } 
    }
}
