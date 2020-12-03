﻿using AutoWorkshop.Models.Base;
using System;

namespace AutoWorkshop.Models
{
    public class Document : BaseModel
    {
        public Guid CarId { get; set; }
        public Guid WorkerId { get; set; }
        public virtual Car Car { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
