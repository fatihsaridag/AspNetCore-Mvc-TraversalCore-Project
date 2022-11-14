using Microsoft.AspNetCore.Mvc;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.Services.Abstract;
using TraversalCore.Services.Concrete;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IActionResult Index()
        {
            var comments = _commentService.TGetListCommentWithDestination();
            return View(comments);
        }

        public IActionResult DeleteComment(int id)
        {
            var comment = _commentService.TGetById(id);
            _commentService.TDelete(comment);
            return RedirectToAction("Index");
        }
    }
}
