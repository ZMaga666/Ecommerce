using Ecommerce.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebUI.ViewComponents
{
    public class UserAuthViewComponent : ViewComponent
    { private readonly HttpContextAccessor _httpContext;
        private readonly UserManager<User> userManager;

        public UserAuthViewComponent(HttpContextAccessor httpContext, UserManager<User> userManager)
        {
            _httpContext = httpContext;
            this.userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = _httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await userManager.FindByIdAsync(userId);

            return View("UserAuth",user);

        }
    }
}
