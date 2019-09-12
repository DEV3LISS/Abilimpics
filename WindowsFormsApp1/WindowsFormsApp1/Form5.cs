using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void пользователи1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователи1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectArazDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet1.Роли". При необходимости она может быть перемещена или удалена.
            this.ролиTableAdapter.Fill(this.projectArazDataSet1.Роли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet1.Пользователи1". При необходимости она может быть перемещена или удалена.
            this.пользователи1TableAdapter.Fill(this.projectArazDataSet1.Пользователи1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            пользователи1BindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            пользователи1BindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            пользователи1BindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            пользователи1BindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            пользователи1BindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            пользователи1BindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователи1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectArazDataSet1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
