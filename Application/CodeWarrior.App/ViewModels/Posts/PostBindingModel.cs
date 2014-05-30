﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CodeWarrior.App.ViewModels.Posts
{
    public class PostBindingModel
    {
        public string Id { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime PostedOn { get; set; }

        [Required]
        public string PosteddBy { get; set; }
    }
}