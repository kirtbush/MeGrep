using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using MeGrep.Core;

namespace MeGrep.Looks.Forms
{
    public class MyForm : Form
    {
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckedListBox checkedListBox1;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label searchlabel;
        private Label fileLabel;
        private Button addFileButton;
        private ListView removeFileListBox;
        private ListView addedFileFormatListBox;
        private Button removeFileButton;
        private TextBox fileTextBox;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.IContainer components;
        private Label lastSearchLabel;
        private List<string> fileFormats;

        public MyForm () 
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fileLabel = new System.Windows.Forms.Label();
            this.addedFileFormatListBox = new System.Windows.Forms.ListView();
            this.removeFileButton = new System.Windows.Forms.Button();
            this.addFileButton = new System.Windows.Forms.Button();
            this.removeFileListBox = new System.Windows.Forms.ListView();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchlabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lastSearchLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.fileLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.addedFileFormatListBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.removeFileButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.addFileButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.removeFileListBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.fileTextBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 245);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(3, 3);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(60, 13);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "File Pattern";
            // 
            // addedFileFormatListBox
            // 
            this.addedFileFormatListBox.Location = new System.Drawing.Point(417, 19);
            this.addedFileFormatListBox.Name = "addedFileFormatListBox";
            this.tableLayoutPanel2.SetRowSpan(this.addedFileFormatListBox, 2);
            this.addedFileFormatListBox.Size = new System.Drawing.Size(360, 213);
            this.addedFileFormatListBox.TabIndex = 6;
            this.addedFileFormatListBox.UseCompatibleStateImageBehavior = false;
            // 
            // removeFileButton
            // 
            this.removeFileButton.Location = new System.Drawing.Point(336, 48);
            this.removeFileButton.Name = "removeFileButton";
            this.removeFileButton.Size = new System.Drawing.Size(75, 23);
            this.removeFileButton.TabIndex = 5;
            this.removeFileButton.Text = "<--";
            this.removeFileButton.UseVisualStyleBackColor = true;
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(336, 19);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(75, 23);
            this.addFileButton.TabIndex = 2;
            this.addFileButton.Text = "-->";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.AddFileType);
            // 
            // removeFileListBox
            // 
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.removeFileListBox.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.removeFileListBox.Location = new System.Drawing.Point(3, 48);
            this.removeFileListBox.Name = "removeFileListBox";
            this.tableLayoutPanel2.SetRowSpan(this.removeFileListBox, 2);
            this.removeFileListBox.Size = new System.Drawing.Size(327, 184);
            this.removeFileListBox.TabIndex = 3;
            this.removeFileListBox.UseCompatibleStateImageBehavior = false;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(3, 19);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(174, 20);
            this.fileTextBox.TabIndex = 7;
            this.fileTextBox.Text = "*.*";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchlabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lastSearchLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 106);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(327, 94);
            this.checkedListBox1.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(327, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(336, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchClicked);
            // 
            // searchlabel
            // 
            this.searchlabel.AutoSize = true;
            this.searchlabel.Location = new System.Drawing.Point(336, 106);
            this.searchlabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(78, 13);
            this.searchlabel.TabIndex = 3;
            this.searchlabel.Text = "Search Pattern";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(801, 494);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 238);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Ready...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // lastSearchLabel
            // 
            this.lastSearchLabel.AutoSize = true;
            this.lastSearchLabel.Location = new System.Drawing.Point(420, 3);
            this.lastSearchLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lastSearchLabel.Name = "lastSearchLabel";
            this.lastSearchLabel.Size = new System.Drawing.Size(0, 13);
            this.lastSearchLabel.TabIndex = 4;
            // 
            // MyForm
            // 
            this.ClientSize = new System.Drawing.Size(801, 494);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MyForm";
            this.Load += new System.EventHandler(this.MeGrepForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void MeGrepForm_Load(object sender, EventArgs e)
        {    
            CenterToScreen();
            this.Text = Settings1.Default.AppName;
        }

        private void SearchClicked(object sender, EventArgs e)
        {
            string searchText = this.searchTextBox.Text;
            ///should probably modify this to be asynchronous with the UI
            Console.WriteLine("Beginning Search...");
            this.toolStripStatusLabel1.Text = "Searching...";

            if (string.IsNullOrEmpty(searchText))
            {
                this.toolStripStatusLabel1.Text = "Search Failed: EMPTY SEARCH FIELD";
                Console.WriteLine("Search FAILED: EMPTY SEARCH FIELD");
                return;
            }

            Settings1.Default.LastSearchTime = DateTime.Now;
            Settings1.Default.Save();
            lastSearchLabel.Text = Settings1.Default.LastSearchTime.ToShortDateString();

            //TODO: check for nulls
            GrepQuery myQuery = new GrepQuery(this.searchTextBox.Text, this.fileTextBox.Text);
            Console.WriteLine("Query Object Constructed, Running Query");
            myQuery.RunQuery();
            this.toolStripStatusLabel1.Text = "Search Complete...";
        }

        private void AddFileType(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Adding file types...";
            string fileFormat = this.fileTextBox.Text;

            if (fileFormat != string.Empty)
            {

            }
            this.toolStripStatusLabel1.Text = "Added file types...";
        }
    }
}
