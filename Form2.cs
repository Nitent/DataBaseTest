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
    public partial class Form2 : Form
    {
        public Model1 db { get; set; }
        public Students students { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ageText.Text = students.Age.ToString();
            grouppaText.Text = students.Grouppa;
            idText.Text = students.ID.ToString();
            nameText.Text = students.Name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            students.Name = nameText.Text;
            students.Grouppa = grouppaText.Text;
            students.Age = Convert.ToInt32(ageText.Text);

            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
