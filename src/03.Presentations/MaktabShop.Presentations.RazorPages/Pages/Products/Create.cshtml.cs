using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabShop.Presentations.RazorPages.Pages.Products
{
    public class CreateModel(IProductAppService productAppService, ICategoryAppService categoryAppService) : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }
        public async Task OnGet(CancellationToken cancellationToken)
        {
            Categories = await categoryAppService.GetCategories(cancellationToken);
        }

        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
           await productAppService.Create(Product, cancellationToken);
            return RedirectToPage("Index");
        }
    }
}
