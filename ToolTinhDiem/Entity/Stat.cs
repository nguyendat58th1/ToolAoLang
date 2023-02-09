//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToolTinhDiem.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stat
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
		public int SeasonId { get; set; } 
        public int TongSoTran { get; set; }
		public int TranThang { get; set; } = 0;
		public int TranHoa { get; set; } = 0;
		public int TranThua { get; set; } = 0;
		public int BanThang { get; set; } = 0;
		public int BanBai { get; set; } = 0;
		public int HieuSo { get; set; }

		public int Diem { get; set; }

		public virtual Player Player { get; set; }
        public virtual Season Season { get; set; }

		public void CalculateStat()
		{
			TongSoTran = TranThang + TranHoa + TranThua;
			HieuSo = BanThang - BanBai;
			Diem = TranThang * 3 + TranHoa;
		}
    }
}
