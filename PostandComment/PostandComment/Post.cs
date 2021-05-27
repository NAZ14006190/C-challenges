using System;
using System.Collections.Generic;
using System.Text;

namespace PostandComment
{
    class Post
    {
        public User author;
        public string post;
        public DateTime timeStamp;
        public List<Comment> comments;

        // set active status
        public bool isOpen;

        public Post(User Author, string Comment)
        {
            this.timeStamp = DateTime.Now;
            this.author = Author;
            this.post = Comment;
            this.isOpen = true;
            comments = new List<Comment>();
        }

        // insert methods
    }
}
