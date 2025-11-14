using MaktabShop.Domain.Core.Contracts.AppServices;
using MaktabShop.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MaktabShop.Presentations.RazorPages.Pages.Products
{
    public class DeleteModel(IProductAppService productAppService) : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public void OnGet(int id)
        {
            Product = productAppService.GetById(id);
        }

        public IActionResult OnPost()
        {
            productAppService.Delete(Product.Id);
            return RedirectToPage("Index");
        }


    }
}
