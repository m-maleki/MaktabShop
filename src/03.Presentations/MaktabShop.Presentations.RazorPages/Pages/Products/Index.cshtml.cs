using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace MaktabShop.Presentations.RazorPages.Pages.Products
{
    public class IndexModel (IProductAppService productAppService ) : PageModel
    {
        public List<Product> Products { get; set; }

        public async Task OnGet(CancellationToken cancellationToken)
        {
            Products = await productAppService.GetAll(cancellationToken);
        }
    }
}
