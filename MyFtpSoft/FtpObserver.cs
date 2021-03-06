﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MyFtpSoft
{
    public partial class FtpObserver : UserControl
    {
        public FtpObserver()
        {
            InitializeComponent();

        }

        public  ListView GetListView()
        {
            return lvTransfer;
        }
        public  RichTextBox GetRitchTextBox()
        {
            return rtxtLog;
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtLog.Clear();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clearQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvTransfer.Items.Clear();
        }

        private void delteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTransfer.SelectedItems.Count > 0)
            {
                lvTransfer.Items.Remove(lvTransfer.SelectedItems[0]);
            }

        }

        private void editeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
