﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCommon.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public int ClientID { get; set; }
    }
}
