﻿using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_blog_projesi.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager bm=new BlogManager();

        public PartialViewResult AuthorAbout(int id)
        {
            var authordetail=bm.GetBlogByID(id);
            return PartialView(authordetail);
        }

        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogauthorid = bm.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();

            var authorblogs = bm.GetBlogByAuthor(blogauthorid);
            return PartialView(authorblogs);
        }
    }
}