using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using JsonFileIO.Jsons;

namespace MRChecker
{
	public partial class Form1 : Form
	{
		ScrapingManager m_scrapingManager = new ScrapingManager();

		public Form1()
		{
			InitializeComponent();
			JsonManager.Init();
			ListUpdate();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			string url = textUrl.Text;

			if (url == "")
			{
				return;
			}
			JsonManager.AddManga(url);
			var task = m_scrapingManager.UpdateMRInfo(url, true);
			textUrl.Text = "";
			dataGridView.Rows.Add("更新が必要", "最新");
			textBoxNum.Text = (int.Parse(textBoxNum.Text) + 1).ToString();
		}

		private void buttonListUpdate_Click(object sender, EventArgs e)
		{
			ListUpdate();
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			var mangaName = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
			
			if (dgv.Columns[e.ColumnIndex].Name == "UpdateButton")
			{
				JsonManager.UpdateCurrent(mangaName);
				dataGridView.Rows[e.RowIndex].Cells[1].Value = "最新";
			}
			if (dgv.Columns[e.ColumnIndex].Name == "DeleteButton")
			{
				JsonManager.DeleteManga(mangaName);
				dataGridView.Rows.RemoveAt(e.RowIndex);
				textBoxNum.Text = (int.Parse(textBoxNum.Text) - 1).ToString();
			}
		}

		private void ListUpdate()
		{
			var jsonData = JsonManager.GetJsonInfo();
			dataGridView.Rows.Clear();
			foreach (var data in jsonData)
			{
				Task task = m_scrapingManager.UpdateMRInfo(data.Url);

				string isLatest = (data.Latest == data.Current) ? "最新" : "未読あり";

				dataGridView.Rows.Add(data.Name, isLatest);
			}
			//ソート
			dataGridView.Sort(dataGridView.Columns[1],
				System.ComponentModel.ListSortDirection.Descending);

			textBoxNum.Text = jsonData.Count.ToString();
		}

	}
}
