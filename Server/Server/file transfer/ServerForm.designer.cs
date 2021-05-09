partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuTransfers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSendFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPauseTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClearComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressOverall = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtSaveDir = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpenDir = new System.Windows.Forms.ToolStripButton();
            this.lstTransfers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCntHost = new System.Windows.Forms.ToolStripTextBox();
            this.txtPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnStop = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TxtFile1 = new System.Windows.Forms.TextBox();
            this.BtnCompare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPath2 = new System.Windows.Forms.TextBox();
            this.TxtPath1 = new System.Windows.Forms.TextBox();
            this.BtnDirectory2 = new System.Windows.Forms.Button();
            this.BtnDirectory1 = new System.Windows.Forms.Button();
            this.TxtFile2 = new System.Windows.Forms.TextBox();
            this.menuTransfers.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTransfers
            // 
            this.menuTransfers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSendFile,
            this.btnStopTransfer,
            this.btnPauseTransfer,
            this.toolStripMenuItem1,
            this.btnClearComplete});
            this.menuTransfers.Name = "contextMenuStrip1";
            this.menuTransfers.Size = new System.Drawing.Size(157, 98);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(156, 22);
            this.btnSendFile.Text = "Send";
            // 
            // btnStopTransfer
            // 
            this.btnStopTransfer.Name = "btnStopTransfer";
            this.btnStopTransfer.Size = new System.Drawing.Size(156, 22);
            this.btnStopTransfer.Text = "Stop";
            // 
            // btnPauseTransfer
            // 
            this.btnPauseTransfer.Name = "btnPauseTransfer";
            this.btnPauseTransfer.Size = new System.Drawing.Size(156, 22);
            this.btnPauseTransfer.Text = "Pause";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // btnClearComplete
            // 
            this.btnClearComplete.Name = "btnClearComplete";
            this.btnClearComplete.Size = new System.Drawing.Size(156, 22);
            this.btnClearComplete.Text = "Clear Complete";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnected,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.progressOverall});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(480, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblConnected
            // 
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(301, 17);
            this.lblConnected.Spring = true;
            this.lblConnected.Text = "Connection: -";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel3.Text = "Progress";
            // 
            // progressOverall
            // 
            this.progressOverall.Name = "progressOverall";
            this.progressOverall.Size = new System.Drawing.Size(100, 16);
            this.progressOverall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 320);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip3);
            this.tabPage1.Controls.Add(this.lstTransfers);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Transfer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.txtSaveDir,
            this.toolStripSeparator3,
            this.btnOpenDir});
            this.toolStrip3.Location = new System.Drawing.Point(3, 28);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(466, 25);
            this.toolStrip3.TabIndex = 11;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(85, 22);
            this.toolStripLabel2.Text = "Save Directory:";
            // 
            // txtSaveDir
            // 
            this.txtSaveDir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSaveDir.Name = "txtSaveDir";
            this.txtSaveDir.Size = new System.Drawing.Size(100, 25);
            this.txtSaveDir.Text = "...\\";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpenDir.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenDir.Image")));
            this.btnOpenDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(94, 22);
            this.btnOpenDir.Text = "Chose directory";
            // 
            // lstTransfers
            // 
            this.lstTransfers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstTransfers.ContextMenuStrip = this.menuTransfers;
            this.lstTransfers.FullRowSelect = true;
            this.lstTransfers.HideSelection = false;
            this.lstTransfers.Location = new System.Drawing.Point(3, 56);
            this.lstTransfers.Name = "lstTransfers";
            this.lstTransfers.Size = new System.Drawing.Size(463, 232);
            this.lstTransfers.TabIndex = 3;
            this.lstTransfers.UseCompatibleStateImageBehavior = false;
            this.lstTransfers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Filename";
            this.columnHeader5.Width = 171;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 72;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Progress";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 68;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtCntHost,
            this.txtPort,
            this.toolStripSeparator2,
            this.BtnStart,
            this.toolStripSeparator5,
            this.BtnStop});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "Host:";
            // 
            // txtCntHost
            // 
            this.txtCntHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCntHost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCntHost.Name = "txtCntHost";
            this.txtCntHost.Size = new System.Drawing.Size(100, 25);
            this.txtCntHost.Text = "local__host";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(30, 25);
            this.txtPort.Text = "100";
            this.txtPort.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnStart
            // 
            this.BtnStart.AutoSize = false;
            this.BtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnStart.Image = ((System.Drawing.Image)(resources.GetObject("BtnStart.Image")));
            this.BtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(100, 22);
            this.BtnStart.Text = "Start";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnStop
            // 
            this.BtnStop.AutoSize = false;
            this.BtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(100, 22);
            this.BtnStop.Text = "Stop";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtMessage);
            this.tabPage2.Controls.Add(this.txtInfo);
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Communication with clients";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(78, 204);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(386, 55);
            this.txtMessage.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(8, 6);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(456, 192);
            this.txtInfo.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(302, 265);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(167, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TxtFile2);
            this.tabPage3.Controls.Add(this.TxtFile1);
            this.tabPage3.Controls.Add(this.BtnCompare);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.TxtPath2);
            this.tabPage3.Controls.Add(this.TxtPath1);
            this.tabPage3.Controls.Add(this.BtnDirectory2);
            this.tabPage3.Controls.Add(this.BtnDirectory1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(472, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compare files";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TxtFile1
            // 
            this.TxtFile1.Location = new System.Drawing.Point(13, 191);
            this.TxtFile1.Multiline = true;
            this.TxtFile1.Name = "TxtFile1";
            this.TxtFile1.ReadOnly = true;
            this.TxtFile1.Size = new System.Drawing.Size(223, 100);
            this.TxtFile1.TabIndex = 7;
            // 
            // BtnCompare
            // 
            this.BtnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCompare.Location = new System.Drawing.Point(185, 150);
            this.BtnCompare.Name = "BtnCompare";
            this.BtnCompare.Size = new System.Drawing.Size(100, 35);
            this.BtnCompare.TabIndex = 6;
            this.BtnCompare.Text = "Compare";
            this.BtnCompare.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Second file path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First file path:";
            // 
            // TxtPath2
            // 
            this.TxtPath2.Location = new System.Drawing.Point(113, 106);
            this.TxtPath2.Name = "TxtPath2";
            this.TxtPath2.ReadOnly = true;
            this.TxtPath2.Size = new System.Drawing.Size(213, 20);
            this.TxtPath2.TabIndex = 3;
            // 
            // TxtPath1
            // 
            this.TxtPath1.Location = new System.Drawing.Point(113, 57);
            this.TxtPath1.Name = "TxtPath1";
            this.TxtPath1.ReadOnly = true;
            this.TxtPath1.Size = new System.Drawing.Size(213, 20);
            this.TxtPath1.TabIndex = 2;
            // 
            // BtnDirectory2
            // 
            this.BtnDirectory2.Location = new System.Drawing.Point(350, 100);
            this.BtnDirectory2.Name = "BtnDirectory2";
            this.BtnDirectory2.Size = new System.Drawing.Size(110, 30);
            this.BtnDirectory2.TabIndex = 1;
            this.BtnDirectory2.Text = "Chose directory 2#";
            this.BtnDirectory2.UseVisualStyleBackColor = true;
            // 
            // BtnDirectory1
            // 
            this.BtnDirectory1.Location = new System.Drawing.Point(350, 51);
            this.BtnDirectory1.Name = "BtnDirectory1";
            this.BtnDirectory1.Size = new System.Drawing.Size(110, 30);
            this.BtnDirectory1.TabIndex = 0;
            this.BtnDirectory1.Text = "Chose directory 1#";
            this.BtnDirectory1.UseVisualStyleBackColor = true;
            // 
            // TxtFile2
            // 
            this.TxtFile2.Location = new System.Drawing.Point(242, 191);
            this.TxtFile2.Multiline = true;
            this.TxtFile2.Name = "TxtFile2";
            this.TxtFile2.ReadOnly = true;
            this.TxtFile2.Size = new System.Drawing.Size(218, 100);
            this.TxtFile2.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuTransfers.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ContextMenuStrip menuTransfers;
    private System.Windows.Forms.ToolStripMenuItem btnSendFile;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem btnClearComplete;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblConnected;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    private System.Windows.Forms.ToolStripProgressBar progressOverall;
    private System.Windows.Forms.ToolStripMenuItem btnStopTransfer;
    private System.Windows.Forms.ToolStripMenuItem btnPauseTransfer;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.ToolStrip toolStrip3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    private System.Windows.Forms.ToolStripTextBox txtSaveDir;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton btnOpenDir;
    private System.Windows.Forms.ListView lstTransfers;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader7;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripTextBox txtCntHost;
    private System.Windows.Forms.ToolStripTextBox txtPort;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton BtnStart;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton BtnStop;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.TextBox txtInfo;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button BtnCompare;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TxtPath2;
    private System.Windows.Forms.TextBox TxtPath1;
    private System.Windows.Forms.Button BtnDirectory2;
    private System.Windows.Forms.Button BtnDirectory1;
    private System.Windows.Forms.TextBox TxtFile1;
    private System.Windows.Forms.TextBox TxtFile2;
}

