using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Category addcategoryparameter)
        {
            c.Add(addcategoryparameter);
            c.SaveChanges();
        }

        public void DeleteCategory(Category deletecategoryparameter)
        {
            c.Remove(deletecategoryparameter);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList();
        }

        public void UpdateCategory(Category updatecategoryparameter)
        {
            c.Update(updatecategoryparameter);
            c.SaveChanges();
        }
    }
}
