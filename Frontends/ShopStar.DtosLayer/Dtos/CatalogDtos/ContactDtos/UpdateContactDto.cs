﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.DtosLayer.Dtos.CatalogDtos.ContactDtos
{
    public class UpdateContactDto
    {
        public string ContactId { get; set; }
        public string NameSurename { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; }
    }
}
