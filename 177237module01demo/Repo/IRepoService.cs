using _177237module01demo.Model;

namespace _177237module01demo.Repo
{
    public interface IRepoService
    {
        public List<Product> GetProducts();
        public bool CreateProduct(Product product);
    }
}
