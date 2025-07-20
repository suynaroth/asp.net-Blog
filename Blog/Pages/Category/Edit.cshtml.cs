using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Blog.Models;

namespace Blog.Pages.Category
{
    public class EditModel : PageModel
    {
        private readonly AppDBContext _db;
        public EditModel(AppDBContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Models.Categories Category { get; set; }
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
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Categories.Update(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }   
    }
}
