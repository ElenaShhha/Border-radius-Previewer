namespace Border_radius_Previewer
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lbBottomLeftY = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbBottomLeftY = new System.Windows.Forms.TextBox();
            this.BtCopy = new System.Windows.Forms.Button();
            this.lbBottomLeftX = new System.Windows.Forms.Label();
            this.TbBottomLeftX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbBottomRightY = new System.Windows.Forms.Label();
            this.TbBottomRightY = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bt_Update = new System.Windows.Forms.Button();
            this.lbBottomRightX = new System.Windows.Forms.Label();
            this.TbTopRightY = new System.Windows.Forms.TextBox();
            this.TbBottomRightX = new System.Windows.Forms.TextBox();
            this.lbTopRightY = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbTopRightX = new System.Windows.Forms.Label();
            this.TbTopRightX = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LbTopLeftY = new System.Windows.Forms.Label();
            this.TbTopLeftY = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LbTopLeftX = new System.Windows.Forms.Label();
            this.TbTopLeftX = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.BackColor = System.Drawing.Color.Maroon;
            this.MainPanel.Location = new System.Drawing.Point(128, 7);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(200, 200);
            this.MainPanel.TabIndex = 33;
            // 
            // lbBottomLeftY
            // 
            this.lbBottomLeftY.AutoSize = true;
            this.lbBottomLeftY.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbBottomLeftY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBottomLeftY.Location = new System.Drawing.Point(104, 0);
            this.lbBottomLeftY.Name = "lbBottomLeftY";
            this.lbBottomLeftY.Size = new System.Drawing.Size(111, 20);
            this.lbBottomLeftY.TabIndex = 7;
            this.lbBottomLeftY.Text = "bottom-left-y";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 218);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(451, 27);
            this.panel10.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter your parameters from 1 to 99:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbBottomLeftY);
            this.panel1.Controls.Add(this.TbBottomLeftY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 25);
            this.panel1.TabIndex = 34;
            // 
            // TbBottomLeftY
            // 
            this.TbBottomLeftY.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbBottomLeftY.Location = new System.Drawing.Point(215, 0);
            this.TbBottomLeftY.Name = "TbBottomLeftY";
            this.TbBottomLeftY.Size = new System.Drawing.Size(236, 20);
            this.TbBottomLeftY.TabIndex = 1;
            this.TbBottomLeftY.Text = "10";
            this.TbBottomLeftY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // BtCopy
            // 
            this.BtCopy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtCopy.Location = new System.Drawing.Point(0, 468);
            this.BtCopy.Name = "BtCopy";
            this.BtCopy.Size = new System.Drawing.Size(451, 23);
            this.BtCopy.TabIndex = 43;
            this.BtCopy.Text = "Copy";
            this.BtCopy.UseVisualStyleBackColor = true;
            this.BtCopy.Click += new System.EventHandler(this.BtCopy_Click);
            // 
            // lbBottomLeftX
            // 
            this.lbBottomLeftX.AutoSize = true;
            this.lbBottomLeftX.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbBottomLeftX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBottomLeftX.Location = new System.Drawing.Point(104, 0);
            this.lbBottomLeftX.Name = "lbBottomLeftX";
            this.lbBottomLeftX.Size = new System.Drawing.Size(111, 20);
            this.lbBottomLeftX.TabIndex = 6;
            this.lbBottomLeftX.Text = "bottom-left-x";
            // 
            // TbBottomLeftX
            // 
            this.TbBottomLeftX.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbBottomLeftX.Location = new System.Drawing.Point(215, 0);
            this.TbBottomLeftX.Name = "TbBottomLeftX";
            this.TbBottomLeftX.Size = new System.Drawing.Size(236, 20);
            this.TbBottomLeftX.TabIndex = 2;
            this.TbBottomLeftX.Text = "10";
            this.TbBottomLeftX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbBottomLeftX);
            this.panel2.Controls.Add(this.TbBottomLeftX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 25);
            this.panel2.TabIndex = 36;
            // 
            // lbBottomRightY
            // 
            this.lbBottomRightY.AutoSize = true;
            this.lbBottomRightY.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbBottomRightY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBottomRightY.Location = new System.Drawing.Point(94, 0);
            this.lbBottomRightY.Name = "lbBottomRightY";
            this.lbBottomRightY.Size = new System.Drawing.Size(121, 20);
            this.lbBottomRightY.TabIndex = 5;
            this.lbBottomRightY.Text = "bottom-right-y";
            // 
            // TbBottomRightY
            // 
            this.TbBottomRightY.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbBottomRightY.Location = new System.Drawing.Point(215, 0);
            this.TbBottomRightY.Name = "TbBottomRightY";
            this.TbBottomRightY.Size = new System.Drawing.Size(236, 20);
            this.TbBottomRightY.TabIndex = 3;
            this.TbBottomRightY.Text = "10";
            this.TbBottomRightY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbBottomRightY);
            this.panel3.Controls.Add(this.TbBottomRightY);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 25);
            this.panel3.TabIndex = 37;
            // 
            // Bt_Update
            // 
            this.Bt_Update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bt_Update.Location = new System.Drawing.Point(0, 445);
            this.Bt_Update.Name = "Bt_Update";
            this.Bt_Update.Size = new System.Drawing.Size(451, 23);
            this.Bt_Update.TabIndex = 35;
            this.Bt_Update.Text = "Update";
            this.Bt_Update.UseVisualStyleBackColor = true;
            this.Bt_Update.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // lbBottomRightX
            // 
            this.lbBottomRightX.AutoSize = true;
            this.lbBottomRightX.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbBottomRightX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBottomRightX.Location = new System.Drawing.Point(94, 0);
            this.lbBottomRightX.Name = "lbBottomRightX";
            this.lbBottomRightX.Size = new System.Drawing.Size(121, 20);
            this.lbBottomRightX.TabIndex = 4;
            this.lbBottomRightX.Text = "bottom-right-x";
            // 
            // TbTopRightY
            // 
            this.TbTopRightY.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbTopRightY.Location = new System.Drawing.Point(215, 0);
            this.TbTopRightY.Name = "TbTopRightY";
            this.TbTopRightY.Size = new System.Drawing.Size(236, 20);
            this.TbTopRightY.TabIndex = 5;
            this.TbTopRightY.Text = "10";
            this.TbTopRightY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // TbBottomRightX
            // 
            this.TbBottomRightX.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbBottomRightX.Location = new System.Drawing.Point(215, 0);
            this.TbBottomRightX.Name = "TbBottomRightX";
            this.TbBottomRightX.Size = new System.Drawing.Size(236, 20);
            this.TbBottomRightX.TabIndex = 4;
            this.TbBottomRightX.Text = "10";
            this.TbBottomRightX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // lbTopRightY
            // 
            this.lbTopRightY.AutoSize = true;
            this.lbTopRightY.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTopRightY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTopRightY.Location = new System.Drawing.Point(124, 0);
            this.lbTopRightY.Name = "lbTopRightY";
            this.lbTopRightY.Size = new System.Drawing.Size(91, 20);
            this.lbTopRightY.TabIndex = 3;
            this.lbTopRightY.Text = "top-right-y";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbTopRightY);
            this.panel6.Controls.Add(this.TbTopRightY);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 320);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(451, 25);
            this.panel6.TabIndex = 39;
            // 
            // lbTopRightX
            // 
            this.lbTopRightX.AutoSize = true;
            this.lbTopRightX.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTopRightX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTopRightX.Location = new System.Drawing.Point(124, 0);
            this.lbTopRightX.Name = "lbTopRightX";
            this.lbTopRightX.Size = new System.Drawing.Size(91, 20);
            this.lbTopRightX.TabIndex = 2;
            this.lbTopRightX.Text = "top-right-x";
            // 
            // TbTopRightX
            // 
            this.TbTopRightX.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbTopRightX.Location = new System.Drawing.Point(215, 0);
            this.TbTopRightX.Name = "TbTopRightX";
            this.TbTopRightX.Size = new System.Drawing.Size(236, 20);
            this.TbTopRightX.TabIndex = 6;
            this.TbTopRightX.Text = "10";
            this.TbTopRightX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbTopRightX);
            this.panel7.Controls.Add(this.TbTopRightX);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 345);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(451, 25);
            this.panel7.TabIndex = 40;
            // 
            // LbTopLeftY
            // 
            this.LbTopLeftY.AutoSize = true;
            this.LbTopLeftY.Dock = System.Windows.Forms.DockStyle.Right;
            this.LbTopLeftY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTopLeftY.Location = new System.Drawing.Point(134, 0);
            this.LbTopLeftY.Name = "LbTopLeftY";
            this.LbTopLeftY.Size = new System.Drawing.Size(81, 20);
            this.LbTopLeftY.TabIndex = 1;
            this.LbTopLeftY.Text = "top-left-y";
            // 
            // TbTopLeftY
            // 
            this.TbTopLeftY.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbTopLeftY.Location = new System.Drawing.Point(215, 0);
            this.TbTopLeftY.Name = "TbTopLeftY";
            this.TbTopLeftY.Size = new System.Drawing.Size(236, 20);
            this.TbTopLeftY.TabIndex = 7;
            this.TbTopLeftY.Text = "10";
            this.TbTopLeftY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.LbTopLeftY);
            this.panel8.Controls.Add(this.TbTopLeftY);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 370);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(451, 25);
            this.panel8.TabIndex = 41;
            // 
            // LbTopLeftX
            // 
            this.LbTopLeftX.AutoSize = true;
            this.LbTopLeftX.Dock = System.Windows.Forms.DockStyle.Right;
            this.LbTopLeftX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTopLeftX.Location = new System.Drawing.Point(134, 0);
            this.LbTopLeftX.Name = "LbTopLeftX";
            this.LbTopLeftX.Size = new System.Drawing.Size(81, 20);
            this.LbTopLeftX.TabIndex = 0;
            this.LbTopLeftX.Text = "top-left-x";
            // 
            // TbTopLeftX
            // 
            this.TbTopLeftX.Dock = System.Windows.Forms.DockStyle.Right;
            this.TbTopLeftX.Location = new System.Drawing.Point(215, 0);
            this.TbTopLeftX.Name = "TbTopLeftX";
            this.TbTopLeftX.Size = new System.Drawing.Size(236, 20);
            this.TbTopLeftX.TabIndex = 8;
            this.TbTopLeftX.Text = "10";
            this.TbTopLeftX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTopLeftX_KeyPress);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.LbTopLeftX);
            this.panel9.Controls.Add(this.TbTopLeftX);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 395);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(451, 25);
            this.panel9.TabIndex = 42;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbBottomRightX);
            this.panel5.Controls.Add(this.TbBottomRightX);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(451, 25);
            this.panel5.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 491);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Bt_Update);
            this.Controls.Add(this.BtCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Border-radius Previewer";
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lbBottomLeftY;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TbBottomLeftY;
        private System.Windows.Forms.Button BtCopy;
        private System.Windows.Forms.Label lbBottomLeftX;
        private System.Windows.Forms.TextBox TbBottomLeftX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbBottomRightY;
        private System.Windows.Forms.TextBox TbBottomRightY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Bt_Update;
        private System.Windows.Forms.Label lbBottomRightX;
        private System.Windows.Forms.TextBox TbTopRightY;
        private System.Windows.Forms.TextBox TbBottomRightX;
        private System.Windows.Forms.Label lbTopRightY;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbTopRightX;
        private System.Windows.Forms.TextBox TbTopRightX;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LbTopLeftY;
        private System.Windows.Forms.TextBox TbTopLeftY;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label LbTopLeftX;
        private System.Windows.Forms.TextBox TbTopLeftX;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
    }
}

