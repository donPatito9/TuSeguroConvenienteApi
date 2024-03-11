namespace TuSeguroConvenienteApi.Models
{
    public class Seguro
    {
        public Seguro()
        {
            IsDeleted = false;
        }

        public Guid Id { get; set; }

        public string? Categoria { get; set; }

        public string? TipoDePago { get; set; }

        public string? Descripcion { get; set; }

        //public DateOnly Fecha { get; set; }

        public bool IsNewUsed { get; set; }

        public List<Usuario> Usuarios { get; set; } = new();

        public bool IsDeleted { get; set; }

        public void Update(string categoria, string tipodepago, string descripcion, bool isnewused)
        {

            Categoria = categoria;
            TipoDePago = tipodepago;
            Descripcion = descripcion;
            //Fecha = fecha; 
            IsNewUsed = isnewused;
            
        }

        public void Delete()
        {

            IsDeleted = true;
        }
    }
}
