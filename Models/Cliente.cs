namespace TuSeguroConvenienteApi.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string? NombreUser { get; set; }  
        public string? ApellidoUser { get; set; }
        public int TelefonoUser {  get; set; }
        public string? TipoSeguroUser {  get; set; }
    }
}
