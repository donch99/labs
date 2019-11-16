using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using lab5;

namespace lab4
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        string content;
        string[] words;

        public Form1()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label4.Hide();
            label5.Hide();
            min1.Hide();
            min2.Hide();
            search2.Hide();
            searchword2.Hide();
            listBox2.Hide();
            search3.Hide();
            searchword3.Hide();
            listBox3.Hide();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Только текстовые файлы|*.txt"; 
            of.ShowDialog();

            if (of.FileName != "")
            {
                Stopwatch stopWatch = new Stopwatch();
                TimeSpan ts;
                stopWatch.Start();
                content += File.ReadAllText(of.FileName);
                
                words = content.Split(new char[] {
                    ' ', '\r', '\n', '.', '!', '?', '’', '‘', '\'', ';', ':', ','
                }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in words)
                {
                    if (!list.Contains(s))
                    {
                        list.Add(s); 
                    }
                }
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
                timeload.Text = Convert.ToString(ts.TotalSeconds) + " с";
            }
        }

        private void search1_Click(object sender, EventArgs e)
        {
            if (list.Contains(searchword1.Text))
            {
                bool flag = false;
                foreach (string s in listBox1.Items)
                {
                    if (s == searchword1.Text)
                        flag = true;
                }
                if (!flag)
                {
                    listBox1.BeginUpdate();
                    listBox1.Items.Add(searchword1.Text);
                    listBox1.EndUpdate();
                }
                else
                    MessageBox.Show("Слово уже найдено!");
            }
            else
                MessageBox.Show("Слово не найдено!");
        }

        private void upgrade_Click(object sender, EventArgs e)
        {
            Button ls = (Button)sender; 
            ls.Hide();
            label1.Show();
            label2.Show();
            label4.Show();
            label5.Show();
            min1.Show();
            min2.Show();
            search2.Show();
            searchword2.Show();
            listBox2.Show();
            search3.Show();
            searchword3.Show();
            listBox3.Show();
        }

        private void search2_Click(object sender, EventArgs e)
        {
            string index = "";
            int min;
            try
            {
                min = Convert.ToInt32(min1.Text);
            }
            catch
            {
                min = searchword2.TextLength;
            }
            foreach (string s in list)
            {
                int distance = Fisher.Levinstain(searchword2.Text, s);
                if ((distance < min) && (distance <= min))
                {
                    min = distance;
                    index = s;
                }
            }


            bool flag = false;
            foreach (string i in listBox2.Items)
            {
                if (i == index)
                    flag = true;
            }

            if (index == "")
            {
                MessageBox.Show("Слово не найдено!");
            }
            else if (!flag)
            {
                listBox2.BeginUpdate();
                listBox2.Items.Add(index);
                listBox2.EndUpdate();
            }
            else
                MessageBox.Show("Слово уже найдено!");
        }

        private void search3_Click(object sender, EventArgs e)
        {
            string index = "";
            int min;
            try
            {
                min = Convert.ToInt32(min1.Text);
            }
            catch
            {
                min = searchword3.TextLength;
            }
            foreach (string s in list)
            {
                int distance = Fisher.DemLevinstain(searchword3.Text, s);
                if ((distance < min) && (distance <= min))
                {
                    min = distance;
                    index = s;
                }
            }


            bool flag = false;
            foreach (string i in listBox3.Items)
            {
                if (i == index)
                    flag = true;
            }

            if (index == "")
            {
                MessageBox.Show("Слово не найдено!");
            }
            else if (!flag)
            {
                listBox3.BeginUpdate();
                listBox3.Items.Add(index);
                listBox3.EndUpdate();
            }
            else
                MessageBox.Show("Слово уже найдено!");
        }
    }
}
