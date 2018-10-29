namespace Podcast2
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
            this.lbList = new System.Windows.Forms.ListBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvPods = new System.Windows.Forms.ListView();
            this.colEpisode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.Location = new System.Drawing.Point(12, 657);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(716, 134);
            this.lbList.TabIndex = 0;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 309);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(163, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "URL";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ny Podcast";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvPods
            // 
            this.lvPods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEpisode,
            this.colName,
            this.colCategory,
            this.colFrequency});
            this.lvPods.Location = new System.Drawing.Point(12, 12);
            this.lvPods.Name = "lvPods";
            this.lvPods.Size = new System.Drawing.Size(420, 291);
            this.lvPods.TabIndex = 3;
            this.lvPods.UseCompatibleStateImageBehavior = false;
            this.lvPods.View = System.Windows.Forms.View.Details;
            // 
            // colEpisode
            // 
            this.colEpisode.Text = "Avsnitt";
            this.colEpisode.Width = 50;
            // 
            // colName
            // 
            this.colName.Text = "Namn";
            this.colName.Width = 166;
            // 
            // colFrequency
            // 
            this.colFrequency.Text = "Frekvens";
            this.colFrequency.Width = 80;
            // 
            // colCategory
            // 
            this.colCategory.Text = "Kategori";
            this.colCategory.Width = 120;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update List";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbFrequency
            // 
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Items.AddRange(new object[] {
            "5:e Minut",
            "10:e Minut",
            "15:e Minut",
            "30:e Minut",
            "60:e Minut"});
            this.cbFrequency.Location = new System.Drawing.Point(181, 308);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(132, 21);
            this.cbFrequency.TabIndex = 6;
            this.cbFrequency.Text = "Uppdateringsfrekvens";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Kategori 1",
            "Kategori 2",
            "Kategori 3",
            "Kategori 4",
            "Kategori 5",
            "Kategori 6",
            "Kategori 7",
            "Kategori 8",
            "Kategori 9",
            "Kategori 10"});
            this.cbCategory.Location = new System.Drawing.Point(319, 308);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(113, 21);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.Text = "Kategori 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 803);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbFrequency);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvPods);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lbList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader colEpisode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colFrequency;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListView lvPods;
    }
}

