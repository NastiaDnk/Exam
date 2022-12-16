using ExamCommon.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCommon.Models
{
    public class Client
    {
        public string ClientName { get; set; }
        public WorkType WorkType { get; set; }
        public string HairdresserName { get; set; }
    }
}
