using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TB_ESV.BackColor = Color.Snow;
            TB_TSV.BackColor = Color.Snow;
        }

        public static int ToInt32(String value)
        {
            if (String.IsNullOrEmpty(value))
                return 0;
            return Int32.Parse(value);
        }

        public static uint ToUInt32(String value, int b)
        {
            if (String.IsNullOrEmpty(value))
                return 0;
            return Convert.ToUInt32(value,b);
        }

        private void updateESV(object sender, EventArgs e)
        {
            // Update Egg Shiny Value
            try
            {
                // If this works... do work.
                uint PID = ToUInt32(TB_PID.Text, 16);
                TB_PID.BackColor = Color.White;
                TB_ESV.Text = (((PID >> 16) ^ (PID & 0xFFFF)) >> 4).ToString();
            }
            catch 
            {
                TB_PID.BackColor = Color.LightSalmon; 
                System.Media.SystemSounds.Asterisk.Play();
            }
        }

        private void updateTSV(object sender, EventArgs e)
        {
            // Update Trainer Shiny Value
            int TID = ToInt32(TB_TID.Text);
            int SID = ToInt32(TB_SID.Text);

            if (TID > 0xFFFF)
            {
                TB_TID.BackColor = Color.LightSalmon;
            }
            else if (SID > 0xFFFF)
            {
                TB_SID.BackColor = Color.LightSalmon;
            }

            else
            {
                TB_TSV.Text = ((TID ^ SID) >> 4).ToString();
                TB_TID.BackColor = Color.White;
                TB_SID.BackColor = Color.White;
            }
        }
    }
}
