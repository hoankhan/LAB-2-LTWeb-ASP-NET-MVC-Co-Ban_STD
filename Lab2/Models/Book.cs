﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string image_cover;

        public Book(
            int id,
            string title,
            string author,
            string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }
        public int Id
        {
            get
            {
                return id;
            }
            
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }

        public string Image_cover
        {
            get
            {
                return image_cover;
            }
        }
    }
}