namespace electrika
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shema_pdf_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.technical_img = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equipement_nmbr_label = new System.Windows.Forms.Label();
            this.equipement_observation_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.technical_img)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 62);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(551, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.search_box, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de composant :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search_box
            // 
            this.search_box.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.search_box.Location = new System.Drawing.Point(196, 12);
            this.search_box.Margin = new System.Windows.Forms.Padding(4);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(333, 30);
            this.search_box.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.shema_pdf_btn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 207);
            this.panel2.TabIndex = 1;
            // 
            // shema_pdf_btn
            // 
            this.shema_pdf_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shema_pdf_btn.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.shema_pdf_btn.Image = ((System.Drawing.Image)(resources.GetObject("shema_pdf_btn.Image")));
            this.shema_pdf_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.shema_pdf_btn.Location = new System.Drawing.Point(456, 51);
            this.shema_pdf_btn.Margin = new System.Windows.Forms.Padding(0);
            this.shema_pdf_btn.Name = "shema_pdf_btn";
            this.shema_pdf_btn.Size = new System.Drawing.Size(112, 92);
            this.shema_pdf_btn.TabIndex = 2;
            this.shema_pdf_btn.Text = "Shema";
            this.shema_pdf_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.shema_pdf_btn.UseVisualStyleBackColor = false;
            this.shema_pdf_btn.Click += new System.EventHandler(this.Shema_pdf_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.technical_img);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 207);
            this.panel3.TabIndex = 0;
            // 
            // technical_img
            // 
            this.technical_img.Image = ((System.Drawing.Image)(resources.GetObject("technical_img.Image")));
            this.technical_img.Location = new System.Drawing.Point(4, 4);
            this.technical_img.Margin = new System.Windows.Forms.Padding(4);
            this.technical_img.Name = "technical_img";
            this.technical_img.Size = new System.Drawing.Size(378, 195);
            this.technical_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.technical_img.TabIndex = 0;
            this.technical_img.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(452, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Observation";
            // 
            // equipement_nmbr_label
            // 
            this.equipement_nmbr_label.AutoSize = true;
            this.equipement_nmbr_label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipement_nmbr_label.Location = new System.Drawing.Point(133, 40);
            this.equipement_nmbr_label.Name = "equipement_nmbr_label";
            this.equipement_nmbr_label.Size = new System.Drawing.Size(21, 23);
            this.equipement_nmbr_label.TabIndex = 2;
            this.equipement_nmbr_label.Text = "1";
            this.equipement_nmbr_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equipement_observation_label
            // 
            this.equipement_observation_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equipement_observation_label.AutoSize = true;
            this.equipement_observation_label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipement_observation_label.Location = new System.Drawing.Point(480, 39);
            this.equipement_observation_label.Name = "equipement_observation_label";
            this.equipement_observation_label.Size = new System.Drawing.Size(73, 23);
            this.equipement_observation_label.TabIndex = 3;
            this.equipement_observation_label.Text = "4000 A";
            this.equipement_observation_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.equipement_observation_label);
            this.panel4.Controls.Add(this.equipement_nmbr_label);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(650, 71);
            this.panel4.TabIndex = 2;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 340);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.technical_img)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox technical_img;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button shema_pdf_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label equipement_nmbr_label;
        private System.Windows.Forms.Label equipement_observation_label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
    }
}