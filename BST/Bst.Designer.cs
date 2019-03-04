namespace BST
{
    partial class Bst
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
            this.fillArrayButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.textBoxRemove = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.findMinButton = new System.Windows.Forms.Button();
            this.findMaxButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.textBoxFindMin = new System.Windows.Forms.TextBox();
            this.textBoxFindMax = new System.Windows.Forms.TextBox();
            this.textBoxRoot = new System.Windows.Forms.TextBox();
            this.isEmptyButton = new System.Windows.Forms.Button();
            this.makeEmptyButton = new System.Windows.Forms.Button();
            this.removeMinButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.listBox = new System.Windows.Forms.ListBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillArrayButton
            // 
            this.fillArrayButton.Location = new System.Drawing.Point(13, 13);
            this.fillArrayButton.Name = "fillArrayButton";
            this.fillArrayButton.Size = new System.Drawing.Size(75, 23);
            this.fillArrayButton.TabIndex = 0;
            this.fillArrayButton.Text = "Fill Array";
            this.fillArrayButton.UseVisualStyleBackColor = true;
            this.fillArrayButton.Click += new System.EventHandler(this.fillArrayButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(106, 14);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 1;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(106, 43);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(106, 72);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Location = new System.Drawing.Point(187, 16);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(61, 20);
            this.textBoxInsert.TabIndex = 4;
            // 
            // textBoxRemove
            // 
            this.textBoxRemove.Location = new System.Drawing.Point(187, 45);
            this.textBoxRemove.Name = "textBoxRemove";
            this.textBoxRemove.Size = new System.Drawing.Size(61, 20);
            this.textBoxRemove.TabIndex = 5;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(187, 74);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(61, 20);
            this.textBoxFind.TabIndex = 6;
            // 
            // findMinButton
            // 
            this.findMinButton.Location = new System.Drawing.Point(256, 14);
            this.findMinButton.Name = "findMinButton";
            this.findMinButton.Size = new System.Drawing.Size(75, 23);
            this.findMinButton.TabIndex = 7;
            this.findMinButton.Text = "Find Min";
            this.findMinButton.UseVisualStyleBackColor = true;
            this.findMinButton.Click += new System.EventHandler(this.findMinButton_Click);
            // 
            // findMaxButton
            // 
            this.findMaxButton.Location = new System.Drawing.Point(256, 43);
            this.findMaxButton.Name = "findMaxButton";
            this.findMaxButton.Size = new System.Drawing.Size(75, 23);
            this.findMaxButton.TabIndex = 8;
            this.findMaxButton.Text = "Find Max";
            this.findMaxButton.UseVisualStyleBackColor = true;
            this.findMaxButton.Click += new System.EventHandler(this.findMaxButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.Location = new System.Drawing.Point(256, 72);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(75, 23);
            this.rootButton.TabIndex = 9;
            this.rootButton.Text = "Root";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.rootButton_Click);
            // 
            // textBoxFindMin
            // 
            this.textBoxFindMin.Location = new System.Drawing.Point(337, 16);
            this.textBoxFindMin.Name = "textBoxFindMin";
            this.textBoxFindMin.ReadOnly = true;
            this.textBoxFindMin.Size = new System.Drawing.Size(61, 20);
            this.textBoxFindMin.TabIndex = 10;
            // 
            // textBoxFindMax
            // 
            this.textBoxFindMax.Location = new System.Drawing.Point(337, 45);
            this.textBoxFindMax.Name = "textBoxFindMax";
            this.textBoxFindMax.ReadOnly = true;
            this.textBoxFindMax.Size = new System.Drawing.Size(61, 20);
            this.textBoxFindMax.TabIndex = 11;
            // 
            // textBoxRoot
            // 
            this.textBoxRoot.Location = new System.Drawing.Point(337, 74);
            this.textBoxRoot.Name = "textBoxRoot";
            this.textBoxRoot.ReadOnly = true;
            this.textBoxRoot.Size = new System.Drawing.Size(61, 20);
            this.textBoxRoot.TabIndex = 12;
            // 
            // isEmptyButton
            // 
            this.isEmptyButton.Location = new System.Drawing.Point(445, 12);
            this.isEmptyButton.Name = "isEmptyButton";
            this.isEmptyButton.Size = new System.Drawing.Size(75, 23);
            this.isEmptyButton.TabIndex = 13;
            this.isEmptyButton.Text = "is Empty?";
            this.isEmptyButton.UseVisualStyleBackColor = true;
            this.isEmptyButton.Click += new System.EventHandler(this.isEmptyButton_Click);
            // 
            // makeEmptyButton
            // 
            this.makeEmptyButton.Location = new System.Drawing.Point(445, 42);
            this.makeEmptyButton.Name = "makeEmptyButton";
            this.makeEmptyButton.Size = new System.Drawing.Size(75, 23);
            this.makeEmptyButton.TabIndex = 14;
            this.makeEmptyButton.Text = "Make Empty";
            this.makeEmptyButton.UseVisualStyleBackColor = true;
            this.makeEmptyButton.Click += new System.EventHandler(this.makeEmptyButton_Click);
            // 
            // removeMinButton
            // 
            this.removeMinButton.Location = new System.Drawing.Point(445, 72);
            this.removeMinButton.Name = "removeMinButton";
            this.removeMinButton.Size = new System.Drawing.Size(75, 23);
            this.removeMinButton.TabIndex = 15;
            this.removeMinButton.Text = "Remove Min";
            this.removeMinButton.UseVisualStyleBackColor = true;
            this.removeMinButton.Click += new System.EventHandler(this.removeMinButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 269);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(549, 22);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.Location = new System.Drawing.Point(13, 102);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(523, 160);
            this.listBox.TabIndex = 17;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Bst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 291);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.removeMinButton);
            this.Controls.Add(this.makeEmptyButton);
            this.Controls.Add(this.isEmptyButton);
            this.Controls.Add(this.textBoxRoot);
            this.Controls.Add(this.textBoxFindMax);
            this.Controls.Add(this.textBoxFindMin);
            this.Controls.Add(this.rootButton);
            this.Controls.Add(this.findMaxButton);
            this.Controls.Add(this.findMinButton);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxRemove);
            this.Controls.Add(this.textBoxInsert);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.fillArrayButton);
            this.Name = "Bst";
            this.Text = "BST";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fillArrayButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.TextBox textBoxRemove;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button findMinButton;
        private System.Windows.Forms.Button findMaxButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.TextBox textBoxFindMin;
        private System.Windows.Forms.TextBox textBoxFindMax;
        private System.Windows.Forms.TextBox textBoxRoot;
        private System.Windows.Forms.Button isEmptyButton;
        private System.Windows.Forms.Button makeEmptyButton;
        private System.Windows.Forms.Button removeMinButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

