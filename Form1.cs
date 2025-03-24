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
            studentsBindingSource.DataSource = model.Students.ToList();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.ID = Convert.ToInt32(iDTextBox.Text);
            students.Name = nameTextBox.Text;
            students.Grouppa = grouppaTextBox.Text;
            students.Age = Convert.ToInt32(ageTextBox.Text);
            model.Students.Add(students);
            model.SaveChanges();
            studentsBindingSource.DataSource = model.Students.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Students students = (Students)studentsBindingSource.Current;
            frm.db = model;
            frm.students = students;
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                studentsBindingSource.DataSource = model.Students.ToList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Students students = (Students)studentsBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить студента - " + students.Name,
                "Удаление студента", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                model.Students.Remove(students);
                try
                {
                    model.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                studentsBindingSource.DataSource = model.Students.ToList();
            }
        }
    }
}
