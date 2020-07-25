using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace миллионер
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            textBox1.Text = " Вам часто приходит в голову мысль: \"Вот если бы у меня был миллион...\"?" + Environment.NewLine + " Не стоит грустить! Сегодня именно тот день!" + Environment.NewLine + " Сейчас вы сможете воплотить свои мечты и получить миллион долларов! Докажите, что вы их достойны. Вы сможете!";
        }

    }
}
