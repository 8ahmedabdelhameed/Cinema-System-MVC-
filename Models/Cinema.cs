﻿using System.ComponentModel.DataAnnotations;

namespace ticket.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string description { get; set; }

    }
}
