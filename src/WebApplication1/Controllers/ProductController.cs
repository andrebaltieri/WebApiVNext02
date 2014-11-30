using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        private AppDataContext _db;

        public ProductController()
        {
            _db = new AppDataContext();
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _db.Products.ToList();
        }

        [HttpPost]
        public Product Post([FromBody] Product blog)
        {
            _db.Products.Add(blog);
            _db.SaveChanges();

            return blog;
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}