using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlog_PresentationLayer.ViewComponents.CommentViewComponents
{
    public class _CommentListByBlogComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListByBlogComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            id = 2;
            var values = _commentService.TGetCommentsByBlog(id);
            return View(values);
        }
    }
}
