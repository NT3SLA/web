using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using Web_api_Polyanskiy.Models;
using System.Data;

namespace Web_api_Polyanskiy.Controllers
{
    public class CommentsController : ApiController
    {
        FilmContext db = new FilmContext();

        // GET api/comment
        public IEnumerable<Comment> GetComments()
        {
            return db.Comments;
        }

        // GET api/comment/5
        public Comment GetComment(int id)
        {
            Comment comment = db.Comments.Find(id);
            return comment;
        }

        // POST api/comment
        [HttpPost]
        public void AddComment([FromBody]Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
        }

        // PUT api/comment/5
        [HttpPut]
        public void EditComment(int id, [FromBody]Comment comment)
        {
            if (id == comment.Id)
            {
                db.Entry(comment).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/comments/5
        public void DeleteComment(int id)
        {
            Comment comment = db.Comments.Find(id);
            if (comment != null)
            {
                db.Comments.Remove(comment);
                db.SaveChanges();
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}