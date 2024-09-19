using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int basu;
        int iasu;
        int üasu;
        int dasu;
        int bbasu;
        int aasu;
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            timer1.Enabled = true;
            basu = pictureBox3.Left;
            iasu = pictureBox2.Left;
            üasu = pictureBox1.Left;
            dasu = pictureBox4.Left;
            bbasu = pictureBox5.Left;
            aasu = pictureBox6.Left;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            int  bag = pictureBox3.Width;
            int iag = pictureBox2.Width;
            int üag = pictureBox1.Width;
            int dag = pictureBox4.Width;
            int bbag = pictureBox5.Width;
            int aag = pictureBox6.Width;
            int bu = label4.Left;
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(1, 10);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(1, 10);
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(1, 10);
            pictureBox4.Left = pictureBox4.Left + rastgele.Next(1, 10);
            pictureBox5.Left = pictureBox5.Left + rastgele.Next(1, 10);
            pictureBox6.Left = pictureBox6.Left + rastgele.Next(1, 10);
            if (bag + pictureBox1.Left >= bu)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. At Yarışı Kazandı!!");
                pictureBox1.Location = pictureBox13.Location;
                pictureBox1.Width = pictureBox13.Width;     
                pictureBox1.Height = pictureBox13.Height;
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                button1.Hide();
                button2.Visible = true;
                label15.Visible = true;


            }
            if (iag + pictureBox2.Left >= bu)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. At Yarışı Kazandı!!");
                pictureBox2.Location = pictureBox13.Location;
                pictureBox2.Width = pictureBox13.Width;
                pictureBox2.Height = pictureBox13.Height;
                pictureBox1.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                button1.Hide();
                button2.Visible = true;
                label15.Visible = true;

            }
            if (üag + pictureBox3.Left >= bu)
            {
                timer1.Enabled = false;
                MessageBox.Show("1. At Yarışı Kazandı!!");
                pictureBox3.Location = pictureBox13.Location;
                pictureBox3.Width = pictureBox13.Width;
                pictureBox3.Height = pictureBox13.Height;
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                button1.Hide();
                button2.Visible = true;
                label15.Visible = true;
            }
            if (dag + pictureBox4.Left >= bu)
            {
                timer1.Enabled = false;
                MessageBox.Show("5. At Yarışı Kazandı!!");
                pictureBox4.Location = pictureBox13.Location;
                pictureBox4.Width = pictureBox13.Width;
                pictureBox4.Height = pictureBox13.Height;
                pictureBox1.Hide();
                pictureBox3.Hide();
                pictureBox2.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                button1.Hide();
                button2.Visible = true;
                label15.Visible = true;
            }
            if (bbag + pictureBox5.Left >= bu)
            {
                timer1.Enabled = false;
                MessageBox.Show("4. At Yarışı Kazandı!!");
                pictureBox5.Location = pictureBox13.Location;
                pictureBox5.Width = pictureBox13.Width;
                pictureBox5.Height = pictureBox13.Height;
                pictureBox1.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox2.Hide();
                pictureBox6.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                button1.Hide();
                button2.Visible = true;
                label15.Visible = true;
            }
            if (aag + pictureBox6.Left >= bu)
            {
                timer1.Enabled = false;
                MessageBox.Show("6. At Yarışı Kazandı!!");
                pictureBox6.Location = pictureBox13.Location;
                pictureBox6.Width = pictureBox13.Width;
                pictureBox6.Height = pictureBox13.Height;
                pictureBox1.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox2.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                button1.Hide();
                button2.Visible = true;
                label15.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label15.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Location = pictureBox7.Location;
            pictureBox2.Location = pictureBox8.Location;
            pictureBox3.Location = pictureBox9.Location;
            pictureBox4.Location = pictureBox10.Location;
            pictureBox5.Location = pictureBox11.Location;
            pictureBox6.Location = pictureBox12.Location;
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            label1.Show();
            label2.Show(); 
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            button1.Show();
            pictureBox1.Width = pictureBox7.Width;
            pictureBox2.Width = pictureBox8.Width;
            pictureBox3.Width = pictureBox9.Width;
            pictureBox4.Width = pictureBox10.Width;
            pictureBox5.Width = pictureBox11.Width;
            pictureBox6.Width = pictureBox12.Width;
            pictureBox1.Height = pictureBox7.Height;
            pictureBox2.Height = pictureBox8.Height;
            pictureBox3.Height = pictureBox9.Height;
            pictureBox4.Height = pictureBox10.Height;
            pictureBox5.Height = pictureBox11.Height;
            pictureBox6.Height = pictureBox12.Height;
            label15.Visible = false;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
