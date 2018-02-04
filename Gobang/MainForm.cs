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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			InitGame();
		}

		/// <summary>
		/// 设置游戏
		/// </summary>
		private void Set()
		{
			this.Size = new System.Drawing.Size(boardSize.Width + 30, boardSize.Height + 59);
			pictureBox1.Size = boardSize;
			this.CenterToScreen();
		}

		/// <summary>
		/// 初始化游戏
		/// </summary>
		private void InitGame()
		{
			Set();
			gameData = new int[RowCount + 1, ColCount + 1];
			InitBoard();
		}

		/// <summary>
		/// 初始化棋盘
		/// </summary>
		private void InitBoard()
		{
			mainImage = new System.Drawing.Bitmap(boardSize.Width, boardSize.Height);
			Graphics graphics = Graphics.FromImage(mainImage);
			graphics.Clear(Color.White);

			Point p00 = new Point(length / 2, length / 2);//左上
			Point p01 = new Point(ColCount * length + length / 2, length / 2);//右上
			Point p10 = new Point(length / 2, RowCount * length + length / 2);//左下
			Point p11 = new Point(ColCount * length + length / 2, RowCount * length + length / 2);//右下

			//画四条边框
			graphics.DrawLine(BorderPen, p00, p01);
			graphics.DrawLine(BorderPen, p00, p10);
			graphics.DrawLine(BorderPen, p11, p01);
			graphics.DrawLine(BorderPen, p11, p10);

			//画水平线
			for (int row = 1; row < RowCount; row++)
			{
				graphics.DrawLine(CommonPen,
					new Point(length / 2, row * length + length / 2),
					new Point(ColCount * length + length / 2, row * length + length / 2));
			}

			//画垂直线
			for (int col = 1; col < ColCount; col++)
			{
				graphics.DrawLine(CommonPen,
					new Point(col * length + length / 2, length / 2),
					new Point(col * length + length / 2, RowCount * length + length / 2));
			}
			pictureBox1.Invalidate();
		}

		/// <summary>
		/// 单元格大小
		/// </summary>
		int length = 32;
		/// <summary>
		/// 边框画笔
		/// </summary>
		Pen BorderPen = new Pen(Color.Black, 4);
		/// <summary>
		/// 一般画笔
		/// </summary>
		Pen CommonPen = new Pen(Color.Black, 2);
		/// <summary>
		/// 棋盘
		/// </summary>
		private Bitmap mainImage = new Bitmap(10, 10);
		private Size boardSize
		{
			get
			{
				return new System.Drawing.Size((ColCount + 1) * length, (RowCount + 1) * length);
			}
		}
		/// <summary>
		/// gameData = new int[RowCount + 1, ColCount + 1];
		/// </summary>
		private int[,] gameData;

		private int _stepWeight = 1;
		/// <summary>
		/// 当前此点的分值，区分黑子(1)和红子(-1)
		/// </summary>
		private int stepWeight
		{
			get
			{
				_stepWeight *= -1;
				return -_stepWeight;
			}
		}

		private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InitBoard();
		}

		private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetForm form = new SetForm(RowCount, ColCount);
			form.ShowDialog();
			if (RowCount == form.RowCount && ColCount == form.ColCount)
				return;
			if (MessageBox.Show("将重新开始游戏，是否继续？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
				  System.Windows.Forms.DialogResult.Yes)
			{
				RowCount = form.RowCount;
				ColCount = form.ColCount;
				InitGame();
			}
		}

		private int _rowCount = 19, _colCount = 19;
		/// <summary>
		/// 水平格子数
		/// </summary>
		private int RowCount
		{
			get
			{
				return _rowCount;
			}
			set
			{
				_rowCount = value;
			}
		}
		/// <summary>
		/// 垂直格子数
		/// </summary>
		private int ColCount
		{
			get
			{
				return _colCount;
			}
			set
			{
				_colCount = value;
			}
		}

		/// <summary>
		/// 棋子类型
		/// </summary>
		private enum PieceType
		{
			/// <summary>
			/// 无棋子
			/// </summary>
			None,
			/// <summary>
			/// 黑色棋子
			/// </summary>
			Black,
			/// <summary>
			/// 红色棋子
			/// </summary>
			Red
		}

		private void 生成ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int length = 32;
			int x = 6;
			Bitmap map = new Bitmap(length, length);
			Graphics g = Graphics.FromImage(map);

			//左上角1
			//g.DrawLine(BorderPen, new Point(length / 2 - 2, length / 2), new Point(length, length / 2));
			//g.DrawLine(BorderPen, new Point(length / 2, length / 2 - 2), new Point(length / 2, length));

			//中上2
			//g.DrawLine(BorderPen, new Point(0, length / 2), new Point(length, length / 2));
			//g.DrawLine(CommonPen, new Point(length / 2, length / 2), new Point(length / 2, length));

			//右上3
			//g.DrawLine(BorderPen, new Point(length / 2+2, length / 2), new Point(0, length / 2));
			//g.DrawLine(BorderPen, new Point(length / 2, length / 2-2), new Point(length / 2, length));

			//中左4
			//g.DrawLine(BorderPen, new Point(length / 2, 0), new Point(length / 2, length));
			//g.DrawLine(CommonPen, new Point(length / 2, length / 2), new Point(length, length / 2));

			//中间5
			//g.DrawLine(CommonPen, new Point(0, length / 2), new Point(length, length / 2));
			//g.DrawLine(CommonPen, new Point(length / 2, 0), new Point(length / 2, length));

			//中右6
			//g.DrawLine(CommonPen, new Point(0, length / 2), new Point(length / 2, length / 2));
			//g.DrawLine(BorderPen, new Point(length / 2, 0), new Point(length / 2, length));

			//左下角7
			//g.DrawLine(BorderPen, new Point(length / 2 - 2, length / 2), new Point(length, length / 2));
			//g.DrawLine(BorderPen, new Point(length / 2, length / 2 + 2), new Point(length / 2, 0));

			//中下8
			//g.DrawLine(CommonPen, new Point(length / 2, length / 2), new Point(length / 2, 0));
			//g.DrawLine(BorderPen, new Point(0, length / 2), new Point(length, length / 2));


			//右下角9
			//g.DrawLine(BorderPen, new Point(length / 2 + 2, length / 2), new Point(0, length / 2));
			//g.DrawLine(BorderPen, new Point(length / 2, length / 2 + 2), new Point(length / 2, 0));

			//红方
			//g.DrawLine(CommonPen, new Point(0, length / 2), new Point(length, length / 2));
			//g.DrawLine(CommonPen, new Point(length / 2, 0), new Point(length / 2, length));
			//g.FillEllipse(Brushes.Red, x, x, length - 2 * x, length - 2 * x);

			//红方
			g.DrawLine(CommonPen, new Point(0, length / 2), new Point(length, length / 2));
			g.DrawLine(CommonPen, new Point(length / 2, 0), new Point(length / 2, length));
			g.FillEllipse(Brushes.Black, x, x, length - 2 * x, length - 2 * x);
			map.Save(@"C:\1.bmp");
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			pictureBox1.Size = boardSize;
			e.Graphics.DrawImage(mainImage, 0, 0, mainImage.Width, mainImage.Height);
		}

		private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
			int col = e.X / length;
			int row = e.Y / length;
			gameData[row, col] = stepWeight;
			Graphics g = Graphics.FromImage(mainImage);
			if (gameData[row, col] == 1)//黑子
			{
				g.FillEllipse(Brushes.Black, col * length + 2, row * length + 2, 26, 26);
			}
			else//红子
			{
				g.FillEllipse(Brushes.Red, col * length + 2, row * length + 2, 26, 26);
			}
			pictureBox1.Invalidate();
			CheckWin();
		}

		void CheckWin()
		{
			
		}
	}
}