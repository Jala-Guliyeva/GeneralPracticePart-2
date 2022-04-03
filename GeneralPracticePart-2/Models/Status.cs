using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralPracticePart_2.Models
{
    internal class Status
    {
        public int Id { get;  }
        private static int _id;
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }
       

        public Status(string content,string title)
        {
            _id++;
            Id = _id;
            Content=content;
            Title=title;
            DateTime dateTime = DateTime.Now;
           
        }
        public void GetStatusInfo()
        {
            Console.WriteLine($"Id:{Id} - Title:{Title} - Content:{Content} - Shared{SharedDate} seconds ago  ");
        }

    }
}
