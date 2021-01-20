namespace PointOfSaleApplication
{
    partial class FrmPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPosition));
            this.lblPostion = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeclare = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPositionNo = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbPositionNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPostion
            // 
            this.lblPostion.BackColor = System.Drawing.Color.Transparent;
            this.lblPostion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPostion.Location = new System.Drawing.Point(44, 59);
            this.lblPostion.Name = "lblPostion";
            this.lblPostion.Size = new System.Drawing.Size(629, 59);
            this.lblPostion.TabIndex = 0;
            this.lblPostion.Text = "Position";
            this.lblPostion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(44, 141);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeclare);
            this.splitContainer1.Panel2.Controls.Add(this.btnReplace);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer1.Panel2.Controls.Add(this.lblPositionNo);
            this.splitContainer1.Panel2.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel2.Controls.Add(this.tbPositionNo);
            this.splitContainer1.Size = new System.Drawing.Size(629, 274);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.53764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.46236F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(186, 245);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(292, 187);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeclare
            // 
            this.btnDeclare.Location = new System.Drawing.Point(211, 186);
            this.btnDeclare.Name = "btnDeclare";
            this.btnDeclare.Size = new System.Drawing.Size(75, 29);
            this.btnDeclare.TabIndex = 15;
            this.btnDeclare.Text = "Declare";
            this.btnDeclare.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(130, 186);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 30);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDescription.Location = new System.Drawing.Point(38, 116);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // lblPositionNo
            // 
            this.lblPositionNo.AutoSize = true;
            this.lblPositionNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionNo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPositionNo.Location = new System.Drawing.Point(38, 61);
            this.lblPositionNo.Name = "lblPositionNo";
            this.lblPositionNo.Size = new System.Drawing.Size(100, 20);
            this.lblPositionNo.TabIndex = 11;
            this.lblPositionNo.Text = "Position No:";
            this.lblPositionNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.Location = new System.Drawing.Point(169, 113);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(198, 27);
            this.tbDescription.TabIndex = 10;
            // 
            // tbPositionNo
            // 
            this.tbPositionNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPositionNo.Location = new System.Drawing.Point(169, 58);
            this.tbPositionNo.Name = "tbPositionNo";
            this.tbPositionNo.Size = new System.Drawing.Size(198, 27);
            this.tbPositionNo.TabIndex = 9;
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblPostion);
            this.Name = "FrmPosition";
            this.Text = "FrmPosition";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPostion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeclare;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPositionNo;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbPositionNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}