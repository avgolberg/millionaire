using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace миллионер
{
    public partial class EditQuestion : Form
    {
        List<string> queations;
        List<string> rightAnswers;
        List<string> wrongAnswers;
        List<TextBox> textBoxes = new List<TextBox>();
        public EditQuestion(List<string> queations_, List<string> rightAnswers_, List<string> wrongAnswers_)
        {
            InitializeComponent();

            queations = queations_;
            rightAnswers = rightAnswers_;
            wrongAnswers = wrongAnswers_;

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = queations.Count;

            numericUpDown1.Value = 1;

            textBox1.Text = queations[(int)numericUpDown1.Value - 1];
            textBox2.Text = rightAnswers[(int)numericUpDown1.Value - 1];
            textBox3.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3];
            textBox4.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 1];
            textBox5.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 2];

            textBoxes.Add(textBox1);
            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queations[(int)numericUpDown1.Value - 1] = textBox1.Text;
            rightAnswers[(int)numericUpDown1.Value - 1] = textBox2.Text;
            wrongAnswers[((int)numericUpDown1.Value - 1) * 3] = textBox3.Text;
            wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 1] = textBox4.Text;
            wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 2] = textBox5.Text;
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
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = queations[(int)numericUpDown1.Value - 1];
            textBox2.Text = rightAnswers[(int)numericUpDown1.Value - 1];
            textBox3.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3];
            textBox4.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 1];
            textBox5.Text = wrongAnswers[((int)numericUpDown1.Value - 1) * 3 + 2];
        }
    }
}
