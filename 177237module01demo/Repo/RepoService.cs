using _177237module01demo.Data;
using _177237module01demo.Model;

namespace _177237module01demo.Repo
{
    public class RepoService : IRepoService
    {
        private readonly ApplicationDbContext _context;

        public RepoService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public bool CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return true;
        }

        public List<Product> GetProducts()
        {
           return _context.Products.ToList();
        }
    }
}
