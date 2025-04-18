using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDefectDal: EfEntityRepositoryBase<Defect, WashingModuleContext>, IDefectDal    
    {
        private WashingModuleContext _context;
        public EfDefectDal(WashingModuleContext context) : base(context)
        {
            _context = context;
        }

        public List<DefectWithCategoryDto> GetAllWitCategory()
        {
            var result = from d in _context.Defects
                         join dc in _context.DefectCategories
                         on d.DefectCategoryId equals dc.Id
                         orderby d.Id
                         select new DefectWithCategoryDto
                         {
                             DefectCategoryId = d.DefectCategoryId,
                             DefectName = d.DefectName,
                             Description = d.Description,
                             CategoryName = dc.CategoryName,
                             Id = d.Id,
                             CreatedUserId = d.CreatedUserId,
                             CreatedDate = d.CreatedDate,
                             LastUpdatedUserId = d.LastUpdatedUserId,
                             LastUpdatedDate = d.LastUpdatedDate,
                             Status = d.Status,
                             IsDeleted = d.IsDeleted
                         };

            return result.ToList();
        }
    }

}
