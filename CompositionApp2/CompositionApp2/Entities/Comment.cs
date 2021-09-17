using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionApp2.Entities
{
    class Comment
    {
        public string Text { get; set; }

        //construtor padrão
        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }

        //construtor com argumentos

    }
}
