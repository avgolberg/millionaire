using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace миллионер
{
    public partial class DeleteQuestion : Form
    {
        List<string> queations;
        List<string> rightAnswers;
        List<string> wrongAnswers;
        public DeleteQuestion(List<string> queations_, List<string> rightAnswers_, List<string> wrongAnswers_)
        {
            InitializeComponent();

            queations = queations_;
            rightAnswers = rightAnswers_;
            wrongAnswers = wrongAnswers_;
            
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = queations.Count;

            numericUpDown1.Value = 1;

            textBox1.Text = queations[(int)numericUpDown1.Value - 1];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queations.RemoveAt((int)numericUpDown1.Value - 1);
            rightAnswers.RemoveAt((int)numericUpDown1.Value - 1);
            wrongAnswers.RemoveAt(((int)numericUpDown1.Value - 1) * 3 + 2);
            wrongAnswers.RemoveAt(((int)numericUpDown1.Value - 1) * 3 + 1);
            wrongAnswers.RemoveAt(((int)numericUpDown1.Value - 1) * 3);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = queations[(int)numericUpDown1.Value - 1];
        }
    }
}
