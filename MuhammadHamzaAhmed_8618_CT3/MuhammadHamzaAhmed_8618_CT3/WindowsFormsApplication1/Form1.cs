using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhammadHamzaAhmed_8618_CT3;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int billno = 1;

        Class1 a = new Class1();
        List<String> addItems = new List<String>();

        double total = 0;
        int counter = 1;
        public Form1()
        {
            InitializeComponent();
            listView1.Items.Add("S.No       Product     Rate");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItems.Add(counter + "             fajita(pan)" + "         399");

            listView1.Items.Add(counter + "             fajita(pan)" + "         399");
            counter++;
            total += 399;
            totValue.Text = "" + total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             fajita(regular)" + "         599");
            counter++;
            total += 599;
            totValue.Text = "" + total;
            addItems.Add(counter + "             fajita(regular)" + "         599");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             fajita(large)" + "         999");
            counter++;
            total += 999;
            totValue.Text = "" + total;
            addItems.Add(counter + "             fajita(large)" + "         999");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             spicy(pan)" + "         399");
            counter++;
            total += 399;
            totValue.Text = "" + total;
            addItems.Add(counter + "             spicy(pan)" + "         399");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             spicy(regular)" + "         599");
            counter++;
            total += 599;
            totValue.Text = "" + total;
            addItems.Add(counter + "             spicy(regular)" + "         599");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             spicy(large)" + "         999");
            counter++;
            total += 999;
            totValue.Text = "" + total;
            addItems.Add(counter + "             spicy(large)" + "         999");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             tikka(pan)" + "         499");
            counter++;
            total += 499;
            totValue.Text = "" + total;
            addItems.Add(counter + "             tikka(pan)" + "         499");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             tikka(regular)" + "         699");
            counter++;
            total += 699;
            totValue.Text = "" + total;
            addItems.Add(counter + "             tikka(regular)" + "         699");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(counter + "             tikka(large)" + "         1050");
            counter++;
            total += 4050;
            totValue.Text = "" + total;
            addItems.Add(counter + "             tikka(large)" + "         1050");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string texttoadd = "";
            totValue.Text = " " + total;
            String path = Directory.GetCurrentDirectory() + "\\bill.txt";
            StreamWriter writer = new StreamWriter(path, append: true);
            texttoadd = listView1.Items.ToString();
            writer.WriteLine("Bill#" + billno);

            foreach (string item in listView1.Items)
            {
                writer.WriteLine(item);
            }
            writer.Close();
            billno++;
            MessageBox.Show("success");
        }
    }
}
