using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLog;

namespace LogN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger log = LogManager.GetLogger("Console");

            log.Debug("Hello World");
            log.Info("Hello World");
            log.Error("Hello World");
            log.Fatal("Hello World");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logger log = LogManager.GetLogger("Text");

            log.Debug("Hello World");
            log.Info("Hello World");
            log.Error("Hello World");
            log.Fatal("Hello World");

        }
    }
}