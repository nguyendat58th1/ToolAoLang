using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.Json;
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

			cbPlayer1.DataSource = listNguoiChoi.Select(x => x.Ten).ToList();
			cbPlayer2.DataSource = listNguoiChoi.Select(x => x.Ten).ToList();
			cbPlayer2.SelectedItem = listNguoiChoi.Select(x => x.Ten).Skip(1).Take(1).First();
		}

		private void btnUpdateScore_Click(object sender, EventArgs e)
		{
			int score1;
			int score2;
			if (cbPlayer1.SelectedItem == cbPlayer2.SelectedItem)
			{
				MessageBox.Show("Tên 2 thằng giống nhau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (string.IsNullOrWhiteSpace(txtScore1.ToString()) 
					|| string.IsNullOrWhiteSpace(txtScore2.ToString()))
			{
				MessageBox.Show("Tỉ số không được rỗng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (!int.TryParse(txtScore1.Text, out  score1) 
					|| !int.TryParse(txtScore2.Text, out score2))
			{
				MessageBox.Show("Tỉ số không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (score1 > score2)
			{
				var leftPlayer = listNguoiChoi.FirstOrDefault(x => x.Ten == cbPlayer1.SelectedItem.ToString());
				if (leftPlayer == null)
				{
					MessageBox.Show("Không tìm thấy người chơi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				var rightPlayer = listNguoiChoi.FirstOrDefault(x => x.Ten == cbPlayer2.SelectedItem.ToString());
				if (rightPlayer == null)
				{
					MessageBox.Show("Không tìm thấy người chơi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				leftPlayer.TranThang += 1;
				leftPlayer.BanThang += score1;
				leftPlayer.BangBai += score2;
				
				rightPlayer.TranThua += 1;
				rightPlayer.BanThang += score2;
				rightPlayer.BangBai += score1;

			}
			if (score1 == score2)
			{
				var leftPlayer = listNguoiChoi.FirstOrDefault(x => x.Ten == cbPlayer1.SelectedItem.ToString());
				if (leftPlayer == null)
				{
					MessageBox.Show("Không tìm thấy người chơi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				var rightPlayer = listNguoiChoi.FirstOrDefault(x => x.Ten == cbPlayer2.SelectedItem.ToString());
				if (rightPlayer == null)
				{
					MessageBox.Show("Không tìm thấy người chơi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				leftPlayer.TranHoa += 1;
				leftPlayer.BanThang += score1;
				leftPlayer.BangBai += score2;

				rightPlayer.TranHoa += 1;
				rightPlayer.BanThang += score2;
				rightPlayer.BangBai += score1;

			}
			if (score1 < score2)
			{
				var leftPlayer = listNguoiChoi.FirstOrDefault(x => x.Ten == cbPlayer1.SelectedItem.ToString());
				if (leftPlayer == null)
				{
					MessageBox.Show("Không tìm thấy người chơi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				var rightPlayer = listNguoiChoi.FirstOrDefault(x => x.Ten == cbPlayer2.SelectedItem.ToString());
				if (rightPlayer == null)
				{
					MessageBox.Show("Không tìm thấy người chơi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				leftPlayer.TranThua += 1;
				leftPlayer.BanThang += score1;
				leftPlayer.BangBai += score2;

				rightPlayer.TranThang += 1;
				rightPlayer.BanThang += score2;
				rightPlayer.BangBai += score1;
			}

			var sortList = listNguoiChoi
				.OrderByDescending(x => x.Diem)
				.ThenByDescending(x => x.HieuSo)
				.ToList();

			dataGridView1.DataSource = sortList;
			//dataGridView1.Refresh();
			txtScore1.Text = string.Empty;
			txtScore2.Text = string.Empty;

			var sJSONResponse = JsonConvert.SerializeObject(sortList);
			var saveFolderBackUpPath = GetSaveFolderBackUpPath();
			if (!Directory.Exists(saveFolderBackUpPath))
			{
				Directory.CreateDirectory(saveFolderBackUpPath);
			}
			var savePath = Path.Combine(saveFolderBackUpPath, $"{DateTime.Now.Ticks}.txt");
			File.WriteAllText(savePath, sJSONResponse);
		}

		private void cbPlayer1_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtScore1.Text = string.Empty;
			txtScore2.Text = string.Empty;
		}

		private void cbPlayer2_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtScore1.Text = string.Empty;
			txtScore2.Text = string.Empty;
		}

		private void btnImportData_Click(object sender, EventArgs e)
		{
			var openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "Text Document|*.txt";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				var jsonStringNguoiChoi = File.ReadAllText(openFileDialog1.FileName);
				try
				{
					var playersFormFile = System.Text.Json.JsonSerializer.Deserialize<List<NguoiChoi>>(jsonStringNguoiChoi);
					dataGridView1.DataSource = playersFormFile;
				}
				catch
				{
					MessageBox.Show("Import thất bại check lại file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private string GetSaveFolderBackUpPath()
		{
			return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "History");
		}

		private void btnDeleteAllFile_Click(object sender, EventArgs e)
		{
			try
			{
				var files = Directory.GetFiles(GetSaveFolderBackUpPath());
				foreach (string file in files)
				{
					File.Delete(file);
				};
				MessageBox.Show("Đã xóa tất cả file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}
	}
}
