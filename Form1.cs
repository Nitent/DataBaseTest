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
            dataGridView1.DataSource = model.Students.ToList();
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
            dataGridView1.DataSource = model.Students.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
