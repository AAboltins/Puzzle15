using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle15
{
    public partial class PuzzleArea : Form
    {
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
        }

        private void InitializePuzzleArea()
        {
            this.BackColor = Color.Black;
            this.Text = "Puzzle15";
            InitalizeButtons();
        }

        private void InitalizeButtons()
        {
            int lentgth;
            int top;
            top = 1;
            lentgth = 0;
            for (int i = 1; i < 17; i++)
            {

                lentgth++;
                Button button = new Button();
                this.Controls.Add(button);
                button.Name = $"Button{i}";
                if(i == 17) { button.Name = "Empty";}
                button.Width = button.Height = 100;
                button.Left = lentgth * button.Width;
                button.Top = top * button.Width ;
                if (lentgth == 4)
                {
                    top++;
                    lentgth = 0;
                }
            }
        }

    }
}
