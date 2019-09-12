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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void пользователи1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователи1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectArazDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet1.Регион". При необходимости она может быть перемещена или удалена.
            this.регионTableAdapter.Fill(this.projectArazDataSet1.Регион);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet1.Пользователи1". При необходимости она может быть перемещена или удалена.
            this.пользователи1TableAdapter1.Fill(this.projectArazDataSet1.Пользователи1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet.Роли". При необходимости она может быть перемещена или удалена.
            this.ролиTableAdapter.Fill(this.projectArazDataSet.Роли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet.Пользователи1". При необходимости она может быть перемещена или удалена.
            this.пользователи1TableAdapter.Fill(this.projectArazDataSet.Пользователи1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.Show();
        }
    }
}
