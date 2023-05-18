﻿using System.ComponentModel.DataAnnotations;

namespace net_il_mio_fotoalbum.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Photo>? Photos { get; set; }
    }
}