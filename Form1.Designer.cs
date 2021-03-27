
namespace TaskBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inprogresslist = new System.Windows.Forms.ListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.inprogressbutton = new MetroFramework.Controls.MetroButton();
            this.todolist = new System.Windows.Forms.ListBox();
            this.todobutton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.revisionlist = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.revisionbutton = new MetroFramework.Controls.MetroButton();
            this.checklist = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.checkbutton = new MetroFramework.Controls.MetroButton();
            this.donelist = new System.Windows.Forms.ListBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.donebutton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // inprogresslist
            // 
            this.inprogresslist.FormattingEnabled = true;
            this.inprogresslist.ItemHeight = 16;
            this.inprogresslist.Location = new System.Drawing.Point(233, 123);
            this.inprogresslist.Name = "inprogresslist";
            this.inprogresslist.Size = new System.Drawing.Size(172, 356);
            this.inprogresslist.TabIndex = 4;
            this.inprogresslist.DragDrop += new System.Windows.Forms.DragEventHandler(this.inprogresslist_DragDrop);
            this.inprogresslist.DragEnter += new System.Windows.Forms.DragEventHandler(this.inprogresslist_DragEnter);
            this.inprogresslist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.inprogresslist_MouseDoubleClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(278, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "İn Progress";
            // 
            // inprogressbutton
            // 
            this.inprogressbutton.Location = new System.Drawing.Point(233, 510);
            this.inprogressbutton.Name = "inprogressbutton";
            this.inprogressbutton.Size = new System.Drawing.Size(172, 23);
            this.inprogressbutton.TabIndex = 2;
            this.inprogressbutton.Text = "+ Add another card";
            this.inprogressbutton.UseSelectable = true;
            this.inprogressbutton.Click += new System.EventHandler(this.inprogressbutton_Click);
            // 
            // todolist
            // 
            this.todolist.FormattingEnabled = true;
            this.todolist.ItemHeight = 16;
            this.todolist.Location = new System.Drawing.Point(32, 123);
            this.todolist.Name = "todolist";
            this.todolist.Size = new System.Drawing.Size(165, 356);
            this.todolist.TabIndex = 0;
            this.todolist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.todolist_MouseDown);
            // 
            // todobutton
            // 
            this.todobutton.Location = new System.Drawing.Point(32, 510);
            this.todobutton.Name = "todobutton";
            this.todobutton.Size = new System.Drawing.Size(165, 23);
            this.todobutton.TabIndex = 1;
            this.todobutton.Text = "+ Add another card";
            this.todobutton.UseSelectable = true;
            this.todobutton.Click += new System.EventHandler(this.todobutton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(86, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "To Do";
            // 
            // revisionlist
            // 
            this.revisionlist.FormattingEnabled = true;
            this.revisionlist.ItemHeight = 16;
            this.revisionlist.Location = new System.Drawing.Point(443, 123);
            this.revisionlist.Name = "revisionlist";
            this.revisionlist.Size = new System.Drawing.Size(184, 356);
            this.revisionlist.TabIndex = 5;
            this.revisionlist.DragDrop += new System.Windows.Forms.DragEventHandler(this.revisionlist_DragDrop);
            this.revisionlist.DragEnter += new System.Windows.Forms.DragEventHandler(this.revisionlist_DragEnter);
            this.revisionlist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.revisionlist_MouseDoubleClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(499, 79);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Revision";
            // 
            // revisionbutton
            // 
            this.revisionbutton.Location = new System.Drawing.Point(443, 510);
            this.revisionbutton.Name = "revisionbutton";
            this.revisionbutton.Size = new System.Drawing.Size(184, 23);
            this.revisionbutton.TabIndex = 7;
            this.revisionbutton.Text = "+ Add another card";
            this.revisionbutton.UseSelectable = true;
            this.revisionbutton.Click += new System.EventHandler(this.revisionbutton_Click);
            // 
            // checklist
            // 
            this.checklist.FormattingEnabled = true;
            this.checklist.ItemHeight = 16;
            this.checklist.Location = new System.Drawing.Point(668, 123);
            this.checklist.Name = "checklist";
            this.checklist.Size = new System.Drawing.Size(180, 356);
            this.checklist.TabIndex = 8;
            this.checklist.DragDrop += new System.Windows.Forms.DragEventHandler(this.checklist_DragDrop);
            this.checklist.DragEnter += new System.Windows.Forms.DragEventHandler(this.checklist_DragEnter);
            this.checklist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.checklist_MouseDoubleClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(737, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Check";
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(677, 510);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(171, 23);
            this.checkbutton.TabIndex = 10;
            this.checkbutton.Text = "+ Add another card";
            this.checkbutton.UseSelectable = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // donelist
            // 
            this.donelist.FormattingEnabled = true;
            this.donelist.ItemHeight = 16;
            this.donelist.Location = new System.Drawing.Point(890, 123);
            this.donelist.Name = "donelist";
            this.donelist.Size = new System.Drawing.Size(169, 356);
            this.donelist.TabIndex = 11;
            this.donelist.DragDrop += new System.Windows.Forms.DragEventHandler(this.donelist_DragDrop);
            this.donelist.DragEnter += new System.Windows.Forms.DragEventHandler(this.donelist_DragEnter);
            this.donelist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.donelist_MouseDoubleClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(954, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 20);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Done";
            // 
            // donebutton
            // 
            this.donebutton.Location = new System.Drawing.Point(890, 510);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(169, 23);
            this.donebutton.TabIndex = 13;
            this.donebutton.Text = "+ Add another card";
            this.donebutton.UseSelectable = true;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 572);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.donelist);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.checklist);
            this.Controls.Add(this.revisionbutton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.revisionlist);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.inprogresslist);
            this.Controls.Add(this.inprogressbutton);
            this.Controls.Add(this.todobutton);
            this.Controls.Add(this.todolist);
            this.Name = "Form1";
            this.Text = "TASK BOARD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox inprogresslist;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton inprogressbutton;
        private System.Windows.Forms.ListBox todolist;
        private MetroFramework.Controls.MetroButton todobutton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox revisionlist;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton revisionbutton;
        private System.Windows.Forms.ListBox checklist;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton checkbutton;
        private System.Windows.Forms.ListBox donelist;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton donebutton;
    }
}

