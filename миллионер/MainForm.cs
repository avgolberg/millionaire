using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace миллионер
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        List<string> questions;
        List<string> rightAnswers;
        List<string> wrongAnswers;
        List<int> randomNumbers;

        int numberOfQuestion = 0;

        int numberOfGame = 0;

        SoundPlayer sound;

        public Form1()
        {
            InitializeComponent();
            questions = new List<string> { };
            rightAnswers = new List<string> { };
            wrongAnswers = new List<string> { };
            randomNumbers = new List<int>();
            sound = new SoundPlayer();

            ReadDataFromFile();

            labelMain.Text = "Добро пожаловать в игру \n\"Кто хочет стать миллионером\"";

            ButtonsEnabledFalse(buttonNewGame, buttonHalfAnswers, buttonCallFriend, buttonPeople, buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD, buttonPlayAgainYes, buttonPlayAgainNo);

            sound.SoundLocation = @"..\..\Resources\begin.wav";
            sound.Play();

        }
        private void ButtonsEnabledFalse(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button button = senders[i] as Button;
                button.Enabled = false;
            }
        }
        private void ButtonsEnabledTrue(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button button = senders[i] as Button;
                button.Enabled = true;
            }
        }
        private void ButtonsTagEnabledFalse(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button button = senders[i] as Button;
                button.Tag = "EnabledFalse";
            }
        }
        private void ButtonsTagEnabledTrue(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button button = senders[i] as Button;
                button.Tag = "EnabledTrue";
            }
        }
        private void ButtonsVisibleTrue(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button button = senders[i] as Button;
                button.Visible = true;
            }
        }
        private void ButtonsVisibleFalse(params object[] senders)
        {
            for (int i = 0; i < senders.Length; i++)
            {
                Button button = senders[i] as Button;
                button.Visible = false;
            }
        }

        private void ReadDataFromFile()
        {
            try
            {
                StreamReader sr = new StreamReader(@"..\..\question.txt", Encoding.Default);
                string line;
                int counter = 0, counter2 = 4, counter3 = 3, counter4 = 2, counter5 = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (counter % 5 == 0)
                    {
                        questions.Add(line);
                    }
                    if (counter2 % 5 == 0)
                    {
                        rightAnswers.Add(line);
                    }
                    if (counter3 % 5 == 0 || counter4 % 5 == 0 || counter5 % 5 == 0)
                    {
                        wrongAnswers.Add(line);
                    }
                    counter++;
                    counter2++;
                    counter3++;
                    counter4++;
                    counter5++;
                }
                sr.Close();
            }
            catch (Exception)
            {

            }
        }

        public List<int> GetRandomNumbers(int count)
        {
            List<int> randomNumbers = new List<int>();

            int number;

            for (int i = 0; i < count; i++)
            {
                do
                {
                    number = rand.Next(0, questions.Count);
                }
                while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            return randomNumbers;
        }

        private void NewQuestion() //смена вопр
        {
            Rows();
            if (numberOfQuestion == 0)
            {
                ButtonsEnabledTrue(buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD, buttonHalfAnswers, buttonCallFriend, buttonPeople);
            }
            else
            {
                ButtonsEnabledTrue(buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD);
                if ((string)buttonHalfAnswers.Tag == "EnabledTrue")
                {
                    buttonHalfAnswers.Enabled = true;
                }
                else
                {
                    buttonHalfAnswers.Enabled = false;
                }

                if ((string)buttonCallFriend.Tag == "EnabledTrue")
                {
                    buttonCallFriend.Enabled = true;
                }
                else
                {
                    buttonCallFriend.Enabled = false;
                }

                if ((string)buttonPeople.Tag == "EnabledTrue")
                {
                    buttonPeople.Enabled = true;
                }
                else
                {
                    buttonPeople.Enabled = false;
                }
            }

            buttonAnswerA.BackColor = Color.Black;
            buttonAnswerB.BackColor = Color.Black;
            buttonAnswerC.BackColor = Color.Black;
            buttonAnswerD.BackColor = Color.Black;

            groupBoxPeopleHelp.Visible = false;
            pictureBoxRightAnswer.Visible = false;
            pictureBoxFriend.Visible = false;
            pictureBoxMoney.Visible = false;
            labelRightAnswer.Visible = false;
            labelFriendAnswer.Visible = false;
            ButtonsVisibleTrue(buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD);
            ButtonsVisibleFalse(buttonPlayAgainYes, buttonPlayAgainNo);

            if (numberOfQuestion == 15)
            {
                labelMain.Text = "Вы выграли МИЛЛИОН. Поздравляем!!!";

                sound.SoundLocation = @"..\..\Resources\winner.wav";
                sound.Play();

                ButtonsEnabledFalse(buttonHalfAnswers, buttonCallFriend, buttonPeople);

                pictureBoxMoney.Visible = true;
                ButtonsVisibleFalse(buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD, buttonPlayAgainYes, buttonPlayAgainNo);
            }
            if (numberOfQuestion <= 14)
            {
                labelMain.Text = questions[randomNumbers[numberOfQuestion]];

                switch (rand.Next(1, 5))
                {
                    case 1:
                        buttonAnswerA.Text = "A: " + rightAnswers[randomNumbers[numberOfQuestion]];
                        buttonAnswerB.Text = "B: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3];
                        buttonAnswerC.Text = "C: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 1];
                        buttonAnswerD.Text = "D: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 2];
                        break;
                    case 2:
                        buttonAnswerA.Text = "A: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3];
                        buttonAnswerB.Text = "B: " + rightAnswers[randomNumbers[numberOfQuestion]];
                        buttonAnswerC.Text = "C: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 1];
                        buttonAnswerD.Text = "D: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 2];
                        break;
                    case 3:
                        buttonAnswerA.Text = "A: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3];
                        buttonAnswerB.Text = "B: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 1];
                        buttonAnswerC.Text = "C: " + rightAnswers[randomNumbers[numberOfQuestion]];
                        buttonAnswerD.Text = "D: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 2];
                        break;

                    case 4:
                        buttonAnswerA.Text = "A: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3];
                        buttonAnswerB.Text = "B: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 2];
                        buttonAnswerC.Text = "C: " + wrongAnswers[randomNumbers[numberOfQuestion] * 3 + 1];
                        buttonAnswerD.Text = "D: " + rightAnswers[randomNumbers[numberOfQuestion]];
                        break;
                }
            }
        }
        private void Choice() //еще раз?
        {
            ButtonsVisibleFalse(buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD);
            ButtonsVisibleTrue(buttonPlayAgainYes, buttonPlayAgainNo);

            labelMain.Text = "Вы проиграли. Играем еще раз?";

            buttonPlayAgainYes.Text = "Да";
            buttonPlayAgainNo.Text = "Нет";
        }
        private void Rows() //полосочки
        {
            List<Label> rows = new List<Label>();

            for (int i = 0; i < panelRows.Controls.Count; i++)
            {
                rows.Add((Label)panelRows.Controls[i]);

                rows[i].BackColor = Color.Black;

                if (numberOfQuestion == i)
                {
                    rows[i].BackColor = Color.Orange;
                }
            }
        }
        private new void Right(object sender)
        {
            Button button = sender as Button;

            if (button != null)
            {
                button.BackColor = Color.Green;

                pictureBoxRightAnswer.Visible = true;
                labelRightAnswer.Visible = true;

                sound.SoundLocation = @"..\..\Resources\true.wav";
                sound.Play();
            }

            ButtonsEnabledFalse(buttonHalfAnswers, buttonCallFriend, buttonPeople);
            if (sender == buttonAnswerA)
            {
                ButtonsEnabledFalse(buttonAnswerB, buttonAnswerC, buttonAnswerD);
            }
            else if (sender == buttonAnswerB)
            {
                ButtonsEnabledFalse(buttonAnswerA, buttonAnswerC, buttonAnswerD);
            }
            else if (sender == buttonAnswerC)
            {
                ButtonsEnabledFalse(buttonAnswerA, buttonAnswerB, buttonAnswerD);
            }
            else if (sender == buttonAnswerD)
            {
                ButtonsEnabledFalse(buttonAnswerA, buttonAnswerB, buttonAnswerC);
            }
        }
        private void Wrong(object sender)
        {
            if (sender != null)
            {
                Button button = sender as Button;
                button.BackColor = Color.Red;

                sound.SoundLocation = @"..\..\Resources\false.wav";
                sound.Play();
            }

            ButtonsEnabledFalse(buttonHalfAnswers, buttonCallFriend, buttonPeople);
            if (sender == buttonAnswerA)
            {
                ButtonsEnabledFalse(buttonAnswerB, buttonAnswerC, buttonAnswerD);
            }
            else if (sender == buttonAnswerB)
            {
                ButtonsEnabledFalse(buttonAnswerA, buttonAnswerC, buttonAnswerD);
            }
            else if (sender == buttonAnswerC)
            {
                ButtonsEnabledFalse(buttonAnswerA, buttonAnswerB, buttonAnswerD);
            }
            else if (sender == buttonAnswerD)
            {
                ButtonsEnabledFalse(buttonAnswerA, buttonAnswerB, buttonAnswerC);
            }
        }

        private void buttonAnswerA_Click(object sender, EventArgs e)
        {
            if (buttonAnswerA.Text == "A: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                Right(sender);
                timerRightAnswers.Start();
            }
            else
            {
                Wrong(sender);
                timerWrongAnswers.Start();
            }
        }

        private void buttonAnswerB_Click(object sender, EventArgs e)
        {

            if (buttonAnswerB.Text == "B: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                Right(sender);
                timerRightAnswers.Start();
            }
            else
            {
                Wrong(sender);
                timerWrongAnswers.Start();
            }
        }

        private void buttonAnswerC_Click(object sender, EventArgs e)
        {

            if (buttonAnswerC.Text == "C: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                Right(sender);
                timerRightAnswers.Start();
            }
            else
            {
                Wrong(sender);
                timerWrongAnswers.Start();
            }
        }

        private void buttonAnswerD_Click(object sender, EventArgs e)
        {

            if (buttonAnswerD.Text == "D: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                Right(sender);
                timerRightAnswers.Start();
            }
            else
            {
                Wrong(sender);
                timerWrongAnswers.Start();
            }
        }
        private void timerRightAnswers_Tick(object sender, EventArgs e)
        {
            timerRightAnswers.Stop();

            numberOfQuestion++;
            Rows();
            NewQuestion();
        }

        private void timerWrongAnswers_Tick(object sender, EventArgs e)
        {
            timerWrongAnswers.Stop();

            Choice();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            menuStrip.Visible = false;

            if (numberOfGame == 0)
            {
                buttonNewGame.Location = new Point(buttonNewGame.Location.X, buttonNewGame.Location.Y - 20);
                buttonExit.Location = new Point(buttonExit.Location.X, buttonExit.Location.Y - 20);
            }
            numberOfGame++;

            randomNumbers = GetRandomNumbers(15);

            Rows();
            numberOfQuestion = 0;
            NewQuestion();

            buttonHalfAnswers.Image = миллионер.Properties.Resources._1;
            buttonCallFriend.Image = миллионер.Properties.Resources._2;
            buttonPeople.Image = миллионер.Properties.Resources._3;

            ButtonsEnabledTrue(buttonNewGame, buttonHalfAnswers, buttonCallFriend, buttonPeople, buttonAnswerA, buttonAnswerB, buttonAnswerC, buttonAnswerD, buttonPlayAgainYes, buttonPlayAgainNo);
            ButtonsTagEnabledTrue(buttonHalfAnswers, buttonCallFriend, buttonPeople);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonHalfAnswers_Click(object sender, EventArgs e) // 50/50
        {
            if (buttonAnswerA.Text == "A: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                switch (rand.Next(1, 4))
                {
                    case 1:
                        ButtonsVisibleFalse(buttonAnswerC, buttonAnswerD);
                        break;
                    case 2:
                        ButtonsVisibleFalse(buttonAnswerB, buttonAnswerD);
                        break;
                    case 3:
                        ButtonsVisibleFalse(buttonAnswerB, buttonAnswerC);
                        break;
                }
            }

            if (buttonAnswerB.Text == "B: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                switch (rand.Next(1, 4))
                {
                    case 1:
                        ButtonsVisibleFalse(buttonAnswerC, buttonAnswerD);
                        break;
                    case 2:
                        ButtonsVisibleFalse(buttonAnswerA, buttonAnswerD);
                        break;
                    case 3:
                        ButtonsVisibleFalse(buttonAnswerA, buttonAnswerC);
                        break;
                }
            }

            if (buttonAnswerC.Text == "C: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                switch (rand.Next(1, 4))
                {
                    case 1:
                        ButtonsVisibleFalse(buttonAnswerA, buttonAnswerB);
                        break;
                    case 2:
                        ButtonsVisibleFalse(buttonAnswerA, buttonAnswerD);
                        break;
                    case 3:
                        ButtonsVisibleFalse(buttonAnswerB, buttonAnswerD);
                        break;
                }
            }

            if (buttonAnswerD.Text == "D: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                switch (rand.Next(1, 4))
                {
                    case 1:
                        ButtonsVisibleFalse(buttonAnswerA, buttonAnswerB);
                        break;
                    case 2:
                        ButtonsVisibleFalse(buttonAnswerA, buttonAnswerC);
                        break;
                    case 3:
                        ButtonsVisibleFalse(buttonAnswerB, buttonAnswerC);
                        break;
                }
            }

            buttonHalfAnswers.Image = миллионер.Properties.Resources._4;

            buttonHalfAnswers.Enabled = false;
            buttonHalfAnswers.Tag = "EnabledFalse";
        }

        private void buttonCallFriend_Click(object sender, EventArgs e) //друг
        {
            sound.SoundLocation = @"..\..\Resources\zvonok.wav";
            sound.Play();

            pictureBoxFriend.Visible = true;
            labelFriendAnswer.Visible = true;

            labelFriendAnswer.Text += rightAnswers[randomNumbers[numberOfQuestion]];

            buttonCallFriend.Image = миллионер.Properties.Resources._5;

            buttonCallFriend.Enabled = false;
            buttonCallFriend.Tag = "EnabledFalse";
        }

        private void buttonPeople_Click(object sender, EventArgs e)
        {
            groupBoxPeopleHelp.Visible = true;

            int A = 0, B = 0, C = 0, D = 0;

            if (buttonAnswerA.Text == "A: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                do
                {
                    A = rand.Next(55, 87);
                    B = rand.Next(0, 13);
                    C = rand.Next(0, 13);
                    D = rand.Next(0, 13);
                } while ((A + B + C + D) != 100);
            }

            if (buttonAnswerB.Text == "B: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                do
                {
                    A = rand.Next(0, 13);
                    B = rand.Next(55, 87);
                    C = rand.Next(0, 13);
                    D = rand.Next(0, 13);
                } while ((A + B + C + D) != 100);
            }

            if (buttonAnswerC.Text == "C: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                do
                {
                    A = rand.Next(0, 13);
                    B = rand.Next(0, 13);
                    C = rand.Next(55, 87);
                    D = rand.Next(0, 13);
                } while ((A + B + C + D) != 100);
            }

            if (buttonAnswerD.Text == "D: " + rightAnswers[randomNumbers[numberOfQuestion]])
            {
                do
                {
                    A = rand.Next(0, 13);
                    B = rand.Next(0, 13);
                    C = rand.Next(0, 13);
                    D = rand.Next(55, 87);
                } while ((A + B + C + D) != 100);
            }

            labelPeopleHeplA.Text += A;
            labelPeopleHeplB.Text += B;
            labelPeopleHeplC.Text += C;
            labelPeopleHeplD.Text += D;

            progressBarPeopleHeplA.Value = A;
            progressBarPeopleHeplB.Value = B;
            progressBarPeopleHeplC.Value = C;
            progressBarPeopleHeplD.Value = D;

            buttonPeople.Image = миллионер.Properties.Resources._6;

            buttonPeople.Enabled = false;
            buttonPeople.Tag = "EnabledFalse";
        }

        private void AddQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            AddQuestion addQuestionForm = new AddQuestion(question);
            if (addQuestionForm.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(@"..\..\question.txt", true, Encoding.Default);
                if (questions.Count != 0) sw.Write("\n");
                sw.WriteLine(question.question);
                sw.WriteLine(question.rightAnswer);
                for (int i = 0; i < 2; i++)
                {
                    sw.WriteLine(question.wrongAnswer[i]);
                }
                sw.Write(question.wrongAnswer[2]);
                questions.Add(question.question);
                rightAnswers.Add(question.rightAnswer);
                for (int i = 0; i < 3; i++)
                {
                    wrongAnswers.Add(question.wrongAnswer[i]);
                }
                sw.Close();
            }
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteQuestion deleteQuestionForm = new DeleteQuestion(questions, rightAnswers, wrongAnswers);
            if (deleteQuestionForm.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(@"..\..\question.txt", false, Encoding.Default);
                for (int i = 0; i < questions.Count; i++)
                {
                    if (i != 0) sw.Write("\n");
                    sw.WriteLine(questions[i]);
                    sw.WriteLine(rightAnswers[i]);
                    sw.WriteLine(wrongAnswers[i * 3]);
                    sw.WriteLine(wrongAnswers[i * 3 + 1]);
                    sw.Write(wrongAnswers[i * 3 + 2]);
                }
                sw.Close();
            }
        }

        private void EditQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditQuestion editQuestion = new EditQuestion(questions, rightAnswers, wrongAnswers);
            if (editQuestion.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(@"..\..\question.txt", false, Encoding.Default);
                for (int i = 0; i < questions.Count; i++)
                {
                    if (i != 0) sw.Write("\n");
                    sw.WriteLine(questions[i]);
                    sw.WriteLine(rightAnswers[i]);
                    sw.WriteLine(wrongAnswers[i * 3]);
                    sw.WriteLine(wrongAnswers[i * 3 + 1]);
                    sw.Write(wrongAnswers[i * 3 + 2]);
                }
                sw.Close();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
    public class Question
    {
        public string question { get; set; }
        public string rightAnswer { get; set; }
        public string[] wrongAnswer { get; set; } = new string[3];

    }
}
