using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Blog.Models;

namespace Blog.Pages.Category
{
    public class DeleteModel : PageModel
    {
        private readonly AppDBContext _db;
        public DeleteModel(AppDBContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Categories Category { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Category = await _db.Categories.FindAsync(id);
            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (Category == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
