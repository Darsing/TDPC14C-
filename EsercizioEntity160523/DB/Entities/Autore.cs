﻿using System.ComponentModel.DataAnnotations;
using System;

namespace EsercizioEntity160523.DB.Entities
{
    public class Autore
    {
        [Key]
        public Guid IDAutore { get; set; }
        public string Nome { get; set; }
    }
}
