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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void пользователи1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователи1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectArazDataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet1.Роли". При необходимости она может быть перемещена или удалена.
            this.ролиTableAdapter.Fill(this.projectArazDataSet1.Роли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "projectArazDataSet1.Пользователи1". При необходимости она может быть перемещена или удалена.
            this.пользователи1TableAdapter.Fill(this.projectArazDataSet1.Пользователи1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
