using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class CategoryLogic
    {
        public static DAL.SetTableEntities2 db = new DAL.SetTableEntities2();
        public static List<DTO.Category> GetAllCategories()
        {
            List<DTO.Category> categoriesDto = new List<DTO.Category>();
            List<DAL.Category> categories = db.Categories.ToList();
            foreach (var item in categories)
            {
                categoriesDto.Add(DTO.Category.ConvertDBToDto(item));
            }
            return categoriesDto;
        }
    }
}
