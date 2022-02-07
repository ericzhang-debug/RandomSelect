using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomSelect
{
    public partial class DataManager : Form
    {
        public DataManager()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void DataManager_Load(object sender, EventArgs e)
        {
            Item item = new Item("name");
            dataGridView1.DataSource = item;
           
        }
        private void FillDataGridViewWithForeach(DataGridView dataGridView, DataTable dTable)
        {
            //1.清空旧数据
            dataGridView.Rows.Clear();
            //2.赋值新数据
            foreach (DataRow row in dTable.Rows)
            {
                int index = dataGridView.Rows.Add();
                dataGridView.Rows[index].Cells["ITEM_NO2"].Value = row["ITEM_NO"];
                dataGridView.Rows[index].Cells["ITEM_NAME2"].Value = row["ITEM_NAME"];
                dataGridView.Rows[index].Cells["INPUT_CODE2"].Value = row["INPUT_CODE"];
            }
        }
    }
    class Item
    {
        private string _text;
        public string Text
        {
            get { return _text; }
        }
        public Item(string text)
        {
            this._text = text;
        }
    }

}
