
using ExamDB.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB.Models
{
    public class ClientEntity
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public WorkType WorkType { get; set; }
        public string HairdresserName { get; set; }
    }
}
