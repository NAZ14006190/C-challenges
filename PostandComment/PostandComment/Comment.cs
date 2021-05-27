using System;
using System.Collections.Generic;
using System.Text;

namespace PostandComment
{
    class Comment
    {
        public User author;
        public string comment;
        public DateTime timeStamp;
        

        public Comment (User Author, string Post)
        {
            this.timeStamp = DateTime.Now;
            this.author = Author;
            this.comment = Post;
           
        }
    }
}
