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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvPods = new System.Windows.Forms.ListView();
            this.colEpisode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.tbNewCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.lvEpisodes = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeletePod = new System.Windows.Forms.Button();
            this.tbEpDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.colCategories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnUpdatePod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 241);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(163, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "URL";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ny Podcast";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvPods
            // 
            this.lvPods.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvPods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEpisode,
            this.colName,
            this.colCategory,
            this.colFrequency});
            this.lvPods.FullRowSelect = true;
            this.lvPods.Location = new System.Drawing.Point(12, 12);
            this.lvPods.Name = "lvPods";
            this.lvPods.Size = new System.Drawing.Size(420, 223);
            this.lvPods.TabIndex = 3;
            this.lvPods.UseCompatibleStateImageBehavior = false;
            this.lvPods.View = System.Windows.Forms.View.Details;
            this.lvPods.Click += new System.EventHandler(this.lvPods_Click);
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
            // colCategory
            // 
            this.colCategory.Text = "Kategori";
            this.colCategory.Width = 120;
            // 
            // colFrequency
            // 
            this.colFrequency.Text = "Frekvens";
            this.colFrequency.Width = 80;
            // 
            // cbFrequency
            // 
            this.cbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Items.AddRange(new object[] {
            "5",
            "15",
            "30",
            "60"});
            this.cbFrequency.Location = new System.Drawing.Point(181, 241);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(132, 21);
            this.cbFrequency.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(319, 241);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(113, 21);
            this.cbCategory.TabIndex = 7;
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCategories});
            this.lvCategory.FullRowSelect = true;
            this.lvCategory.Location = new System.Drawing.Point(464, 13);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(329, 222);
            this.lvCategory.TabIndex = 8;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            // 
            // tbNewCat
            // 
            this.tbNewCat.Location = new System.Drawing.Point(464, 241);
            this.tbNewCat.Name = "tbNewCat";
            this.tbNewCat.Size = new System.Drawing.Size(329, 20);
            this.tbNewCat.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(447, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 535);
            this.label1.TabIndex = 10;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(464, 268);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCat.TabIndex = 11;
            this.btnSaveCat.Text = "Spara";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click);
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(545, 268);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCat.TabIndex = 12;
            this.btnDeleteCat.Text = "Radera";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            this.btnDeleteCat.Click += new System.EventHandler(this.btnDeleteCat_Click);
            // 
            // lvEpisodes
            // 
            this.lvEpisodes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle});
            this.lvEpisodes.FullRowSelect = true;
            this.lvEpisodes.Location = new System.Drawing.Point(12, 327);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.Size = new System.Drawing.Size(420, 223);
            this.lvEpisodes.TabIndex = 13;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            this.lvEpisodes.View = System.Windows.Forms.View.Details;
            this.lvEpisodes.Click += new System.EventHandler(this.lvEpisodes_Click);
            // 
            // colTitle
            // 
            this.colTitle.Text = "Avsnitt";
            this.colTitle.Width = 416;
            // 
            // btnDeletePod
            // 
            this.btnDeletePod.Location = new System.Drawing.Point(181, 268);
            this.btnDeletePod.Name = "btnDeletePod";
            this.btnDeletePod.Size = new System.Drawing.Size(132, 23);
            this.btnDeletePod.TabIndex = 15;
            this.btnDeletePod.Text = "Radera";
            this.btnDeletePod.UseVisualStyleBackColor = true;
            this.btnDeletePod.Click += new System.EventHandler(this.btnDeletePod_Click);
            // 
            // tbEpDescription
            // 
            this.tbEpDescription.Location = new System.Drawing.Point(464, 343);
            this.tbEpDescription.Multiline = true;
            this.tbEpDescription.Name = "tbEpDescription";
            this.tbEpDescription.ReadOnly = true;
            this.tbEpDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEpDescription.Size = new System.Drawing.Size(329, 207);
            this.tbEpDescription.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(464, 327);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(83, 13);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Sammanfattning";
            // 
            // colCategories
            // 
            this.colCategories.Text = "Kategori";
            this.colCategories.Width = 325;
            // 
            // btnUpdatePod
            // 
            this.btnUpdatePod.Location = new System.Drawing.Point(319, 268);
            this.btnUpdatePod.Name = "btnUpdatePod";
            this.btnUpdatePod.Size = new System.Drawing.Size(113, 23);
            this.btnUpdatePod.TabIndex = 19;
            this.btnUpdatePod.Text = "Uppdatera";
            this.btnUpdatePod.UseVisualStyleBackColor = true;
            this.btnUpdatePod.Click += new System.EventHandler(this.btnUpdatePod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 562);
            this.Controls.Add(this.btnUpdatePod);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbEpDescription);
            this.Controls.Add(this.btnDeletePod);
            this.Controls.Add(this.lvEpisodes);
            this.Controls.Add(this.btnDeleteCat);
            this.Controls.Add(this.btnSaveCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNewCat);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbFrequency);
            this.Controls.Add(this.lvPods);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Podcast Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColumnHeader colEpisode;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colFrequency;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListView lvPods;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.TextBox tbNewCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Button btnDeleteCat;
        private System.Windows.Forms.ListView lvEpisodes;
        private System.Windows.Forms.Button btnDeletePod;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.TextBox tbEpDescription;
        public System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ColumnHeader colCategories;
        private System.Windows.Forms.Button btnUpdatePod;
    }
}

