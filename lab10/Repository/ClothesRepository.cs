using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Repository
{
    class ClothesRepository : Repository.Repository<Cloth>
    {
        Entities context;
        public ClothesRepository()
        {
            context = Entities.GetContext();
        }
        public override void Update(Cloth entity)
        {
            var temp = context.Clothes.FirstOrDefault(t => t.id == entity.id);
            context.Clothes.Remove(temp);
            context.SaveChanges();
            context.Clothes.Add(entity);
            context.SaveChanges();
        }
    }
}
