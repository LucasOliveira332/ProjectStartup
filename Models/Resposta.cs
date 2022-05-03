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
    }
}