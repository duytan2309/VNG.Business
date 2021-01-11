using System;

namespace VNG.Business.Models.System
{
    public class SYS_Register_ViewModel
    {
        public int option { get; set; }
        public string SerialNumber { get; set; }
        public string Key { get; set; }
        public DateTime? Date { get; set; }
        public string Name { get; set; }
    }
}
