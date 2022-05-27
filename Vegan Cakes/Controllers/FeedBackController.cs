using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vegan_Cakes.Models;

namespace Vegan_Cakes.Controllers
{
    [Authorize]
    public class FeedBackController : Controller
    {
        private readonly IFeedBackRepository feedBackRepository;

        public FeedBackController(IFeedBackRepository feedBackRepository)
        {
            this.feedBackRepository = feedBackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedBack feedBack)
        {
            if(ModelState.IsValid)
            {
                feedBackRepository.AddFeedBack(feedBack);
                return RedirectToAction("FeedBackDone");
            }
            else
            {
                return View(feedBack);
            }
           
        }

        public IActionResult FeedBackDone()
        {
            return View();
        }
    }
}
