using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolTinhDiem.Model
{
	public class NguoiChoi
	{
		[DisplayName("Tên")]
		public string Ten { get; set; }
		[DisplayName("Tổng số trận")]
		public int TongSoTran { get => TranThang + TranHoa + TranThua; }
		[DisplayName("Trận thắng")]
		public int TranThang { get; set; } = 0;
		[DisplayName("Trận hòa")]
		public int TranHoa { get; set; } = 0;
		[DisplayName("Trận thua")]
		public int TranThua { get; set; } = 0;
		[DisplayName("Bàn thắng")]
		public int BanThang { get; set; } = 0;
		[DisplayName("Bàn thua")]
		public int BangBai { get; set; } = 0;
		[DisplayName("Hiệu số")]
		public int HieuSo { get => BanThang - BangBai;  }
		[DisplayName("Điểm")]
		public int Diem { get => TranThang * 3 + TranHoa ; }
	}
}
