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
    internal class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog addblogparameter)
        {
            using var c = new Context();
            c.Add(addblogparameter);
            c.SaveChanges();

        }

        public void DeleteBlog(Blog deleteblogparameter)
        {
            using var c = new Context();
            c.Remove(deleteblogparameter);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog updateblogparameter)
        {
            using var c = new Context();
            c.Add(updateblogparameter);
            c.SaveChanges();
        }
    }
}
