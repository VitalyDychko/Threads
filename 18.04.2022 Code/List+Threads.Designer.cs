
namespace _18._04._2022_Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StopBtn1 = new System.Windows.Forms.Button();
            this.StartBtn1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.StopBtn2 = new System.Windows.Forms.Button();
            this.StartBtn2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.labelfordescription = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.StopBtn1);
            this.panel2.Controls.Add(this.StartBtn1);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(263, 322);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Статус потока №1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StopBtn1
            // 
            this.StopBtn1.BackColor = System.Drawing.Color.Gold;
            this.StopBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.StopBtn1.FlatAppearance.BorderSize = 0;
            this.StopBtn1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.StopBtn1.Location = new System.Drawing.Point(5, 253);
            this.StopBtn1.Name = "StopBtn1";
            this.StopBtn1.Size = new System.Drawing.Size(253, 31);
            this.StopBtn1.TabIndex = 2;
            this.StopBtn1.Text = "Стоп!";
            this.StopBtn1.UseVisualStyleBackColor = false;
            this.StopBtn1.Click += new System.EventHandler(this.StopBtn1_Click);
            // 
            // StartBtn1
            // 
            this.StartBtn1.BackColor = System.Drawing.Color.Gold;
            this.StartBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartBtn1.FlatAppearance.BorderSize = 0;
            this.StartBtn1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.StartBtn1.Location = new System.Drawing.Point(5, 222);
            this.StartBtn1.Name = "StartBtn1";
            this.StartBtn1.Size = new System.Drawing.Size(253, 31);
            this.StartBtn1.TabIndex = 1;
            this.StartBtn1.Text = "Продолжить!";
            this.StartBtn1.UseVisualStyleBackColor = false;
            this.StartBtn1.Click += new System.EventHandler(this.StartBtn1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 186);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск потока №1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 322);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StopBtn2);
            this.panel1.Controls.Add(this.StartBtn2);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(263, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(263, 322);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус потока №2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StopBtn2
            // 
            this.StopBtn2.BackColor = System.Drawing.Color.Gold;
            this.StopBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopBtn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.StopBtn2.FlatAppearance.BorderSize = 0;
            this.StopBtn2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.StopBtn2.Location = new System.Drawing.Point(5, 253);
            this.StopBtn2.Name = "StopBtn2";
            this.StopBtn2.Size = new System.Drawing.Size(253, 31);
            this.StopBtn2.TabIndex = 2;
            this.StopBtn2.Text = "Стоп!";
            this.StopBtn2.UseVisualStyleBackColor = false;
            this.StopBtn2.Click += new System.EventHandler(this.StopBtn2_Click);
            // 
            // StartBtn2
            // 
            this.StartBtn2.BackColor = System.Drawing.Color.Gold;
            this.StartBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartBtn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartBtn2.FlatAppearance.BorderSize = 0;
            this.StartBtn2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.StartBtn2.Location = new System.Drawing.Point(5, 222);
            this.StartBtn2.Name = "StartBtn2";
            this.StartBtn2.Size = new System.Drawing.Size(253, 31);
            this.StartBtn2.TabIndex = 1;
            this.StartBtn2.Text = "Продолжить!";
            this.StartBtn2.UseVisualStyleBackColor = false;
            this.StartBtn2.Click += new System.EventHandler(this.StartBtn2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(5, 36);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(253, 186);
            this.listBox2.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gold;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.button6.Location = new System.Drawing.Point(5, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(253, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "Запуск потока №2";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelfordescription
            // 
            this.labelfordescription.BackColor = System.Drawing.Color.Gold;
            this.labelfordescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelfordescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelfordescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfordescription.ForeColor = System.Drawing.Color.Black;
            this.labelfordescription.Location = new System.Drawing.Point(0, 315);
            this.labelfordescription.Name = "labelfordescription";
            this.labelfordescription.Size = new System.Drawing.Size(522, 22);
            this.labelfordescription.TabIndex = 0;
            this.labelfordescription.Text = "Создание потоков для заполнения листа значениями";
            this.labelfordescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 337);
            this.Controls.Add(this.labelfordescription);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Потоки+Лист";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StopBtn1;
        private System.Windows.Forms.Button StartBtn1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StopBtn2;
        private System.Windows.Forms.Button StartBtn2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelfordescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

