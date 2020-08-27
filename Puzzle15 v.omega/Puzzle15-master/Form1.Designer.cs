namespace Puzzle15
{
    partial class PuzzleArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleArea));
            this.animation = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.puzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingFrame = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.laebelrow = new System.Windows.Forms.Label();
            this.inputrow = new System.Windows.Forms.NumericUpDown();
            this.inputcollum = new System.Windows.Forms.NumericUpDown();
            this.exitsettings = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SettingFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputcollum)).BeginInit();
            this.SuspendLayout();
            // 
            // animation
            // 
            this.animation.Interval = 1;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puzzleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(584, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // puzzleToolStripMenuItem
            // 
            this.puzzleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.puzzleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.puzzleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.puzzleToolStripMenuItem.Name = "puzzleToolStripMenuItem";
            this.puzzleToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.puzzleToolStripMenuItem.Text = "Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // SettingFrame
            // 
            this.SettingFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingFrame.Controls.Add(this.button1);
            this.SettingFrame.Controls.Add(this.label1);
            this.SettingFrame.Controls.Add(this.laebelrow);
            this.SettingFrame.Controls.Add(this.inputrow);
            this.SettingFrame.Controls.Add(this.inputcollum);
            this.SettingFrame.Controls.Add(this.exitsettings);
            this.SettingFrame.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.SettingFrame.Location = new System.Drawing.Point(0, 27);
            this.SettingFrame.Name = "SettingFrame";
            this.SettingFrame.Size = new System.Drawing.Size(175, 101);
            this.SettingFrame.TabIndex = 3;
            this.SettingFrame.TabStop = false;
            this.SettingFrame.Text = "Settings";
            this.SettingFrame.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(110, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "collums :";
            // 
            // laebelrow
            // 
            this.laebelrow.AutoSize = true;
            this.laebelrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.laebelrow.Location = new System.Drawing.Point(6, 19);
            this.laebelrow.Name = "laebelrow";
            this.laebelrow.Size = new System.Drawing.Size(39, 15);
            this.laebelrow.TabIndex = 4;
            this.laebelrow.Text = "rows :";
            // 
            // inputrow
            // 
            this.inputrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputrow.ForeColor = System.Drawing.Color.Black;
            this.inputrow.Location = new System.Drawing.Point(68, 19);
            this.inputrow.Name = "inputrow";
            this.inputrow.ReadOnly = true;
            this.inputrow.Size = new System.Drawing.Size(41, 20);
            this.inputrow.TabIndex = 3;
            this.inputrow.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // inputcollum
            // 
            this.inputcollum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputcollum.Location = new System.Drawing.Point(68, 45);
            this.inputcollum.Name = "inputcollum";
            this.inputcollum.ReadOnly = true;
            this.inputcollum.Size = new System.Drawing.Size(41, 20);
            this.inputcollum.TabIndex = 2;
            this.inputcollum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // exitsettings
            // 
            this.exitsettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitsettings.BackgroundImage")));
            this.exitsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitsettings.Location = new System.Drawing.Point(156, 9);
            this.exitsettings.Name = "exitsettings";
            this.exitsettings.Size = new System.Drawing.Size(17, 17);
            this.exitsettings.TabIndex = 1;
            this.exitsettings.UseVisualStyleBackColor = true;
            this.exitsettings.Click += new System.EventHandler(this.exitsettings_Click);
            this.exitsettings.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.exitsettings.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // PuzzleArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 557);
            this.Controls.Add(this.SettingFrame);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Name = "PuzzleArea";
            this.Text = "Puzzle15";
            this.ResizeBegin += new System.EventHandler(this.PuzzleArea_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.PuzzleArea_ResizeEnd);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.SettingFrame.ResumeLayout(false);
            this.SettingFrame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputcollum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer animation;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem puzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox SettingFrame;
        private System.Windows.Forms.Button exitsettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laebelrow;
        private System.Windows.Forms.NumericUpDown inputrow;
        private System.Windows.Forms.NumericUpDown inputcollum;
        private System.Windows.Forms.Button button1;
    }
}

