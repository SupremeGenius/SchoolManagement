﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.DTO
{
    public class CheckinData
    {
        private string _serialId;
        private string _tick;
        
        public string SERIAL_ID { get => _serialId; set => _serialId = value; }
        public string TIMECHECK { get => _tick; set => _tick = value; }
    }
}
