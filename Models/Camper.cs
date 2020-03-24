using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarTwentyFour.Models
{
    public class Camper
    {
        public Guid ID { get; set; }
        public string LastName { get; set; }
        public string FirstNickName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}