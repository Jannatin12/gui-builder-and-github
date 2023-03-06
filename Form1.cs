using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302213051
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.bil1 = "";
            this.bil2 = "";
        }

        string bil;
        string bil1;
        string bil2;
        int angka1;
        int angka2;

        private void Submit_Click(object sender, EventArgs e)
        {
            this.bil2 = this.inputAngka.Text;
            this.inputAngka.Text = "";
            Refresh();

            angka1 = int.Parse(bil1);
            angka2 = int.Parse(bil2);

            this.label1.Text = "Hasil " + angka1 + angka2;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            this.bil1 = this.inputAngka.Text;
            this.inputAngka.Text = "";
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bil = "1";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bil = "2";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bil = "3";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bil = "4";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bil = "5";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bil = "6";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bil = "7";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bil = "8";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bil = "9";
            this.inputAngka.Text =  bil;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            bil = "0";
            this.inputAngka.Text = this.inputAngka.Text + bil;
        }

        private void inputAngka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
