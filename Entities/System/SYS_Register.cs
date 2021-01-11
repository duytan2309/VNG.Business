using System;

namespace VNG.Business.Entities.System
{
    public class SYS_Register
    {
        public string status { get; set; }
        public string SerialNumber { get; set; }
        public string Key { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
    }
}
