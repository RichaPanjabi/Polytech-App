using PolytechLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolytechFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var testpolytech = new Polytech();

            testpolytech.name = txtbxName.Text;
            testpolytech.address = txtbxAddress.Text;
            testpolytech.city = txtbxCity.Text;
            testpolytech.region = txtbxRegion.Text;
            testpolytech.postcode = txtbxRegion.Text;
            testpolytech.phoneNumber = txtbxPhoneNumber.Text;

            try
            {
                testpolytech.twitterAddress = txtbxTwitterAddress.Text;
                MessageBox.Show(testpolytech.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MessageBox.Show(testpolytech.ToString());


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Teacher t1 = new Teacher();
            float r;
            r = t1.ComputeGradeAverage();
            string result;
            result = r.ToString();

            MessageBox.Show(result);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Student s1 = new Student();
            float r;
            r = s1.ComputeGradeAverage();
            string result;
            result = r.ToString();

            MessageBox.Show(result);
        }
    }
}
