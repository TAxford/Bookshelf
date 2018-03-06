﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int CatergoryID { get; set; }
        public string Name { get; set; }


        //Navagation Property
        public virtual ICollection<Book> Books { get; set; }
    }
}