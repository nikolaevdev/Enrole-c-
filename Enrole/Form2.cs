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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.userDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = textBox_name.Text;
                nRow[2] = textBox_sex.Text;
                nRow[3] = textBox_num.Text;
                nRow[4] = textBox_email.Text;
                nRow[5] = dateTimePicker_dateofreceipt.Text;
                nRow[6] = textBox_group.Text;
                nRow[7] = textBox_specialty.Text;
                nRow[8] = textBox_passport.Text;
                nRow[9] = textBox_passport_placeofbirth.Text;
                nRow[10] = textBox_passport_division_сode.Text;
                nRow[11] = textBox_passport_placeofissue.Text;
                nRow[12] = dateTimePicker_passport_dateofissue.Text;
                main.userDataSet.Tables[0].Rows.Add(nRow);
                main.usersTableAdapter.Update(main.userDataSet.users);
                main.userDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox_name.Text = "";
                textBox_sex.Text = "";
                textBox_num.Text = "";
                textBox_email.Text = "";
            }

        }
    }
}
