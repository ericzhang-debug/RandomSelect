/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2022/1/9
 * 时间: 13:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace RandomSelect
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 关于本程序ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 设置间隔时间ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.设置间隔时间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.关于本程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(111, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "抽取(开始/停止)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 237);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(361, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("黑体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(92, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 58);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(132, 198);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(93, 27);
			this.button2.TabIndex = 3;
			this.button2.Text = "随机数抽取";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.文件ToolStripMenuItem,
			this.关于ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(361, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 文件ToolStripMenuItem
			// 
			this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.设置间隔时间ToolStripMenuItem,
			this.退出ToolStripMenuItem});
			this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
			this.文件ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.文件ToolStripMenuItem.Text = "文件";
			// 
			// 设置间隔时间ToolStripMenuItem
			// 
			this.设置间隔时间ToolStripMenuItem.Name = "设置间隔时间ToolStripMenuItem";
			this.设置间隔时间ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.设置间隔时间ToolStripMenuItem.Text = "设置间隔时间";
			this.设置间隔时间ToolStripMenuItem.Click += new System.EventHandler(this.设置间隔时间ToolStripMenuItemClick);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItemClick);
			// 
			// 关于ToolStripMenuItem
			// 
			this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.关于本程序ToolStripMenuItem});
			this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
			this.关于ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.关于ToolStripMenuItem.Text = "关于";
			// 
			// 关于本程序ToolStripMenuItem
			// 
			this.关于本程序ToolStripMenuItem.Name = "关于本程序ToolStripMenuItem";
			this.关于本程序ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.关于本程序ToolStripMenuItem.Text = "关于本程序";
			this.关于本程序ToolStripMenuItem.Click += new System.EventHandler(this.关于本程序ToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 259);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.button1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "RandomSelect";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
