using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace миллионер
{
    public partial class AddQuestion : Form
    {
        Question newQuestion;

        List<TextBox> textBoxes = new List<TextBox>();

        public AddQuestion(Question q)
        {
            InitializeComponent();
            newQuestion = q;

            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newQuestion.question = textBox1.Text;
            newQuestion.rightAnswer = textBox2.Text;
            newQuestion.wrongAnswer[0] = textBox3.Text;
            newQuestion.wrongAnswer[1] = textBox4.Text;
            newQuestion.wrongAnswer[2] = textBox5.Text;
        }
        private bool Check()
        {
            int i = 0;
            while (i < textBoxes.Count)
            {
                if (textBoxes[i].Text.Length < 2 || textBoxes[i].Text == "")
                {
                    return false;
                }
                i++;
            }
            button1.Enabled = true;
            return true;

        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = textBox.Text.Trim();
                if (textBox.Text == "" || textBox.Text.Length < 2)
                {
                    MessageBox.Show("Неверный ввод");
                    textBox.BackColor = Color.MistyRose;
                    textBox.Focus();
                }
                else
                {
                    textBox.BackColor = Color.White;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
