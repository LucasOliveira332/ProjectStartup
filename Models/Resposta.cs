namespace Adicionando.Models
{
    public class Igredientes
    {
        public int Id {get; set; }
        public string Nome { get; set; }

        public string Price { get; set; }

        private static List<Igredientes> listagem = new List<Igredientes>();

        public static IQueryable<Igredientes> Listagem
        {
            get{
                return listagem.AsQueryable();
            }
        }

        static Igredientes(){
            Igredientes.listagem.Add(
                new Igredientes {Id = 1, Nome = "Alface", Price = "R$100"}
            );
            Igredientes.listagem.Add(
                new Igredientes {Id = 2, Nome = "Tomate", Price = "R$200"}
            );
        }

        public static void Salvar(Igredientes igrediente)
        {
            var igredienteExistente = Igredientes.listagem.Find(u => u.Id == igrediente.Id);
            if (igredienteExistente != null)
            {
                igredienteExistente.Nome = igrediente.Nome;
                igredienteExistente.Price = igrediente.Price;
            }
            else
            {
                var maiorId = Igredientes.Listagem.Max(u => u.Id);
                igrediente.Id = maiorId + 1;
                Igredientes.listagem.Add(igrediente);
            }
            
        }
    }
}