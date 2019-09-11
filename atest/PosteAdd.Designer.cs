namespace electrika
{
    partial class PosteAdd
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
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.posteName = new System.Windows.Forms.TextBox();
            this.posteDescription = new System.Windows.Forms.RichTextBox();
            this.posteAddBtn = new System.Windows.Forms.Button();
            this.posteStation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(175)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(8, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ajouter un nouveau poste";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.91489F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.40425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.posteName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.posteDescription, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 54);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // posteName
            // 
            this.posteName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.posteName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posteName.Location = new System.Drawing.Point(120, 13);
            this.posteName.Name = "posteName";
            this.posteName.Size = new System.Drawing.Size(96, 28);
            this.posteName.TabIndex = 4;
            // 
            // posteDescription
            // 
            this.posteDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.posteDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posteDescription.Location = new System.Drawing.Point(337, 3);
            this.posteDescription.Name = "posteDescription";
            this.posteDescription.Size = new System.Drawing.Size(123, 48);
            this.posteDescription.TabIndex = 8;
            this.posteDescription.Text = "";
            // 
            // posteAddBtn
            // 
            this.posteAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posteAddBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posteAddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(175)))), ((int)(((byte)(50)))));
            this.posteAddBtn.Location = new System.Drawing.Point(196, 170);
            this.posteAddBtn.Name = "posteAddBtn";
            this.posteAddBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.posteAddBtn.Size = new System.Drawing.Size(100, 34);
            this.posteAddBtn.TabIndex = 15;
            this.posteAddBtn.Text = "Ajouter";
            this.posteAddBtn.UseVisualStyleBackColor = true;
            this.posteAddBtn.Click += new System.EventHandler(this.PosteAddBtn_Click);
            // 
            // posteStation
            // 
            this.posteStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.posteStation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posteStation.FormattingEnabled = true;
            this.posteStation.Location = new System.Drawing.Point(233, 127);
            this.posteStation.Name = "posteStation";
            this.posteStation.Size = new System.Drawing.Size(113, 29);
            this.posteStation.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Station";
            // 
            // PosteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 230);
            this.Controls.Add(this.posteStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.posteAddBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PosteAdd";
            this.Text = "PosteAdd";
            this.Load += new System.EventHandler(this.PosteAdd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox posteName;
        private System.Windows.Forms.RichTextBox posteDescription;
        private System.Windows.Forms.Button posteAddBtn;
        private System.Windows.Forms.ComboBox posteStation;
        private System.Windows.Forms.Label label4;
    }
}