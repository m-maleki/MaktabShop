using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Concurrent;

namespace MaktabShop.Presentations.RazorPages.Pages.Products
{
    public class IndexModel (IProductAppService productAppService ) : PageModel
    {
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = productAppService.GetAll();
        }
    }
}
