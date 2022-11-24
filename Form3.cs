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

namespace TextFileMasajo
{
    public partial class FrmRegistration : Form
    {
        String getInput;

        public static string SetFileName;

        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            String studentNo = textBox1.Text;
            String LastName = textBox2.Text;
            String M_I = textBox5.Text;
            String Age = textBox3.Text;
            String Birthday = dateTimePicker1.Text;
            String Program = comboBox1.Text;
            String First_Name = textBox4.Text;
            String Gender = comboBox2.Text;
            String ContactNo = textBox6.Text;


            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,studentNo + ".txt")))
            {
               
                outputFile.WriteLine("StudentNo.:" + studentNo);
                outputFile.WriteLine("Full Name:" + LastName + "," + First_Name + "," + M_I);
                outputFile.WriteLine("Program:" + Program);
                outputFile.WriteLine("Gender:" + Gender);
                outputFile.WriteLine("Age:" + Age);
                outputFile.WriteLine("Birthday:" + Birthday);
                outputFile.WriteLine("Contact No.:" + ContactNo);
            }
            this.Close();
        }
    }
}
