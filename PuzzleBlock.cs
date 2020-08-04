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
        public PuzzleBlock(int i, int formwidth)
        {

            InitializePuzzleBlock(i,formwidth);
        }
        private void InitializePuzzleBlock(int i, int formwidth)
        {
            
            this.BackColor = Color.White;
            this.Name = $"Button{i}";
            this.Text = i.ToString();

            this.Width = this.Height = 100;
            int spacebetween = 5;
            int spacefromside = (formwidth-(this.Width*4)-(spacebetween*3))/2;
            this.Left = left * (this.Width + spacebetween) + spacefromside;
            this.Top = top * (this.Width + spacebetween) + spacefromside;

            if (left == 3){ top++; left = 0;}
            else{left++;}
            if (i == 16) { this.Name = "Empty"; this.Text = null; this.BackColor = Color.Black; top = 0; left = 0; this.FlatStyle = FlatStyle.Flat; }
        }
    }
}

