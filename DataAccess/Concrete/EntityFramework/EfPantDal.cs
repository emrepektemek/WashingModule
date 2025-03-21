using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPantDal: EfEntityRepositoryBase<Pant, WashingModuleContext>, IPantDal    
    {

        private WashingModuleContext _context;
        public EfPantDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }

        public List<PantFabricDto> GetAllWithFabric()
        {
            var result = from p in _context.Pants
                         join f in _context.Fabrics
                         on p.FabricId equals f.Id
                         select new PantFabricDto
                         {
                            FabricId = f.Id,
                            FabricMaterials = f.FabricMaterials,
                            ModelName = p.ModelName,
                            Id = p.Id,
                            CreatedUserId = p.CreatedUserId,
                            CreatedDate = p.CreatedDate,
                            LastUpdatedUserId = p.LastUpdatedUserId,
                            LastUpdatedDate = p.LastUpdatedDate,
                            Status = p.Status,
                            IsDeleted = p.IsDeleted

                         };

            return result.ToList(); 
        }
    }
}
