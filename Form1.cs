using DataBaseTest.DataEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseTest
{
    public partial class Form1 : Form
    {
        Model1 model = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            avtomobilsBindingSource.DataSource = model.Avtomobils.ToList();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(model);     
            if (frm.ShowDialog() == DialogResult.OK)
            {
                avtomobilsBindingSource.DataSource = model.Avtomobils.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Avtomobils avtomobils = (Avtomobils)avtomobilsBindingSource.Current;
            Form2 frm = new Form2(model , avtomobils);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                avtomobilsBindingSource.DataSource = model.Avtomobils.ToList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Avtomobils avtomobils = (Avtomobils)avtomobilsBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить автомобиль - " + avtomobils.Vladelec,
                "Удаление автомобиля", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                model.Avtomobils.Remove(avtomobils);
                try
                {
                    model.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                avtomobilsBindingSource.DataSource = model.Avtomobils.ToList();
            }
        }
    }
}
