namespace Gobang
{
	partial class SetForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.RowCountTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ColCountTextbox = new System.Windows.Forms.TextBox();
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "行数";
			// 
			// RowCountTextbox
			// 
			this.RowCountTextbox.Location = new System.Drawing.Point(86, 6);
			this.RowCountTextbox.Name = "RowCountTextbox";
			this.RowCountTextbox.Size = new System.Drawing.Size(100, 21);
			this.RowCountTextbox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "列数";
			// 
			// ColCountTextbox
			// 
			this.ColCountTextbox.Location = new System.Drawing.Point(86, 47);
			this.ColCountTextbox.Name = "ColCountTextbox";
			this.ColCountTextbox.Size = new System.Drawing.Size(100, 21);
			this.ColCountTextbox.TabIndex = 2;
			// 
			// btOK
			// 
			this.btOK.AutoSize = true;
			this.btOK.Location = new System.Drawing.Point(59, 86);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(39, 23);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "确定";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btCancel
			// 
			this.btCancel.AutoSize = true;
			this.btCancel.Location = new System.Drawing.Point(134, 86);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(39, 23);
			this.btCancel.TabIndex = 4;
			this.btCancel.Text = "取消";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// SetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(238, 121);
			this.ControlBox = false;
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.ColCountTextbox);
			this.Controls.Add(this.RowCountTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "SetForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "设置";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox RowCountTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ColCountTextbox;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCancel;
	}
}