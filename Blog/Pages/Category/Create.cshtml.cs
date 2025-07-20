using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Blog.Models;

namespace Blog.Pages.Category
{
    public class CreateModel : PageModel
    {

        private readonly AppDBContext _db;
        public CreateModel(AppDBContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Models.Categories Category { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
