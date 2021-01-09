using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNG.Business.Entities.DTA
{
    public class DM_LenhThuHoi
    {
        public string status { get; set; }
        public int ID { get; set; }
        public int? UuTien { get; set; }
        public string NoiDung { get; set; }
        public bool? SuDung { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiThayDoi { get; set; }
        public DateTime? NgayThayDoi { get; set; }
    }
}
