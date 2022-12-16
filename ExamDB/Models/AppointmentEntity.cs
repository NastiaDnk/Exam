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
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly AppointmentTime { get; set; }
        [ForeignKey ("Client")]
        public int ClientID { get; set; }

        public virtual ClientEntity MyClient { get; set; }

    }
}
