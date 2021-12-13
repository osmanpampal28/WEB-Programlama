using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ControlComment
    {
        Repository<Comments> commentRepo = new Repository<Comments>();

        public List<Comments> CommentList()
        {
            return commentRepo.List();
        }

        public List<Comments> CommentByBlog(int id)
        {
            //Blog ID'sine göre yorumları getirir
            return commentRepo.List(x => x.BlogID == id);
        }

        public List<Comments> CommentByStatusTrue()
        {
            return commentRepo.List(x => x.CommentStatus == true);
        }

        public List<Comments> CommentByStatusFalse()
        {
            return commentRepo.List(x => x.CommentStatus == false);
        }

        public int CommentAdd(Comments com)
        {
            if(com.CommentDetail.Length<=4 || com.CommentDetail.Length >= 301 || com.UserN==""
                || com.Email=="" || com.UserN.Length<=1)
            {
                return -1;
            }
            return commentRepo.Insert(com);
        }

        public int CommentStatusChangeToFalse(int id)
        {
            Comments comment = commentRepo.Find(x => x.CommentsID == id);
            comment.CommentStatus = false;
            return commentRepo.Update(comment);
        }

        public int CommentStatusChangeToTrue(int id)
        {
            Comments comment = commentRepo.Find(x => x.CommentsID == id);
            comment.CommentStatus = true;
            return commentRepo.Update(comment);
        }

        
    }
}
