using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XOXtiklama(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (lblXO.Text == "X")
            {
                bt.Text = "X";
                bt.Enabled = false;
                lblXO.Text = "O";
            }
            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                lblXO.Text = "X";
            }

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Kazanan X!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }

            //*  O Kullanıcısı *//

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Kazanan O!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Oyun Berabere Bitti!", "Oyun Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oyunBitis();
            }
        }
        private void oyunBitis() 
        {
            lblXO.Text = "X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Oyundan Çıkmak İstiyor Musunuz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 oyun = new Form1();
            oyun.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OXO, Alexander Sandy Douglas tarafından 1952'de geliştirilen dünyanın ilk video oyunudur. Douglas, oyunu University of Cambridge'te doktora öğrencisi iken doktora tezi için geliştirmiştir. Oyun EDSAC bilgisayarı için geliştirilmiş olan bir tic tac toe oyunudur.", "Oyun Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OXO, Alexander Sandy Douglas tarafından 1952'de geliştirilen dünyanın ilk video oyunudur. Douglas, oyunu University of Cambridge'te doktora öğrencisi iken doktora tezi için geliştirmiştir. Oyun EDSAC bilgisayarı için geliştirilmiş olan bir tic tac toe oyunudur.", "Oyun Hakkında", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yatay, dikey veya çapraz sıradaki işaretleri sırayla üçe üç bir ızgarada boşlukları X veya O ile yerleştirmeyi başaran oyuncu kazanır.", "Nasıl Oynanır ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
