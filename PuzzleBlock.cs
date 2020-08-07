using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Puzzle15
{
    class PuzzleBlock : Button
    {

        public PuzzleBlock(int collum, int row, int formwidth, int count, int collumcount, int rowcount, int formheight)
        {
            InitializePuzzleBlock(collum, row, formwidth, count, collumcount, rowcount, formheight);
        }
        private void InitializePuzzleBlock(int collum, int row, int formwidth, int count, int collumcount, int rowcount, int formheight)
        {
            
            //properties-------------------------------------------------------------------------------------------------------------------------------
            this.BackColor = Color.White;
            this.Name = $"Button{count}";
            this.Text = count.ToString();
            this.Width = this.Height = 100;
            if (count == collumcount*rowcount) { this.Text = null; this.Name = "Empty"; this.FlatStyle = FlatStyle.Flat; this.BackColor = Color.Black; }
            int spacebetween = 5;
            //------------------------------------------------------------------------------------------------------------------------------------------
            //center buttons locations...
            UpdateLocation(collum, row, formwidth, count, collumcount, rowcount, formheight, spacebetween);
            //change button size if there is need to do that...
            AutoSizeCheck(collum, row, formwidth, count, collumcount, rowcount, formheight, spacebetween);
        }
        private void UpdateLocation(int collum, int row, int formwidth, int count, int collumcount, int rowcount, int formheight, int spacebetween)
        {
            int spacefromtop = (formheight - ((this.Width * rowcount) + (spacebetween * (rowcount - 1)))) / 2;
            int spacefromleft = (formwidth - ((this.Width * collumcount) + (spacebetween * (collumcount - 1)))) / 2;
            this.Left = collum * (this.Width + spacebetween) + spacefromleft;
            this.Top = row * (this.Width + spacebetween) + spacefromtop;
        }
        private void AutoSizeCheck(int collum, int row, int formwidth, int count, int collumcount, int rowcount, int formheight, int spacebetween)
        {
            int rowlength = ((this.Width * collumcount) + (spacebetween * (collumcount - 1)));
            int collumlength = ((this.Width * rowcount) + (spacebetween * (rowcount - 1)));
            int autosizesidespace = 10;
            for(int i = 1; i < 3; i++)
            {
                int x = 0;
                int y = 0;
                int z = 0;
                if (i == 1) { x = collumcount; y = formwidth; z = rowlength; }
                else if (i == 2) { x = rowcount; y = formheight; z = collumlength; }
                if (z > y)
                {
                    if (y - (x * this.Width) < 0)
                    {
                        int avrgdifference = (formwidth - (x * this.Width)) / x;

                        this.Width += avrgdifference;
                        //this.Width -= (autosizesidespace / (new[] { rowcount, collumcount }).Max());
                        this.Height = this.Width;
                        spacebetween = 0;
                        UpdateLocation(collum, row, formwidth, count, collumcount, rowcount, formheight, spacebetween);
                    }
                    else
                    {
                        spacebetween = 0;
                        UpdateLocation(collum, row, formwidth, count, collumcount, rowcount, formheight, spacebetween);
                    }
                }
            }
        }
    }
}

