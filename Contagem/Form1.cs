using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contagem
{
    public partial class Form1 : Form
    {
        int count = 0;
        bool powerOn = true;

        int currCountIndex = -1;
        Label[] counts = { new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label() };
        Label[] messages = { new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label(), new Label() };

        public Form1()
        {
            InitializeComponent();

            // Hidden button
            powerBtn.Parent = pictureBox1;
            powerBtn.BackColor = Color.Transparent;
            powerBtn.Location = new Point(985, 775);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counts[0] = numberCount0;
        }



        /* CLICK HANDLERS */
        private void addCount (object sender, EventArgs e)
        {
            if (count < 10)
            {
                count++;
            }

            printCount(count);
        }

        private void resetCount(object sender, EventArgs e)
        {
            count = 0;
            messageContainer.Controls.Clear();
            countContainer.Controls.Clear();
            createCount(0);
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            resetCount(new object(), new EventArgs());
            mainContainer.Visible = !powerOn;
            powerOn = !powerOn;
        }



        /* COMPONENTS HANDLERS */
        private void printCount(int number)
        {
            switch (number)
            {
                case 9:
                    createLabel($">⠀Falta⠀apenas⠀mais⠀{10 - number}...", number);

                    break;
                case 10:
                    createLabel("⠀⠀Acabou! :)", number);
                    break;
                default:
                    createLabel($">⠀Faltam⠀apenas⠀mais⠀{10 - number}...", number);
                    break;
            }

            createCount(number);
        }

        private void createLabel (string text, int index)
        {
            // Create & append message label
            Label newLabelLine = new Label();
            messageContainer.Controls.Add(newLabelLine);

            // Message label styling
            newLabelLine.Font = new Font("Unispace", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newLabelLine.ForeColor = Color.Silver;
            newLabelLine.Location = new Point(20, 10 + 20 * (index - 1));
            newLabelLine.Name = $"labelLine{index}";
            newLabelLine.Size = new Size(0, 18);
            newLabelLine.TabIndex = 0;
            newLabelLine.Text = text;
            newLabelLine.TextAlign = ContentAlignment.TopLeft;

            // Push message label into array
            messages[index - 1] = newLabelLine;
        }

        private void createCount (int number)
        {
            // Create & append count label
            Label newCount = new Label();
            countContainer.Controls.Add(newCount);

            // Count label styling
            newCount.Text = number.ToString();
            newCount.Location = new Point(0, -36);
            newCount.Name = $"numberCount{number}";
            newCount.Size = new Size(36, 36);
            newCount.TabIndex = 0;
            newCount.TextAlign = ContentAlignment.MiddleCenter;

            // Push count label into array
            counts[number] = newCount;
        }

        private void labelAnimation (object sender, EventArgs e)
        {
            // Message typing animation
            for (int i = 0; i < messages.Length; i++)
            {
                if (messages[i].Width < 400)
                {
                    messages[i].Width += 10;
                }
            }

            // Number count from top animation
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i].Top < 0)
                {
                    counts[i].Top += 3;
                    currCountIndex = i;
                }
            }

            // Number count to bottom animation
            for (int i = 0; i < currCountIndex; i++)
            {
                if (counts[i].Top < 36)
                {
                    counts[i].Top += 3;
                }
            }
        }
    }
}
