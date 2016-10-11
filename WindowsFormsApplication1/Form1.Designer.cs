namespace WindowsFormsApplication1
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
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.tbxImageLink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(12, 33);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(120, 134);
            this.lbxItems.TabIndex = 0;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(159, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(159, 92);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(372, 192);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Confirm";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(259, 33);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(188, 20);
            this.tbxTitle.TabIndex = 5;
            // 
            // tbxText
            // 
            this.tbxText.Location = new System.Drawing.Point(259, 65);
            this.tbxText.Multiline = true;
            this.tbxText.Name = "tbxText";
            this.tbxText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxText.Size = new System.Drawing.Size(188, 95);
            this.tbxText.TabIndex = 6;
            // 
            // tbxImageLink
            // 
            this.tbxImageLink.Location = new System.Drawing.Point(259, 166);
            this.tbxImageLink.Name = "tbxImageLink";
            this.tbxImageLink.Size = new System.Drawing.Size(188, 20);
            this.tbxImageLink.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 277);
            this.Controls.Add(this.tbxImageLink);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.TextBox tbxImageLink;
    }
}

