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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = button1;
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
                comboBox1.Enabled = !comboBox1.Enabled;
			
		}
		public static List<string> getNameList(string Path)
        {
            List<string> nameList = new List<string>();
            try { StreamReader sr = new StreamReader(Path, Encoding.Default); 
            
            string content;
            while ((content = sr.ReadLine()) != null)
            {
                nameList.Add(content);
                //Console.WriteLine(content.ToString());
            }}
            catch (Exception) {
                Application.Restart();
            }
            return nameList;
        }
		
		void MainFormLoad(object sender, EventArgs e)
		{
            
			label1.Text="";
			timer1.Enabled=false;
			//timer1.Interval=dataset.interval;
			//if(!File.Exists("name.txt")){File.Create("name.txt");}

			 //List<string>nameList = new List<string>();
			 //nameList=getNameList("name.txt");
			 //toolStripStatusLabel1.Text="成功导入姓名"+nameList.Count+"个";
			 //dataset.namelist=nameList.ToArray();

            if (!Directory.Exists("data"))
            {
                try
                {
                    Directory.CreateDirectory("data");
                }
                catch (Exception)
                {
                    MessageBox.Show("data文件夹创建失败", "Error");
                    Environment.Exit(0);
                }

                try
                {
                    File.Create("data/default.txt");
                }
                catch (Exception)
                {
                    MessageBox.Show("default文件创建失败", "Error");
                    Environment.Exit(0);
                }
            }
            if (!(Directory.GetDirectories("data").Length > 0 || Directory.GetFiles("data").Length > 0))
            {
                try
                {
                    File.Create("data/default.txt");
                }
                catch (Exception)
                {
                    MessageBox.Show("default文件创建失败", "Error");
                    Environment.Exit(0);
                }
            }
            DirectoryInfo dict_info = new DirectoryInfo("data");
            FileSystemInfo[] fsinfos = dict_info.GetFileSystemInfos();
            Dictionary<string, string> nametxt_nametxtpath = new Dictionary<string, string>();
            List<string> name_t = new List<string>();
            foreach (FileSystemInfo fsinfo in fsinfos) 
            {
                name_t.Add(fsinfo.Name);
                nametxt_nametxtpath.Add(fsinfo.Name, fsinfo.FullName);
                
            }
            dataset.txtmap = nametxt_nametxtpath;
            dataset.namestxt_list = name_t.ToArray();
            foreach(string i in dataset.namestxt_list){
                comboBox1.Items.Add(i);
            } 
            comboBox1.SelectedText=dataset.namestxt_list[0];
            List<string> nameList = new List<string>();
            nameList = getNameList(dataset.txtmap[comboBox1.Text]);
            toolStripStatusLabel1.Text = "成功导入姓名" + nameList.Count + "个";
            dataset.namelist = nameList.ToArray();



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
            try
            {
                Random rd = new Random();
                int i = rd.Next(99, 65533);
                int j = i % (dataset.namelist.Length);
                label1.Text = dataset.namelist[j];
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("当前文件中没有内容，发生除0异常");
            }
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

        private void 数据管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DataManager().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string>nameList = new List<string>();
            nameList=getNameList(dataset.txtmap[comboBox1.Text]);
            toolStripStatusLabel1.Text="成功导入姓名"+nameList.Count+"个";
            dataset.namelist = nameList.ToArray();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
	}
}
