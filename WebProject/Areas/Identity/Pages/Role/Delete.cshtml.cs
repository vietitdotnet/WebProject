
using WebProject.DbContextLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace WebProject.Areas.Identity.Pages.Role
{

    public class DeleteModel : RolePageModel
    {
        public DeleteModel(RoleManager<IdentityRole> roleManager, ILogger<RolePageModel> logger, AppDbContext context) : base(roleManager, logger, context)
        {
        }

        [BindProperty]
        public InputModel input { get; set; }

        public class InputModel
        {
            public string id { get; set; }

            public string name { get; set; }
        }

        public async Task<IActionResult> OnGet(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound();

            }

            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return NotFound();
            }

            input = new InputModel()
            {
                id = role.Id,
                name = role.Name
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(input.id))
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(input.id);

            if (role == null)
            {
                return NotFound();
            }

            var result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                StatusMessage = $"X�o vai tr� {role.Name} th�nh c�ng.";
                return RedirectToPage("./index");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(string.Empty, item.Description);
            }

            return Page();
        }
    }
}
