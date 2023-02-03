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
		private NguoiChoi _player1;
		private NguoiChoi _player2;
		public Form1()
		{
			InitializeComponent();
		}

		private void cbPlayer1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listNguoiChoi = new List<NguoiChoi>()
			{
				new NguoiChoi()
				{
					Ten = "Đạt"
				},
				new NguoiChoi()
				{
					Ten = "Nam"
				},
				new NguoiChoi()
				{
					Ten = "Dương"
				},
				new NguoiChoi()
				{
					Ten = "Thắng"
				}
			};
			dataGridView1.DataSource = listNguoiChoi;

			//cbPlayer1.SelectedItem = listNguoiChoi.Select(x => x.Ten).First();
			//cbPlayer2.SelectedItem = listNguoiChoi.Select(x => x.Ten).Skip(1).Take(1).First();

			cbPlayer1.DataSource = listNguoiChoi.Select(x => x.Ten).Where(x => x != cbPlayer2.SelectedItem?.ToString()).ToList();
			cbPlayer2.DataSource = listNguoiChoi.Select(x => x.Ten).Where(x => x != cbPlayer1.SelectedItem?.ToString()).ToList();
		}
	}
}
