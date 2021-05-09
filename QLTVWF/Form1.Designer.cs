
namespace QLTVWF
{
     partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.DSDSbutton = new FontAwesome.Sharp.IconButton();
            this.DSHVbutton = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.MTA = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.FullScreen = new FontAwesome.Sharp.IconButton();
            this.exitbutton = new FontAwesome.Sharp.IconButton();
            this.ShadowBar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MTA)).BeginInit();
            this.ShadowBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(192)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.DSDSbutton);
            this.panel1.Controls.Add(this.DSHVbutton);
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(249)))), ((int)(((byte)(181)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 1030);
            this.panel1.TabIndex = 0;
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton6.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton6.IconSize = 50;
            this.iconButton6.Location = new System.Drawing.Point(0, 941);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(96, 89);
            this.iconButton6.TabIndex = 6;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // DSDSbutton
            // 
            this.DSDSbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DSDSbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DSDSbutton.FlatAppearance.BorderSize = 0;
            this.DSDSbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSDSbutton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DSDSbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.DSDSbutton.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.DSDSbutton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DSDSbutton.IconSize = 50;
            this.DSDSbutton.Location = new System.Drawing.Point(0, 471);
            this.DSDSbutton.Name = "DSDSbutton";
            this.DSDSbutton.Rotation = 0D;
            this.DSDSbutton.Size = new System.Drawing.Size(96, 89);
            this.DSDSbutton.TabIndex = 5;
            this.DSDSbutton.UseVisualStyleBackColor = true;
            this.DSDSbutton.Click += new System.EventHandler(this.DSDSbutton_Click);
            // 
            // DSHVbutton
            // 
            this.DSHVbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DSHVbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DSHVbutton.FlatAppearance.BorderSize = 0;
            this.DSHVbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DSHVbutton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DSHVbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.DSHVbutton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.DSHVbutton.IconColor = System.Drawing.Color.WhiteSmoke;
            this.DSHVbutton.IconSize = 60;
            this.DSHVbutton.Location = new System.Drawing.Point(0, 382);
            this.DSHVbutton.Name = "DSHVbutton";
            this.DSHVbutton.Rotation = 0D;
            this.DSHVbutton.Size = new System.Drawing.Size(96, 89);
            this.DSHVbutton.TabIndex = 1;
            this.DSHVbutton.UseVisualStyleBackColor = true;
            this.DSHVbutton.Click += new System.EventHandler(this.DSHVbutton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.MTA);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(96, 382);
            this.panelMenu.TabIndex = 0;
            // 
            // MTA
            // 
            this.MTA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MTA.Image = ((System.Drawing.Image)(resources.GetObject("MTA.Image")));
            this.MTA.Location = new System.Drawing.Point(7, 12);
            this.MTA.Name = "MTA";
            this.MTA.Size = new System.Drawing.Size(85, 84);
            this.MTA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MTA.TabIndex = 1;
            this.MTA.TabStop = false;
            this.MTA.Click += new System.EventHandler(this.MTA_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(249)))), ((int)(((byte)(181)))));
            this.panelDesktop.Location = new System.Drawing.Point(96, 96);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1822, 934);
            this.panelDesktop.TabIndex = 3;
            // 
            // FullScreen
            // 
            this.FullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullScreen.AutoSize = true;
            this.FullScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullScreen.FlatAppearance.BorderSize = 0;
            this.FullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.FullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.FullScreen.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.FullScreen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.FullScreen.IconSize = 25;
            this.FullScreen.Location = new System.Drawing.Point(1724, 19);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Rotation = 0D;
            this.FullScreen.Size = new System.Drawing.Size(31, 31);
            this.FullScreen.TabIndex = 1;
            this.FullScreen.UseVisualStyleBackColor = true;
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitbutton.AutoSize = true;
            this.exitbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exitbutton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.exitbutton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(49)))), ((int)(((byte)(1)))));
            this.exitbutton.IconSize = 25;
            this.exitbutton.Location = new System.Drawing.Point(1773, 19);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Rotation = 0D;
            this.exitbutton.Size = new System.Drawing.Size(31, 31);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // ShadowBar
            // 
            this.ShadowBar.Controls.Add(this.exitbutton);
            this.ShadowBar.Controls.Add(this.FullScreen);
            this.ShadowBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ShadowBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShadowBar.Location = new System.Drawing.Point(96, 0);
            this.ShadowBar.Name = "ShadowBar";
            this.ShadowBar.Size = new System.Drawing.Size(1822, 96);
            this.ShadowBar.TabIndex = 2;
            this.ShadowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenMove);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1918, 1030);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.ShadowBar);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(249)))), ((int)(((byte)(181)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 1000);
            this.Name = "Menu";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MTA)).EndInit();
            this.ShadowBar.ResumeLayout(false);
            this.ShadowBar.PerformLayout();
            this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel panel1;
          private FontAwesome.Sharp.IconButton DSHVbutton;
          private System.Windows.Forms.Panel panelMenu;
          private FontAwesome.Sharp.IconButton iconButton6;
          private FontAwesome.Sharp.IconButton DSDSbutton;
          private System.Windows.Forms.PictureBox MTA;
          private System.Windows.Forms.Panel panelDesktop;
          private FontAwesome.Sharp.IconButton FullScreen;
          private FontAwesome.Sharp.IconButton exitbutton;
          private System.Windows.Forms.Panel ShadowBar;
     }
}

