using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Puzzle15
{

    class
        PuzzleBlock : Button
    {
        public static int spacebetween { get; set; }
        public int space = spacebetween;
        public PuzzleBlock(int collum, int row, int formwidth, int collumcount, int rowcount, int formheight, Button allbuttons, bool swap)
        {
            InitializePuzzleBlock(collum, row, formwidth, collumcount, rowcount, formheight, allbuttons, swap);
        }
        private void InitializePuzzleBlock(int collum, int row, int formwidth, int collumcount, int rowcount, int formheight, Button allbuttons, bool swap)
        {
            //if resizing, not adding new buttons, but using all ready existing ones...
            if (allbuttons == null) { allbuttons = this; }
            //properties-------------------------------------------------------------------------------------------------------------------------------
            allbuttons.Width = allbuttons.Height = 100;
            allbuttons.BackColor = Color.White;
            if (swap == false) { spacebetween = 0; }
            //------------------------------------------------------------------------------------------------------------------------------------------
            //center buttons locations...
            UpdateLocation(collum, row, formwidth, collumcount, rowcount, formheight, allbuttons);
            //change button size if there is need to do that...
            AutoSizeCheck(collum, row, formwidth, collumcount, rowcount, formheight, allbuttons);

        }
        private void UpdateLocation(int collum, int row, int formwidth, int collumcount, int rowcount, int formheight, Button allbuttons)
        {
            int spacefromtop = (formheight - ((allbuttons.Width * rowcount) + (spacebetween * (rowcount - 1)))) / 2;
            int spacefromleft = (formwidth - ((allbuttons.Width * collumcount) + (spacebetween * (collumcount - 1)))) / 2;
            allbuttons.Left = collum * (allbuttons.Width + spacebetween) + spacefromleft;
            allbuttons.Top = row * (allbuttons.Width + spacebetween) + spacefromtop + 24;
        }
        private void AutoSizeCheck(int collum, int row, int formwidth, int collumcount, int rowcount, int formheight, Button allbuttons)
        {
            int rowlength = ((allbuttons.Width * collumcount) + (spacebetween * (collumcount - 1)));
            int collumlength = ((allbuttons.Width * rowcount) + (spacebetween * (rowcount - 1)));
            int autosizesidespace = 15;
            for (int i = 1; i < 3; i++)
            {
                int x = 0; int y = 0; int z = 0;
                if (i == 1) { x = collumcount; y = formwidth; z = rowlength; }
                else if (i == 2) { x = rowcount; y = formheight; z = collumlength; }
                if (z > y)
                {
                    if (y - (x * allbuttons.Width) < 0)
                    {
                        int avrgdifference = (y - (x * allbuttons.Width)) / x;

                        allbuttons.Width += avrgdifference;
                        allbuttons.Width -= (autosizesidespace / (new[] { rowcount, collumcount }).Max());
                        allbuttons.Height = allbuttons.Width;
                        spacebetween = 0;
                        UpdateLocation(collum, row, formwidth, collumcount, rowcount, formheight, allbuttons);
                    }
                    else
                    {
                        spacebetween = 0;
                        UpdateLocation(collum, row, formwidth, collumcount, rowcount, formheight, allbuttons);
                    }
                }
            }
        }

    }
}