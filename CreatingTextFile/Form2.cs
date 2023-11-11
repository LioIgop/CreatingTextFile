using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] stud_info = {"Student Number: " + txtStudentNo.Text, "Full Name: " +  txtFirstName.Text + " " + txtLastName.Text + " ", "Program: " + cbProgram.Text, "Gender: " +
            cbGender.Text, "Age: " + txtAge.Text, "Birthdate: " + dateTimePickerBday.Text,
            "Contact Number: " + txtContactNo.Text};

            string doccPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(doccPath, txtStudentNo.Text + ".txt")))
            {
                foreach (string s in stud_info)
                {
                    outputFile.WriteLine(s);
                }

                MessageBox.Show("Successfuly created!!!");
                Close();
            }
        }
    }
}
