using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult PartialAddComment(Comment p)
		{
			p.CommentDate = DateTime.Parse(DateTime.Now.ToLongDateString());
			p.CommentStatus = true;
			p.BlogID = 2; 
			cm.CommentAdd(p);
			//Response.Redirect("/Blog/BlogReadAll/" + 1);
			return PartialView();
		}
		public PartialViewResult CommentListByBlog(int id) 
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
	}
}
