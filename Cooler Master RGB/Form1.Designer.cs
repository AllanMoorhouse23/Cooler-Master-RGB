namespace Cooler_Master_RGB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.buttonEnable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEffects = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrimaryColor = new System.Windows.Forms.Panel();
            this.panelSecondary = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSpeed = new System.Windows.Forms.Button();
            this.buttonColors = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // buttonEnable
            // 
            this.buttonEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.buttonEnable.FlatAppearance.BorderSize = 0;
            this.buttonEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnable.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnable.ForeColor = System.Drawing.Color.White;
            this.buttonEnable.Location = new System.Drawing.Point(7, 45);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(119, 38);
            this.buttonEnable.TabIndex = 1;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = false;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "App Control";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonEnable);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 92);
            this.panel1.TabIndex = 3;
            // 
            // comboBoxEffects
            // 
            this.comboBoxEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.comboBoxEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEffects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEffects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEffects.ForeColor = System.Drawing.Color.White;
            this.comboBoxEffects.FormattingEnabled = true;
            this.comboBoxEffects.Items.AddRange(new object[] {
            "Line By Line",
            "Alternating Lines",
            "Snake Line By Line",
            "Spiral",
            "Wipe",
            "Breathing",
            "Random",
            "Random Lines",
            "Random Squares",
            "Random Selected Line",
            "Ball",
            "Color Cycle",
            "Vertical Rainbow",
            "Rainbow",
            "Keypress"});
            this.comboBoxEffects.Location = new System.Drawing.Point(19, 52);
            this.comboBoxEffects.Name = "comboBoxEffects";
            this.comboBoxEffects.Size = new System.Drawing.Size(160, 26);
            this.comboBoxEffects.TabIndex = 4;
            this.comboBoxEffects.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxEffects);
            this.panel2.Location = new System.Drawing.Point(146, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 92);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(68, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Effect";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 25;
            this.trackBar1.Location = new System.Drawing.Point(10, 17);
            this.trackBar1.Maximum = 750;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(316, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 25;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Location = new System.Drawing.Point(7, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 80);
            this.panel3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(284, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "750ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(7, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "1ms";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // panelPrimaryColor
            // 
            this.panelPrimaryColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrimaryColor.Location = new System.Drawing.Point(53, 31);
            this.panelPrimaryColor.Name = "panelPrimaryColor";
            this.panelPrimaryColor.Size = new System.Drawing.Size(82, 34);
            this.panelPrimaryColor.TabIndex = 10;
            this.panelPrimaryColor.Click += new System.EventHandler(this.panelPrimaryColor_Click);
            // 
            // panelSecondary
            // 
            this.panelSecondary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSecondary.Location = new System.Drawing.Point(203, 31);
            this.panelSecondary.Name = "panelSecondary";
            this.panelSecondary.Size = new System.Drawing.Size(82, 34);
            this.panelSecondary.TabIndex = 12;
            this.panelSecondary.Click += new System.EventHandler(this.panelSecondary_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(50, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Primary Color:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(189, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Secondary Color:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.panelPrimaryColor);
            this.panel4.Controls.Add(this.panelSecondary);
            this.panel4.Location = new System.Drawing.Point(7, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 80);
            this.panel4.TabIndex = 15;
            this.panel4.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RGB Control Panel";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // buttonHide
            // 
            this.buttonHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.buttonHide.FlatAppearance.BorderSize = 0;
            this.buttonHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHide.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHide.ForeColor = System.Drawing.Color.White;
            this.buttonHide.Location = new System.Drawing.Point(87, 8);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(119, 38);
            this.buttonHide.TabIndex = 16;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = false;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(212, 8);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(119, 38);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.buttonExit);
            this.panel5.Controls.Add(this.buttonHide);
            this.panel5.Location = new System.Drawing.Point(7, 232);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 57);
            this.panel5.TabIndex = 11;
            // 
            // buttonSpeed
            // 
            this.buttonSpeed.BackColor = System.Drawing.Color.White;
            this.buttonSpeed.FlatAppearance.BorderSize = 0;
            this.buttonSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonSpeed.Location = new System.Drawing.Point(7, 108);
            this.buttonSpeed.Name = "buttonSpeed";
            this.buttonSpeed.Size = new System.Drawing.Size(170, 38);
            this.buttonSpeed.TabIndex = 18;
            this.buttonSpeed.Text = "Speed";
            this.buttonSpeed.UseVisualStyleBackColor = false;
            this.buttonSpeed.Click += new System.EventHandler(this.buttonSpeed_Click);
            // 
            // buttonColors
            // 
            this.buttonColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.buttonColors.FlatAppearance.BorderSize = 0;
            this.buttonColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColors.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonColors.ForeColor = System.Drawing.Color.White;
            this.buttonColors.Location = new System.Drawing.Point(176, 108);
            this.buttonColors.Name = "buttonColors";
            this.buttonColors.Size = new System.Drawing.Size(170, 38);
            this.buttonColors.TabIndex = 19;
            this.buttonColors.Text = "Colors";
            this.buttonColors.UseVisualStyleBackColor = false;
            this.buttonColors.Click += new System.EventHandler(this.buttonColors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(353, 296);
            this.Controls.Add(this.buttonColors);
            this.Controls.Add(this.buttonSpeed);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1540, 630);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Control Panel v1.0.01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxEffects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPrimaryColor;
        private System.Windows.Forms.Panel panelSecondary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSpeed;
        private System.Windows.Forms.Button buttonColors;
    }
}

