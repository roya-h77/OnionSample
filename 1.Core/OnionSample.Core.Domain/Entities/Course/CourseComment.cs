﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Core.Domain
{
    public class CourseComment : BaseEntity
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string CommentBy { get; set; }
        public DateTime CommantDate { get; set; }
        public bool IsValid { get; set; }
        public string Comment { get; set; }
    }
}
