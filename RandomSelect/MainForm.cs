/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2022/1/9
 * 时间: 13:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.IO;

using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RandomSelect
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			/*if(dataset.isloop==false){
				dataset.isloop=true;
				button2.Enabled=false;
				timer1.Enabled=true;
			}
			if(dataset.isloop==true){
				dataset.isloop=false;
				button2.Enabled=true;
				timer1.Enabled=false;
			}*/
			timer1.Interval=dataset.interval;
				button2.Enabled=!button2.Enabled;
				timer1.Enabled=!timer1.Enabled;
            label1.Text = "limingrui";
			
		}
		public static List<string> getNameList(string Path)
        {
            List<string> nameList = new List<string>();
            StreamReader sr = new StreamReader(Path, Encoding.Default);
            string content;
            while ((content = sr.ReadLine()) != null)
            {
                nameList.Add(content);
                //Console.WriteLine(content.ToString());
            }

            return nameList;
        }
		
		void MainFormLoad(object sender, EventArgs e)
		{
			label1.Text="";
			timer1.Enabled=false;
			//timer1.Interval=dataset.interval;
			//if(!File.Exists("name.txt")){File.Create("name.txt");}
			 List<string>nameList = new List<string>();
			 nameList=getNameList("name.txt");
			 toolStripStatusLabel1.Text="成功导入姓名"+nameList.Count+"个";
			 dataset.namelist=nameList.ToArray();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			/*if(dataset.notemp>=(dataset.namelist.Length-1)){dataset.notemp=0;}*/
			try{
				dataset.temp=dataset.namelist[dataset.notemp];}
			catch(IndexOutOfRangeException){
				dataset.notemp=0;}
			
			label1.Text=dataset.temp;
			dataset.notemp++;
		}
		void Button2Click(object sender, EventArgs e)
		{
			Random rd=new Random();
			int i=rd.Next(99,65533);
			int j=i%(dataset.namelist.Length);
			label1.Text=dataset.namelist[j];
		}
		void 关于本程序ToolStripMenuItemClick(object sender, EventArgs e)
		{
			new About().Show();
		}
		void 退出ToolStripMenuItemClick(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}
		void 设置间隔时间ToolStripMenuItemClick(object sender, EventArgs e)
		{
			new Form1().Show();
		}
	}
}
