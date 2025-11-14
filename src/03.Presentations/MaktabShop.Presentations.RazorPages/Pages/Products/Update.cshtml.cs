using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Entities;
using MaktabShop.Domain.Service.AppServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabShop.Presentations.RazorPages.Pages.Products
{
    public class UpdateModel (IProductAppService  productAppService ,ICategoryAppService categoryAppService) : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }
        public void OnGet(int id)
        {
            Product = productAppService.GetById(id);
            Categories = categoryAppService.GetCategories();
        }


        public IActionResult OnPost()
        {
            productAppService.Update(Product);
            return RedirectToPage("Index");
        }
    }
}
