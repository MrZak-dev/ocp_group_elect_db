namespace electrika
{
    partial class Pannes
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
            this.pannesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pannesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pannesGrid
            // 
            this.pannesGrid.AllowUserToAddRows = false;
            this.pannesGrid.AllowUserToDeleteRows = false;
            this.pannesGrid.AllowUserToResizeRows = false;
            this.pannesGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pannesGrid.BackgroundColor = System.Drawing.Color.White;
            this.pannesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pannesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pannesGrid.Location = new System.Drawing.Point(18, 16);
            this.pannesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannesGrid.MultiSelect = false;
            this.pannesGrid.Name = "pannesGrid";
            this.pannesGrid.ReadOnly = true;
            this.pannesGrid.RowHeadersVisible = false;
            this.pannesGrid.RowHeadersWidth = 51;
            this.pannesGrid.RowTemplate.Height = 24;
            this.pannesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pannesGrid.Size = new System.Drawing.Size(614, 308);
            this.pannesGrid.TabIndex = 0;
            // 
            // Pannes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 340);
            this.Controls.Add(this.pannesGrid);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pannes";
            this.Text = "Pannes";
            this.Load += new System.EventHandler(this.Pannes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pannesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView pannesGrid;
    }
}