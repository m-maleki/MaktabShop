using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace MaktabShop.Presentations.RazorPages.Pages.Products
{
    public class DeleteModel(IProductAppService productAppService) : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public async Task OnGet(int id,CancellationToken cancellationToken)
        {
            Product = await productAppService.GetById(id, cancellationToken);
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
           await productAppService.Delete(Product.Id, cancellationToken);
            return RedirectToPage("Index");
        }


    }
}
