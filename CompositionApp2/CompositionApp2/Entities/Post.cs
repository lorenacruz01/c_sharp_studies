using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionApp2.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>(); //garante que vai ser instanciada

        //construtor padrão
        public Post()
        {
        }

        //construtor com argumentos
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //métodos
        public void AddComment(Comment comment)
        {
            Comments.Add(comment); //adiciona um novo comentário na lista
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment); //remove um comentário
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }



    }
}
