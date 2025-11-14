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
        public void OnGet()
        {
            Categories = categoryAppService.GetCategories();
        }

        public IActionResult OnPost()
        {
            productAppService.Create(Product);
            return RedirectToPage("Index");
        }
    }
}
