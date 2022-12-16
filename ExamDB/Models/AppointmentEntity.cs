using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB.Models
{
    public class AppointmentEntity
    {
        public int Id { get; set; }
        [NotMapped]
        public DateOnly AppointmentDate { get; set; }
        [NotMapped]
        public TimeOnly AppointmentTime { get; set; }
        [ForeignKey ("Client")]
        public int ClientID { get; set; }


    }
}
