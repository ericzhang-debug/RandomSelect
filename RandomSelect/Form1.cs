/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2022/1/9
 * 时间: 22:25
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomSelect
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
    /// 



	public partial class Form1 : Form
	{
		public Form1()
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
			try{
				dataset.interval=Int16.Parse(textBox1.Text);
			}
			catch(Exception){MessageBox.Show("输入错误");}
			this.Close();
			
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = dataset.interval.ToString();
        }
	}
}
