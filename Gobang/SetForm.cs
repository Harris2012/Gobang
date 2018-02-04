using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gobang
{
	public partial class SetForm : Form
	{
		public SetForm()
		{
			InitializeComponent();
		}

		public SetForm(int rowCount, int colCount)
		{
			InitializeComponent();
			RowCountTextbox.Text = rowCount.ToString();
			ColCountTextbox.Text = colCount.ToString();
			RowCountTextbox.Focus();
			RowCount = rowCount;
			ColCount = colCount;
			SettingChanged = false;
		}

		public int RowCount
		{
			get;
			private set;
		}
		public int ColCount
		{
			get;
			private set;
		}
		public bool SettingChanged
		{
			get;
			private set;
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			int row, col;
			if (int.TryParse(RowCountTextbox.Text, out row) &&
				(int.TryParse(ColCountTextbox.Text, out col)))
			{
				RowCount = row;
				ColCount = col;
				SettingChanged = true;
				this.Close();
			}
			else
			{
				MessageBox.Show("输入错误");
			}
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
