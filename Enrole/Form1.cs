using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrole
{
    public partial class Form1 : Form
    {
        //Изменялся ли текст или нет
        public bool change_grid = false;
        //Количестов записей
        public int numberofrecords = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet2.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.userDataSet.users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet1.users". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.userDataSet.users);
            this.numberrecords_update(sender, e);
        }

        //Информация о количество записей
        private void numberrecords_update(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                numberofrecords = dataGridView1.RowCount;
                set_numberofrecords(numberofrecords);
            }
            else
            {
                numberofrecords = 0;
                set_numberofrecords(numberofrecords);
            }
        }

        //Перевод числовоо значения int в строку
        private void set_numberofrecords(int value = 0)
        {
            records.Text = value.ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(userDataSet);
        }

        private void delete_row(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void add(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.Owner = this;
            af.Show();
        }

        private void search(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Owner = this;
            sf.Show();

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            numberofrecords = numberofrecords + 1;

            this.numberrecords_update(sender, e);
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            numberofrecords = numberofrecords - 1;

            this.numberrecords_update(sender, e);
        }

        private void exit_form(object sender, EventArgs e)
        {
            Close();
        }

        private void About_Info(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Owner = this;
            ab.Show();
        }
    }
}
