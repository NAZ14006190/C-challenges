using System;

namespace PostandComment
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("RichardK");
            User user2 = new User("MitchelW");
            User user3 = new User("MichaelN");


            // create a post 
            Post post1 = new Post(user1, "Hope everyone has a great day");

            // add comments
            post1.comments.Add(new Comment(user2, "Shut up"));
            post1.comments.Add(new Comment(user3, "Noone cares what you think!"));

            Console.WriteLine($"Author: {post1.author.username}\n Post: {post1.post}\nPosted: {post1.timeStamp}\n");

            foreach (Comment comment in post1.comments)
            {

                Console.WriteLine($"       Post: {comment.comment}\n     Author: {comment.author.username}\n       Posted: {comment.timeStamp}\n");

            }



            // create a post 
            Post post2 = new Post(user1, "You are so mean");

            // add comments
            post2.comments.Add(new Comment(user2, "Random Comment"));
            post2.comments.Add(new Comment(user3, "Not offensive comment"));

            Console.WriteLine($"Author: {post2.author.username}\n Post: {post2.post}\nPosted: {post2.timeStamp}\n");

            foreach (Comment comment in post2.comments)
            {

                Console.WriteLine($"       Post: {comment.comment}\n     Author: {comment.author.username}\n       Posted: {comment.timeStamp}");

            }

            // user class - to assign author role
            // post class - which is going to create the posts
            // comment class - going to be used to update actions on posts

            // methods
            // view posts
            // comments on posts 
            // close or delte 
        }
    }
}
