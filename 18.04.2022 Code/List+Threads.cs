using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18._04._2022_Code
{
    public partial class Form1 : Form
    {
        //Представляет событие синхронизации потока, 
        //которое при получении сигнала необходимо сбросить вручную. Этот класс не наследуется.
        ManualResetEvent mre1 = new ManualResetEvent(false);
        ManualResetEvent mre2 = new ManualResetEvent(false);
        ManualResetEvent mre3 = new ManualResetEvent(false);

        public delegate void ThreadStart();
        public delegate void ThreadStop();

        //Объявляем потоки
        Thread myThread1;
        Thread myThread2;
        public Form1()
        {
            InitializeComponent();
        }

        //Метод для первого потока
        public void MethodTr1()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                mre1.WaitOne();
                this.Invoke(new Action(() => { listBox1.Items.Add("Первый поток:" + (i).ToString()); }));
                Thread.Sleep(rnd.Next(0, 1000));
            }
        }

        //Метод для второго потока
        public void MethodTr2()
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                mre2.WaitOne();
                this.Invoke(new Action(() => { listBox2.Items.Add("Второй поток:" + (i).ToString()); }));
                Thread.Sleep(rnd.Next(0, 1000));
            }
        }

        //Запуск потока 1
        private void StartBtn1_Click(object sender, EventArgs e)
        {
            mre1.Set();
            label1.Text = "Поток " + myThread1.Name + " продолжен";
        }

        //Запуск потока 2
        private void StartBtn2_Click(object sender, EventArgs e)
        {
            mre2.Set();
            label2.Text = "Поток " + myThread1.Name + " продолжен";
        }

        private void StopBtn1_Click(object sender, EventArgs e)
        {
            mre1.Reset();
            label1.Text = "Поток " + myThread1.Name + " остановлен";
        }

        private void StopBtn2_Click(object sender, EventArgs e)
        {
            mre2.Reset();
            label2.Text = "Поток " + myThread1.Name + " остановлен";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myThread1 = new Thread(MethodTr1);
            myThread1.Name = "Thread1";
            myThread1.Start(); // запускаем поток
            mre1.Set();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myThread2 = new Thread(MethodTr2);
            myThread2.Name = "Thread2";
            myThread2.Start(); // запускаем поток
            mre2.Set();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Останавливаем ManualResetEvent
            mre1.Reset();
            mre2.Reset();
            mre3.Reset();
            //Если потом запущен, останавливаем его
            if (myThread1 != null) myThread1.Abort();
            mre2.Reset();
            if (myThread2 != null) myThread2.Abort();
        }
    }
}
