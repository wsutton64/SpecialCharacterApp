namespace SpecialCharacterApp
{
    partial class Form1
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
            this.clickcharLabel = new System.Windows.Forms.Label();
            this.no_cap_ae = new System.Windows.Forms.Label();
            this.no_low_ae = new System.Windows.Forms.Label();
            this.no_cap_o = new System.Windows.Forms.Label();
            this.no_low_o = new System.Windows.Forms.Label();
            this.no_cap_a = new System.Windows.Forms.Label();
            this.no_low_a = new System.Windows.Forms.Label();
            this.de_low_a = new System.Windows.Forms.Label();
            this.de_cap_a = new System.Windows.Forms.Label();
            this.de_low_o = new System.Windows.Forms.Label();
            this.de_cap_o = new System.Windows.Forms.Label();
            this.de_low_u = new System.Windows.Forms.Label();
            this.de_cap_u = new System.Windows.Forms.Label();
            this.de_low_s = new System.Windows.Forms.Label();
            this.de_cap_s = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // clickcharLabel
            // 
            this.clickcharLabel.AutoSize = true;
            this.clickcharLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickcharLabel.Location = new System.Drawing.Point(95, 9);
            this.clickcharLabel.Name = "clickcharLabel";
            this.clickcharLabel.Size = new System.Drawing.Size(281, 20);
            this.clickcharLabel.TabIndex = 0;
            this.clickcharLabel.Text = "Click character to copy to the clipboard";
            // 
            // no_cap_ae
            // 
            this.no_cap_ae.AutoSize = true;
            this.no_cap_ae.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_cap_ae.Location = new System.Drawing.Point(66, 67);
            this.no_cap_ae.Name = "no_cap_ae";
            this.no_cap_ae.Size = new System.Drawing.Size(41, 31);
            this.no_cap_ae.TabIndex = 1;
            this.no_cap_ae.Text = "Æ";
            this.toolTip1.SetToolTip(this.no_cap_ae, "Click to copy");
            this.no_cap_ae.Click += new System.EventHandler(this.charClickEvent);
            // 
            // no_low_ae
            // 
            this.no_low_ae.AutoSize = true;
            this.no_low_ae.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_low_ae.Location = new System.Drawing.Point(113, 67);
            this.no_low_ae.Name = "no_low_ae";
            this.no_low_ae.Size = new System.Drawing.Size(38, 31);
            this.no_low_ae.TabIndex = 2;
            this.no_low_ae.Text = "æ";
            this.toolTip1.SetToolTip(this.no_low_ae, "Click to copy");
            this.no_low_ae.Click += new System.EventHandler(this.charClickEvent);
            // 
            // no_cap_o
            // 
            this.no_cap_o.AutoSize = true;
            this.no_cap_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_cap_o.Location = new System.Drawing.Point(199, 67);
            this.no_cap_o.Name = "no_cap_o";
            this.no_cap_o.Size = new System.Drawing.Size(35, 31);
            this.no_cap_o.TabIndex = 3;
            this.no_cap_o.Text = "Ø";
            this.toolTip1.SetToolTip(this.no_cap_o, "Click to copy");
            this.no_cap_o.Click += new System.EventHandler(this.charClickEvent);
            // 
            // no_low_o
            // 
            this.no_low_o.AutoSize = true;
            this.no_low_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_low_o.Location = new System.Drawing.Point(246, 67);
            this.no_low_o.Name = "no_low_o";
            this.no_low_o.Size = new System.Drawing.Size(29, 31);
            this.no_low_o.TabIndex = 4;
            this.no_low_o.Text = "ø";
            this.toolTip1.SetToolTip(this.no_low_o, "Click to copy");
            this.no_low_o.Click += new System.EventHandler(this.charClickEvent);
            // 
            // no_cap_a
            // 
            this.no_cap_a.AutoSize = true;
            this.no_cap_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_cap_a.Location = new System.Drawing.Point(329, 67);
            this.no_cap_a.Name = "no_cap_a";
            this.no_cap_a.Size = new System.Drawing.Size(32, 31);
            this.no_cap_a.TabIndex = 5;
            this.no_cap_a.Text = "Å";
            this.toolTip1.SetToolTip(this.no_cap_a, "Click to copy");
            this.no_cap_a.Click += new System.EventHandler(this.charClickEvent);
            // 
            // no_low_a
            // 
            this.no_low_a.AutoSize = true;
            this.no_low_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_low_a.Location = new System.Drawing.Point(376, 67);
            this.no_low_a.Name = "no_low_a";
            this.no_low_a.Size = new System.Drawing.Size(29, 31);
            this.no_low_a.TabIndex = 6;
            this.no_low_a.Text = "å";
            this.toolTip1.SetToolTip(this.no_low_a, "Click to copy");
            this.no_low_a.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_low_a
            // 
            this.de_low_a.AutoSize = true;
            this.de_low_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_low_a.Location = new System.Drawing.Point(113, 150);
            this.de_low_a.Name = "de_low_a";
            this.de_low_a.Size = new System.Drawing.Size(29, 31);
            this.de_low_a.TabIndex = 8;
            this.de_low_a.Text = "ä";
            this.toolTip1.SetToolTip(this.de_low_a, "Click to copy");
            this.de_low_a.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_cap_a
            // 
            this.de_cap_a.AutoSize = true;
            this.de_cap_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_cap_a.Location = new System.Drawing.Point(66, 150);
            this.de_cap_a.Name = "de_cap_a";
            this.de_cap_a.Size = new System.Drawing.Size(32, 31);
            this.de_cap_a.TabIndex = 7;
            this.de_cap_a.Text = "Ä";
            this.toolTip1.SetToolTip(this.de_cap_a, "Click to copy");
            this.de_cap_a.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_low_o
            // 
            this.de_low_o.AutoSize = true;
            this.de_low_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_low_o.Location = new System.Drawing.Point(246, 150);
            this.de_low_o.Name = "de_low_o";
            this.de_low_o.Size = new System.Drawing.Size(29, 31);
            this.de_low_o.TabIndex = 10;
            this.de_low_o.Text = "ö";
            this.toolTip1.SetToolTip(this.de_low_o, "Click to copy");
            this.de_low_o.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_cap_o
            // 
            this.de_cap_o.AutoSize = true;
            this.de_cap_o.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_cap_o.Location = new System.Drawing.Point(199, 150);
            this.de_cap_o.Name = "de_cap_o";
            this.de_cap_o.Size = new System.Drawing.Size(35, 31);
            this.de_cap_o.TabIndex = 9;
            this.de_cap_o.Text = "Ö";
            this.toolTip1.SetToolTip(this.de_cap_o, "Click to copy");
            this.de_cap_o.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_low_u
            // 
            this.de_low_u.AutoSize = true;
            this.de_low_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_low_u.Location = new System.Drawing.Point(376, 150);
            this.de_low_u.Name = "de_low_u";
            this.de_low_u.Size = new System.Drawing.Size(29, 31);
            this.de_low_u.TabIndex = 12;
            this.de_low_u.Text = "ü";
            this.toolTip1.SetToolTip(this.de_low_u, "Click to copy");
            this.de_low_u.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_cap_u
            // 
            this.de_cap_u.AutoSize = true;
            this.de_cap_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_cap_u.Location = new System.Drawing.Point(329, 150);
            this.de_cap_u.Name = "de_cap_u";
            this.de_cap_u.Size = new System.Drawing.Size(34, 31);
            this.de_cap_u.TabIndex = 11;
            this.de_cap_u.Text = "Ü";
            this.toolTip1.SetToolTip(this.de_cap_u, "Click to copy");
            this.de_cap_u.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_low_s
            // 
            this.de_low_s.AutoSize = true;
            this.de_low_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_low_s.Location = new System.Drawing.Point(113, 228);
            this.de_low_s.Name = "de_low_s";
            this.de_low_s.Size = new System.Drawing.Size(31, 31);
            this.de_low_s.TabIndex = 14;
            this.de_low_s.Text = "ß";
            this.toolTip1.SetToolTip(this.de_low_s, "Click to copy");
            this.de_low_s.Click += new System.EventHandler(this.charClickEvent);
            // 
            // de_cap_s
            // 
            this.de_cap_s.AutoSize = true;
            this.de_cap_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_cap_s.Location = new System.Drawing.Point(66, 228);
            this.de_cap_s.Name = "de_cap_s";
            this.de_cap_s.Size = new System.Drawing.Size(31, 31);
            this.de_cap_s.TabIndex = 13;
            this.de_cap_s.Text = "ẞ";
            this.toolTip1.SetToolTip(this.de_cap_s, "Click to copy");
            this.de_cap_s.Click += new System.EventHandler(this.charClickEvent);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(444, 289);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 15;
            this.versionLabel.Text = "v1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.de_low_s);
            this.Controls.Add(this.de_cap_s);
            this.Controls.Add(this.de_low_u);
            this.Controls.Add(this.de_cap_u);
            this.Controls.Add(this.de_low_o);
            this.Controls.Add(this.de_cap_o);
            this.Controls.Add(this.de_low_a);
            this.Controls.Add(this.de_cap_a);
            this.Controls.Add(this.no_low_a);
            this.Controls.Add(this.no_cap_a);
            this.Controls.Add(this.no_low_o);
            this.Controls.Add(this.no_cap_o);
            this.Controls.Add(this.no_low_ae);
            this.Controls.Add(this.no_cap_ae);
            this.Controls.Add(this.clickcharLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "Special Character Copier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickcharLabel;
        private System.Windows.Forms.Label no_cap_ae;
        private System.Windows.Forms.Label no_low_ae;
        private System.Windows.Forms.Label no_cap_o;
        private System.Windows.Forms.Label no_low_o;
        private System.Windows.Forms.Label no_cap_a;
        private System.Windows.Forms.Label no_low_a;
        private System.Windows.Forms.Label de_low_a;
        private System.Windows.Forms.Label de_cap_a;
        private System.Windows.Forms.Label de_low_o;
        private System.Windows.Forms.Label de_cap_o;
        private System.Windows.Forms.Label de_low_u;
        private System.Windows.Forms.Label de_cap_u;
        private System.Windows.Forms.Label de_low_s;
        private System.Windows.Forms.Label de_cap_s;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

