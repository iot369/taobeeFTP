﻿namespace MyFtpSoft
{
    partial class FtpObserver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FtpObserver));
            this.lvTransfer = new System.Windows.Forms.ListView();
            this.FileName = new System.Windows.Forms.ColumnHeader();
            this.FileSize = new System.Windows.Forms.ColumnHeader();
            this.Target = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStripTransfer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.moveToTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToBottonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.queueInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripObserve = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTransfer.SuspendLayout();
            this.contextMenuStripObserve.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvTransfer
            // 
            this.lvTransfer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileSize,
            this.Target});
            this.lvTransfer.ContextMenuStrip = this.contextMenuStripTransfer;
            this.lvTransfer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvTransfer.Location = new System.Drawing.Point(0, 0);
            this.lvTransfer.Name = "lvTransfer";
            this.lvTransfer.Size = new System.Drawing.Size(581, 239);
            this.lvTransfer.SmallImageList = this.imageList1;
            this.lvTransfer.TabIndex = 0;
            this.lvTransfer.UseCompatibleStateImageBehavior = false;
            this.lvTransfer.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "FileName";
            this.FileName.Width = 300;
            // 
            // FileSize
            // 
            this.FileSize.Text = "FileSize";
            this.FileSize.Width = 100;
            // 
            // Target
            // 
            this.Target.Text = "Target";
            // 
            // contextMenuStripTransfer
            // 
            this.contextMenuStripTransfer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearQueueToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editeItemToolStripMenuItem,
            this.delteItemToolStripMenuItem,
            this.toolStripMenuItem3,
            this.moveToTopToolStripMenuItem,
            this.moveToBottonToolStripMenuItem,
            this.toolStripMenuItem4,
            this.queueInformationToolStripMenuItem,
            this.toolStripMenuItem5,
            this.saveQueueToolStripMenuItem,
            this.loadQueueToolStripMenuItem});
            this.contextMenuStripTransfer.Name = "contextMenuStripTransfer";
            this.contextMenuStripTransfer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripTransfer.Size = new System.Drawing.Size(163, 204);
            // 
            // clearQueueToolStripMenuItem
            // 
            this.clearQueueToolStripMenuItem.Name = "clearQueueToolStripMenuItem";
            this.clearQueueToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clearQueueToolStripMenuItem.Text = "ClearQueue";
            this.clearQueueToolStripMenuItem.Click += new System.EventHandler(this.clearQueueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // editeItemToolStripMenuItem
            // 
            this.editeItemToolStripMenuItem.Image = global::MyFtpSoft.Properties.Resources._3;
            this.editeItemToolStripMenuItem.Name = "editeItemToolStripMenuItem";
            this.editeItemToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editeItemToolStripMenuItem.Text = "AddItem";
            this.editeItemToolStripMenuItem.Click += new System.EventHandler(this.editeItemToolStripMenuItem_Click);
            // 
            // delteItemToolStripMenuItem
            // 
            this.delteItemToolStripMenuItem.Image = global::MyFtpSoft.Properties.Resources._4;
            this.delteItemToolStripMenuItem.Name = "delteItemToolStripMenuItem";
            this.delteItemToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.delteItemToolStripMenuItem.Text = "DeleteItem";
            this.delteItemToolStripMenuItem.Click += new System.EventHandler(this.delteItemToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 6);
            // 
            // moveToTopToolStripMenuItem
            // 
            this.moveToTopToolStripMenuItem.Name = "moveToTopToolStripMenuItem";
            this.moveToTopToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.moveToTopToolStripMenuItem.Text = "MoveToTop";
            // 
            // moveToBottonToolStripMenuItem
            // 
            this.moveToBottonToolStripMenuItem.Name = "moveToBottonToolStripMenuItem";
            this.moveToBottonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.moveToBottonToolStripMenuItem.Text = "MoveToBotton";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(159, 6);
            // 
            // queueInformationToolStripMenuItem
            // 
            this.queueInformationToolStripMenuItem.Image = global::MyFtpSoft.Properties.Resources._11;
            this.queueInformationToolStripMenuItem.Name = "queueInformationToolStripMenuItem";
            this.queueInformationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.queueInformationToolStripMenuItem.Text = "QueueInformation";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(159, 6);
            // 
            // saveQueueToolStripMenuItem
            // 
            this.saveQueueToolStripMenuItem.Name = "saveQueueToolStripMenuItem";
            this.saveQueueToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveQueueToolStripMenuItem.Text = "SaveQueue";
            // 
            // loadQueueToolStripMenuItem
            // 
            this.loadQueueToolStripMenuItem.Name = "loadQueueToolStripMenuItem";
            this.loadQueueToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.loadQueueToolStripMenuItem.Text = "LoadQueue";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DownFlag.ico");
            this.imageList1.Images.SetKeyName(1, "UpFlag.ico");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(581, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 239);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // rtxtLog
            // 
            this.rtxtLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtxtLog.ContextMenuStrip = this.contextMenuStripObserve;
            this.rtxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtLog.Location = new System.Drawing.Point(584, 0);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(75, 239);
            this.rtxtLog.TabIndex = 2;
            this.rtxtLog.Text = "";
            // 
            // contextMenuStripObserve
            // 
            this.contextMenuStripObserve.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.clearAllToolStripMenuItem});
            this.contextMenuStripObserve.Name = "contextMenuStripObserve";
            this.contextMenuStripObserve.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStripObserve.Size = new System.Drawing.Size(157, 76);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::MyFtpSoft.Properties.Resources.cut_16x16;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearToolStripMenuItem.Text = "CopyToClipboard";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Image = global::MyFtpSoft.Properties.Resources.copy_16x16;
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveToFileToolStripMenuItem.Text = "SaveToFile";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearAllToolStripMenuItem.Text = "ClearAll";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // FtpObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lvTransfer);
            this.Name = "FtpObserver";
            this.Size = new System.Drawing.Size(659, 239);
            this.contextMenuStripTransfer.ResumeLayout(false);
            this.contextMenuStripObserve.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTransfer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.ColumnHeader Target;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTransfer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripObserve;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem moveToTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToBottonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem queueInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem saveQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadQueueToolStripMenuItem;
    }
}
