using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTinhDiem.Model;

namespace ToolTinhDiem
{
	public partial class Form1 : Form
	{
		private List<NguoiChoi> listNguoiChoi;
		public Form1()
		{
			InitializeComponent();
			listNguoiChoi = new List<NguoiChoi>()
			{
				new NguoiChoi()
				{
					Ten = "Dat"
				},
				new NguoiChoi()
				{
					Ten = "Nam"
				},
				new NguoiChoi()
				{
					Ten = "Duong"
				},
				new NguoiChoi()
				{
					Ten = "Thắng"
				}
			};
			dataGridView1.DataSource = listNguoiChoi;
		}
	}
}
