namespace PointOfSaleApplication
{
    partial class FrmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            this.lblCategory = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.btnCloseCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPositionNo = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCategory.Location = new System.Drawing.Point(27, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(629, 59);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.BackgroundImage")));
            this.splitContainer1.Location = new System.Drawing.Point(27, 120);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.lbCategory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.btnCloseCategory);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdateCategory);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddCategory);
            this.splitContainer1.Panel2.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel2.Controls.Add(this.tbPositionNo);
            this.splitContainer1.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel2.Controls.Add(this.lblItemCode);
            this.splitContainer1.Size = new System.Drawing.Size(629, 233);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbCategory
            // 
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 16;
            this.lbCategory.Location = new System.Drawing.Point(8, 9);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(193, 212);
            this.lbCategory.TabIndex = 0;
            // 
            // btnCloseCategory
            // 
            this.btnCloseCategory.Location = new System.Drawing.Point(315, 163);
            this.btnCloseCategory.Name = "btnCloseCategory";
            this.btnCloseCategory.Size = new System.Drawing.Size(69, 28);
            this.btnCloseCategory.TabIndex = 18;
            this.btnCloseCategory.Text = "Close";
            this.btnCloseCategory.UseVisualStyleBackColor = true;
            this.btnCloseCategory.Click += new System.EventHandler(this.btnCloseCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Location = new System.Drawing.Point(230, 163);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(69, 28);
            this.btnUpdateCategory.TabIndex = 17;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(137, 163);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(69, 28);
            this.btnAddCategory.TabIndex = 16;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(150, 97);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(234, 27);
            this.tbDescription.TabIndex = 15;
            // 
            // tbPositionNo
            // 
            this.tbPositionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPositionNo.Location = new System.Drawing.Point(137, 46);
            this.tbPositionNo.Name = "tbPositionNo";
            this.tbPositionNo.Size = new System.Drawing.Size(230, 27);
            this.tbPositionNo.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(32, 99);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description:";
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblItemCode.Location = new System.Drawing.Point(32, 48);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(90, 20);
            this.lblItemCode.TabIndex = 12;
            this.lblItemCode.Text = "Item Code:";
            this.lblItemCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(682, 379);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblCategory);
            this.Name = "FrmCategory";
            this.Text = "FrmCategory";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbPositionNo;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.Button btnCloseCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox tbDescription;
    }
}