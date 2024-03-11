using TuSeguroConvenienteApi.Models;

namespace TuSeguroConvenienteApi.Persistence
{
    public class DbContext
    {
        public List<Seguro> Seguros { get; set; }

        //public List<Cliente> Clientes { get; set; }
       //public List<Usuario> Usuarios { get; set; }

        public DbContext()
        {
            Seguros = new List<Seguro>();
            //Usuarios = new List<Usuario>();
            //Clientes = new List<Cliente>();

        }
    }
}
