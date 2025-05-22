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
        public Avtomobils avtomobils { get; set; }
        public Form2(Model1 _db)
        {
            InitializeComponent();
            db = _db;
            avtomobils = null;

        }
        public Form2(Model1 _db, Avtomobils _avtomobils)
        {
            InitializeComponent();
            db = _db;
            avtomobils = _avtomobils;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (avtomobils != null)
            {
                vozrastText.Text = avtomobils.Vozrast.ToString();
                markaText.Text = avtomobils.Marka;
                nomerText.Text = avtomobils.Nomer.ToString();
                vladelecText.Text = avtomobils.Vladelec;
                nomerText.ReadOnly = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (avtomobils == null)
            {
                avtomobils = new Avtomobils();
                avtomobils.Nomer = Convert.ToInt32(nomerText.Text);
                avtomobils.Vladelec = vladelecText.Text;
                avtomobils.Marka = markaText.Text;
                avtomobils.Vozrast = Convert.ToInt32(vozrastText.Text);
                db.Avtomobils.Add(avtomobils);
            }
            else
            {
                avtomobils.Vladelec = vladelecText.Text;
                avtomobils.Marka = markaText.Text;
                avtomobils.Vozrast = Convert.ToInt32(vozrastText.Text);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }
    }
}
