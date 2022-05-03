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
                new Igredientes {Id = 1, Nome = "Alface", Price = "R$ 0.40"}
            );
            Igredientes.listagem.Add(
                new Igredientes {Id = 2, Nome = "Bacon", Price = "R$ 2.00"}
            );
            Igredientes.listagem.Add(
                new Igredientes {Id = 3, Nome = "Hambúrguer de carne", Price = "R$ 3.00"}
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
                int maiorId = Igredientes.Listagem.Max(u => u.Id);
                igrediente.Id = maiorId + 1;
                Igredientes.listagem.Add(igrediente);
            }
            
            
        }

        public static void excluir(Igredientes igrediente)
        {
            var igredienteExistente = Igredientes.listagem.Find(u => u.Id == igrediente.Id);
            if (igredienteExistente != null)
            {
                Igredientes.listagem.Remove(igredienteExistente);
            }
            
        }
    }
}