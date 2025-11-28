using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Entities;
using MaktabShop.Domain.Service.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace MaktabShop.Presentations.RazorPages.Pages.Products
{
    public class UpdateModel(IProductAppService productAppService, ICategoryAppService categoryAppService) : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }
        public async Task OnGet(int id, CancellationToken cancellationToken)
        {
            Product = await productAppService.GetById(id, cancellationToken);
            Categories = await categoryAppService.GetCategories(cancellationToken);
        }


        public async Task<IActionResult> OnPost(CancellationToken cancellationToken)
        {
            await productAppService.Update(Product, cancellationToken);
            return RedirectToPage("Index");
        }
    }
}
