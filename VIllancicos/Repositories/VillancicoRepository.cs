using Villancicos.Models;

namespace VIllancicos.Repositories
{
    public class VillancicoRepository
    {
        // Todo repositorio tiene que tener 5 metodos, pero se pueden crear mas, los 5 mas basicos son 
        // Insert,Get, GetById, Update ,Delete
        //  C         R            U       D

        villancicosContext context;
        public VillancicoRepository(villancicosContext cx)
        {
            context = cx;
        }

        public void Insert(Villancico villancico) //agrega
        {
            context.Add(villancico);
            context.SaveChanges();
        }
        public IEnumerable<Villancico> Get()
        {
            return context.Villancico.OrderBy(x => x.Nombre);
        }
        public Villancico? Get(int id) // se buscan por Id
        {
            return context.Villancico.Find(id);
        }
        public Villancico? Get(string nombre) // va a buscarlos por nombre
        {
            return context.Villancico.FirstOrDefault(x=>x.Nombre==nombre);
        }
        public void Update(Villancico villancico) // actualiza
        {
            context.Update(villancico);
            context.SaveChanges();
        }
        public void Delete(Villancico villancico) //elimina
        {
            context.Remove(villancico);
            context.SaveChanges();
        }
    }
}
