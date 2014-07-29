using ShoppersParadiseMailingServiceApp.DAL;
using ShoppersParadiseMailingServiceApp.Models;
using ShoppersParadiseMailingServiceApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppersParadiseMailingServiceApp.Controllers
{
    public class PostController : Controller
    {
        private PostService _postService = new PostService();
        // GET: /Post/
        public ActionResult Index()
        {
            return View(_postService.GetPosts());
        }

        //
        // GET: /Post/Details/5
        public ActionResult Details(string id)
        {
            return View(_postService.GetPost(id));
        }

        //
        // GET: /Post/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Post());
        }

        //
        // POST: /Post/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                post.Url = Helpers.GenerateSlug(post.Title);
                post.Author = User.Identity.Name;
                post.Date = DateTime.Now;

                _postService.Create(post);

                return RedirectToAction("Index");
            }

            return View();
        }

        //
        // GET: /Post/Edit/5
        public ActionResult Edit(string url)
        {
            return View(_postService.GetPost(url));
        }

        //
        // POST: /Post/Edit/5
        [HttpPost]
        public ActionResult Edit(Post post)
        {
            if (ModelState.IsValid)
            {
                post.Url = Helpers.GenerateSlug(post.Title);

                _postService.Edit(post);

                return RedirectToAction("Index");
            }

            return View();
        }

        //
        // GET: /Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
