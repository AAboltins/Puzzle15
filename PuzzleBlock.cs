using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Puzzle15
{
    class PuzzleBlock : Button
    {
        static int top = 0;
        static int left = 0;
        int space = 10;
        int spaceleft = 30;
        int spacetop = 40;
        public PuzzleBlock(int i)
        {
            InitializePuzzleBlock(i);
        }
        private void InitializePuzzleBlock(int i)
        {
            
            this.BackColor = Color.White;
            this.Name = $"Button{i}";
            this.Text = i.ToString();

            this.Width = this.Height = 100;
            this.Left = left * (this.Width + space) + spaceleft;
            left++;
            this.Top = top * (this.Width + space) + spacetop;
            if (left == 3)
            {
                top++;
                left = 0;
            }
            if (i == 16) { this.Name = "Empty"; this.Text = null; this.BackColor = Color.Black; top = 1; left = 0; this.FlatStyle = FlatStyle.Flat; }
        }
    }
}

