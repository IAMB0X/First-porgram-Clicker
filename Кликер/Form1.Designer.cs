
namespace Кликер
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Upgrades = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.upgredee3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.upgredee2 = new System.Windows.Forms.Label();
            this.Cheat = new System.Windows.Forms.TextBox();
            this.upgradee1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Accept = new System.Windows.Forms.Button();
            this.upgradee4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Get_btt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_login = new System.Windows.Forms.Label();
            this.Text_pass = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upgradee4);
            this.panel1.Controls.Add(this.Accept);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.upgradee1);
            this.panel1.Controls.Add(this.Cheat);
            this.panel1.Controls.Add(this.upgredee2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.upgredee3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.Upgrades);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 450);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-353, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Activate);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(90, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 138);
            this.button1.TabIndex = 0;
            this.button1.Text = "КУПИТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_mouse);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(569, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(-4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 77);
            this.label3.TabIndex = 18;
            this.label3.Text = "БИТ-коин:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(776, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "ПРОКАЧАТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Upgrades
            // 
            this.Upgrades.AutoSize = true;
            this.Upgrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upgrades.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Upgrades.Location = new System.Drawing.Point(3, 62);
            this.Upgrades.Name = "Upgrades";
            this.Upgrades.Size = new System.Drawing.Size(138, 18);
            this.Upgrades.TabIndex = 15;
            this.Upgrades.Text = "Кол-во апгрейдов:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(776, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "ПРОКАЧАТЬ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(581, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 141);
            this.button2.TabIndex = 1;
            this.button2.Text = "Апгрейд";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(776, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "ПРОКАЧАТЬ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // upgredee3
            // 
            this.upgredee3.AutoSize = true;
            this.upgredee3.ForeColor = System.Drawing.SystemColors.Control;
            this.upgredee3.Location = new System.Drawing.Point(596, 88);
            this.upgredee3.Name = "upgredee3";
            this.upgredee3.Size = new System.Drawing.Size(174, 13);
            this.upgredee3.TabIndex = 13;
            this.upgredee3.Text = "GTX 1050TI 10x 5000-БИТкоинов";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(776, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 26);
            this.button6.TabIndex = 10;
            this.button6.Text = "ПРОКАЧАТЬ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // upgredee2
            // 
            this.upgredee2.AutoSize = true;
            this.upgredee2.ForeColor = System.Drawing.SystemColors.Control;
            this.upgredee2.Location = new System.Drawing.Point(596, 53);
            this.upgredee2.Name = "upgredee2";
            this.upgredee2.Size = new System.Drawing.Size(179, 13);
            this.upgredee2.TabIndex = 12;
            this.upgredee2.Text = "Приват. очередь 1000-БИТкоинов";
            // 
            // Cheat
            // 
            this.Cheat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Cheat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cheat.Enabled = false;
            this.Cheat.Location = new System.Drawing.Point(641, 414);
            this.Cheat.Name = "Cheat";
            this.Cheat.Size = new System.Drawing.Size(100, 13);
            this.Cheat.TabIndex = 19;
            this.Cheat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cheat.Visible = false;
            // 
            // upgradee1
            // 
            this.upgradee1.AutoSize = true;
            this.upgradee1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.upgradee1.Location = new System.Drawing.Point(596, 20);
            this.upgradee1.Name = "upgradee1";
            this.upgradee1.Size = new System.Drawing.Size(171, 13);
            this.upgradee1.TabIndex = 11;
            this.upgradee1.Text = "Купить прогноз  100-БИТкоинов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(291, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // Accept
            // 
            this.Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Accept.Enabled = false;
            this.Accept.FlatAppearance.BorderSize = 0;
            this.Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accept.ForeColor = System.Drawing.Color.SeaGreen;
            this.Accept.Location = new System.Drawing.Point(753, 409);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(22, 23);
            this.Accept.TabIndex = 20;
            this.Accept.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Visible = false;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // upgradee4
            // 
            this.upgradee4.AutoSize = true;
            this.upgradee4.ForeColor = System.Drawing.SystemColors.Control;
            this.upgradee4.Location = new System.Drawing.Point(596, 122);
            this.upgradee4.Name = "upgradee4";
            this.upgradee4.Size = new System.Drawing.Size(174, 13);
            this.upgradee4.TabIndex = 14;
            this.upgradee4.Text = "RTX 2080TI 5x 15000-БИТкоинов";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-481, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(943, 613);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(456, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(943, 613);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // Get_btt
            // 
            this.Get_btt.FlatAppearance.BorderSize = 0;
            this.Get_btt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Get_btt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Get_btt.Image = ((System.Drawing.Image)(resources.GetObject("Get_btt.Image")));
            this.Get_btt.Location = new System.Drawing.Point(364, 235);
            this.Get_btt.Name = "Get_btt";
            this.Get_btt.Size = new System.Drawing.Size(185, 99);
            this.Get_btt.TabIndex = 26;
            this.Get_btt.Text = "Войти";
            this.Get_btt.UseVisualStyleBackColor = true;
            this.Get_btt.Click += new System.EventHandler(this.Get_btt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Text_login);
            this.panel2.Controls.Add(this.Login_txt);
            this.panel2.Controls.Add(this.Get_btt);
            this.panel2.Controls.Add(this.Text_pass);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 450);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 77);
            this.label2.TabIndex = 22;
            this.label2.Text = "Вход в аккаунт:";
            // 
            // Text_login
            // 
            this.Text_login.AutoSize = true;
            this.Text_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Text_login.Location = new System.Drawing.Point(377, 103);
            this.Text_login.Name = "Text_login";
            this.Text_login.Size = new System.Drawing.Size(41, 13);
            this.Text_login.TabIndex = 27;
            this.Text_login.Text = "Логин:";
            // 
            // Text_pass
            // 
            this.Text_pass.AutoSize = true;
            this.Text_pass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Text_pass.Location = new System.Drawing.Point(377, 152);
            this.Text_pass.Name = "Text_pass";
            this.Text_pass.Size = new System.Drawing.Size(45, 13);
            this.Text_pass.TabIndex = 28;
            this.Text_pass.Text = "Пароль";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Wingdings 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Password.Location = new System.Drawing.Point(380, 168);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(155, 19);
            this.Password.TabIndex = 25;
            // 
            // Login_txt
            // 
            this.Login_txt.Location = new System.Drawing.Point(380, 119);
            this.Login_txt.Name = "Login_txt";
            this.Login_txt.Size = new System.Drawing.Size(155, 20);
            this.Login_txt.TabIndex = 23;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "KELP / Private Mining BETA 0.1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label upgradee4;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label upgradee1;
        private System.Windows.Forms.TextBox Cheat;
        private System.Windows.Forms.Label upgredee2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label upgredee3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Upgrades;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Get_btt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Text_login;
        private System.Windows.Forms.TextBox Login_txt;
        private System.Windows.Forms.Label Text_pass;
        private System.Windows.Forms.TextBox Password;
    }
}

