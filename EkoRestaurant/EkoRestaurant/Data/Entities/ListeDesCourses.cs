using System;
using System.Collections.Generic;
using EkoRestaurant.Data.Abstractions;

namespace EkoRestaurant.Data
{
    public class ListeDesCourses : BaseEntity
    {
        public List<ListeDesCoursesElement> ListeDesCoursesElements { get; set; } = new List<ListeDesCoursesElement>();

        public DateTime? CompletionDateTime { get; set; }
        public DateTime? CreationDateTime { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}