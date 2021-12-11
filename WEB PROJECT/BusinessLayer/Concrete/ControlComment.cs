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

        public int CommentAdd(Comments com)
        {
            if(com.CommentDetail.Length<=4 || com.CommentDetail.Length >= 301 || com.UserN==""
                || com.Email=="" || com.UserN.Length<=1)
            {
                return -1;
            }
            return commentRepo.Insert(com);
        }
    }
}
