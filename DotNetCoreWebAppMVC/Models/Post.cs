using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAppMVC.Models {
    public class Post {

        public int ID { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }

        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }


    }
}
