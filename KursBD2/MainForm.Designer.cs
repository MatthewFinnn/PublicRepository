namespace KursBD
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label group_nameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label debutLabel;
            System.Windows.Forms.Label aliasLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label birthplaceLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label additionalLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label releaseLabel;
            System.Windows.Forms.Label id_groupLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new KursBD.MyDBDataSet();
            this.group_nameListBox = new System.Windows.Forms.ListBox();
            this.countryLabel1 = new System.Windows.Forms.Label();
            this.genreLabel1 = new System.Windows.Forms.Label();
            this.debutLabel1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.performersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aliasLabel1 = new System.Windows.Forms.Label();
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.birthdateLabel1 = new System.Windows.Forms.Label();
            this.birthplaceLabel1 = new System.Windows.Forms.Label();
            this.heightLabel1 = new System.Windows.Forms.Label();
            this.weightLabel1 = new System.Windows.Forms.Label();
            this.positionLabel1 = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.additionalLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupsTableAdapter = new KursBD.MyDBDataSetTableAdapters.GroupsTableAdapter();
            this.tableAdapterManager = new KursBD.MyDBDataSetTableAdapters.TableAdapterManager();
            this.performersTableAdapter = new KursBD.MyDBDataSetTableAdapters.PerformersTableAdapter();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new KursBD.MyDBDataSetTableAdapters.AlbumsTableAdapter();
            this.titleListBox = new System.Windows.Forms.ListBox();
            this.releaseLabel1 = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.id_groupTextBox = new System.Windows.Forms.TextBox();
            group_nameLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            debutLabel = new System.Windows.Forms.Label();
            aliasLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            birthplaceLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            additionalLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            releaseLabel = new System.Windows.Forms.Label();
            id_groupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // group_nameLabel
            // 
            group_nameLabel.AutoSize = true;
            group_nameLabel.Location = new System.Drawing.Point(12, 35);
            group_nameLabel.Name = "group_nameLabel";
            group_nameLabel.Size = new System.Drawing.Size(66, 13);
            group_nameLabel.TabIndex = 2;
            group_nameLabel.Text = "group name:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(12, 134);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(45, 13);
            countryLabel.TabIndex = 4;
            countryLabel.Text = "country:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(12, 157);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(37, 13);
            genreLabel.TabIndex = 6;
            genreLabel.Text = "genre:";
            // 
            // debutLabel
            // 
            debutLabel.AutoSize = true;
            debutLabel.Location = new System.Drawing.Point(12, 180);
            debutLabel.Name = "debutLabel";
            debutLabel.Size = new System.Drawing.Size(37, 13);
            debutLabel.TabIndex = 8;
            debutLabel.Text = "debut:";
            // 
            // aliasLabel
            // 
            aliasLabel.AutoSize = true;
            aliasLabel.Location = new System.Drawing.Point(21, 29);
            aliasLabel.Name = "aliasLabel";
            aliasLabel.Size = new System.Drawing.Size(31, 13);
            aliasLabel.TabIndex = 3;
            aliasLabel.Text = "alias:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(21, 55);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "name:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(21, 154);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(51, 13);
            birthdateLabel.TabIndex = 7;
            birthdateLabel.Text = "birthdate:";
            // 
            // birthplaceLabel
            // 
            birthplaceLabel.AutoSize = true;
            birthplaceLabel.Location = new System.Drawing.Point(21, 177);
            birthplaceLabel.Name = "birthplaceLabel";
            birthplaceLabel.Size = new System.Drawing.Size(56, 13);
            birthplaceLabel.TabIndex = 9;
            birthplaceLabel.Text = "birthplace:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(21, 200);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(39, 13);
            heightLabel.TabIndex = 11;
            heightLabel.Text = "height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(21, 223);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(41, 13);
            weightLabel.TabIndex = 13;
            weightLabel.Text = "weight:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(21, 246);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(46, 13);
            positionLabel.TabIndex = 15;
            positionLabel.Text = "position:";
            // 
            // additionalLabel
            // 
            additionalLabel.AutoSize = true;
            additionalLabel.Location = new System.Drawing.Point(21, 275);
            additionalLabel.Name = "additionalLabel";
            additionalLabel.Size = new System.Drawing.Size(55, 13);
            additionalLabel.TabIndex = 19;
            additionalLabel.Text = "additional:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(group_nameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.group_nameListBox);
            this.splitContainer1.Panel1.Controls.Add(countryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.countryLabel1);
            this.splitContainer1.Panel1.Controls.Add(genreLabel);
            this.splitContainer1.Panel1.Controls.Add(this.genreLabel1);
            this.splitContainer1.Panel1.Controls.Add(debutLabel);
            this.splitContainer1.Panel1.Controls.Add(this.debutLabel1);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(886, 564);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.myDBDataSet;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // group_nameListBox
            // 
            this.group_nameListBox.DataSource = this.groupsBindingSource;
            this.group_nameListBox.DisplayMember = "group_name";
            this.group_nameListBox.FormattingEnabled = true;
            this.group_nameListBox.Location = new System.Drawing.Point(84, 35);
            this.group_nameListBox.Name = "group_nameListBox";
            this.group_nameListBox.Size = new System.Drawing.Size(213, 95);
            this.group_nameListBox.TabIndex = 3;
            // 
            // countryLabel1
            // 
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "country", true));
            this.countryLabel1.Location = new System.Drawing.Point(84, 134);
            this.countryLabel1.Name = "countryLabel1";
            this.countryLabel1.Size = new System.Drawing.Size(213, 23);
            this.countryLabel1.TabIndex = 5;
            this.countryLabel1.Text = "label1";
            // 
            // genreLabel1
            // 
            this.genreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "genre", true));
            this.genreLabel1.Location = new System.Drawing.Point(84, 157);
            this.genreLabel1.Name = "genreLabel1";
            this.genreLabel1.Size = new System.Drawing.Size(213, 23);
            this.genreLabel1.TabIndex = 7;
            this.genreLabel1.Text = "label1";
            // 
            // debutLabel1
            // 
            this.debutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupsBindingSource, "debut", true));
            this.debutLabel1.Location = new System.Drawing.Point(84, 180);
            this.debutLabel1.Name = "debutLabel1";
            this.debutLabel1.Size = new System.Drawing.Size(213, 23);
            this.debutLabel1.TabIndex = 9;
            this.debutLabel1.Text = "label1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(titleLabel);
            this.splitContainer2.Panel1.Controls.Add(this.titleListBox);
            this.splitContainer2.Panel1.Controls.Add(releaseLabel);
            this.splitContainer2.Panel1.Controls.Add(this.releaseLabel1);
            this.splitContainer2.Panel1.Controls.Add(this.coverPictureBox);
            this.splitContainer2.Panel1.Controls.Add(id_groupLabel);
            this.splitContainer2.Panel1.Controls.Add(this.id_groupTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(aliasLabel);
            this.splitContainer2.Panel2.Controls.Add(this.aliasLabel1);
            this.splitContainer2.Panel2.Controls.Add(nameLabel);
            this.splitContainer2.Panel2.Controls.Add(this.nameListBox);
            this.splitContainer2.Panel2.Controls.Add(birthdateLabel);
            this.splitContainer2.Panel2.Controls.Add(this.birthdateLabel1);
            this.splitContainer2.Panel2.Controls.Add(birthplaceLabel);
            this.splitContainer2.Panel2.Controls.Add(this.birthplaceLabel1);
            this.splitContainer2.Panel2.Controls.Add(heightLabel);
            this.splitContainer2.Panel2.Controls.Add(this.heightLabel1);
            this.splitContainer2.Panel2.Controls.Add(weightLabel);
            this.splitContainer2.Panel2.Controls.Add(this.weightLabel1);
            this.splitContainer2.Panel2.Controls.Add(positionLabel);
            this.splitContainer2.Panel2.Controls.Add(this.positionLabel1);
            this.splitContainer2.Panel2.Controls.Add(this.imagePictureBox);
            this.splitContainer2.Panel2.Controls.Add(additionalLabel);
            this.splitContainer2.Panel2.Controls.Add(this.additionalLabel1);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(583, 562);
            this.splitContainer2.SplitterDistance = 194;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(568, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 562);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // performersBindingSource
            // 
            this.performersBindingSource.DataMember = "Groups_Performers";
            this.performersBindingSource.DataSource = this.groupsBindingSource;
            // 
            // aliasLabel1
            // 
            this.aliasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performersBindingSource, "alias", true));
            this.aliasLabel1.Location = new System.Drawing.Point(92, 29);
            this.aliasLabel1.Name = "aliasLabel1";
            this.aliasLabel1.Size = new System.Drawing.Size(120, 23);
            this.aliasLabel1.TabIndex = 4;
            this.aliasLabel1.Text = "label1";
            // 
            // nameListBox
            // 
            this.nameListBox.DataSource = this.performersBindingSource;
            this.nameListBox.DisplayMember = "name";
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(92, 55);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 95);
            this.nameListBox.TabIndex = 6;
            // 
            // birthdateLabel1
            // 
            this.birthdateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performersBindingSource, "birthdate", true));
            this.birthdateLabel1.Location = new System.Drawing.Point(92, 154);
            this.birthdateLabel1.Name = "birthdateLabel1";
            this.birthdateLabel1.Size = new System.Drawing.Size(120, 23);
            this.birthdateLabel1.TabIndex = 8;
            this.birthdateLabel1.Text = "label1";
            // 
            // birthplaceLabel1
            // 
            this.birthplaceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performersBindingSource, "birthplace", true));
            this.birthplaceLabel1.Location = new System.Drawing.Point(92, 177);
            this.birthplaceLabel1.Name = "birthplaceLabel1";
            this.birthplaceLabel1.Size = new System.Drawing.Size(120, 23);
            this.birthplaceLabel1.TabIndex = 10;
            this.birthplaceLabel1.Text = "label1";
            // 
            // heightLabel1
            // 
            this.heightLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performersBindingSource, "height", true));
            this.heightLabel1.Location = new System.Drawing.Point(92, 200);
            this.heightLabel1.Name = "heightLabel1";
            this.heightLabel1.Size = new System.Drawing.Size(120, 23);
            this.heightLabel1.TabIndex = 12;
            this.heightLabel1.Text = "label1";
            // 
            // weightLabel1
            // 
            this.weightLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performersBindingSource, "weight", true));
            this.weightLabel1.Location = new System.Drawing.Point(92, 223);
            this.weightLabel1.Name = "weightLabel1";
            this.weightLabel1.Size = new System.Drawing.Size(120, 23);
            this.weightLabel1.TabIndex = 14;
            this.weightLabel1.Text = "label1";
            // 
            // positionLabel1
            // 
            this.positionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performersBindingSource, "position", true));
            this.positionLabel1.Location = new System.Drawing.Point(92, 246);
            this.positionLabel1.Name = "positionLabel1";
            this.positionLabel1.Size = new System.Drawing.Size(120, 23);
            this.positionLabel1.TabIndex = 16;
            this.positionLabel1.Text = "label1";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.performersBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(306, 3);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(274, 368);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 18;
            this.imagePictureBox.TabStop = false;
            // 
            // additionalLabel1
            // 
            this.additionalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performersBindingSource, "additional", true));
            this.additionalLabel1.Location = new System.Drawing.Point(92, 275);
            this.additionalLabel1.Name = "additionalLabel1";
            this.additionalLabel1.Size = new System.Drawing.Size(120, 23);
            this.additionalLabel1.TabIndex = 20;
            this.additionalLabel1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(15, 562);
            this.button2.TabIndex = 0;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.mysek1TableAdapter = null;
            this.tableAdapterManager.mysek2TableAdapter = null;
            this.tableAdapterManager.mysekAllTableAdapter = null;
            this.tableAdapterManager.PerformersTableAdapter = null;
            this.tableAdapterManager.SongsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KursBD.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // performersTableAdapter
            // 
            this.performersTableAdapter.ClearBeforeFill = true;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Groups_Albums";
            this.albumsBindingSource.DataSource = this.groupsBindingSource;
            // 
            // albumsTableAdapter
            // 
            this.albumsTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(21, 35);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(26, 13);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "title:";
            // 
            // titleListBox
            // 
            this.titleListBox.DataSource = this.albumsBindingSource;
            this.titleListBox.DisplayMember = "title";
            this.titleListBox.FormattingEnabled = true;
            this.titleListBox.Location = new System.Drawing.Point(75, 35);
            this.titleListBox.Name = "titleListBox";
            this.titleListBox.Size = new System.Drawing.Size(120, 95);
            this.titleListBox.TabIndex = 2;
            // 
            // releaseLabel
            // 
            releaseLabel.AutoSize = true;
            releaseLabel.Location = new System.Drawing.Point(21, 134);
            releaseLabel.Name = "releaseLabel";
            releaseLabel.Size = new System.Drawing.Size(44, 13);
            releaseLabel.TabIndex = 3;
            releaseLabel.Text = "release:";
            // 
            // releaseLabel1
            // 
            this.releaseLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "release", true));
            this.releaseLabel1.Location = new System.Drawing.Point(75, 134);
            this.releaseLabel1.Name = "releaseLabel1";
            this.releaseLabel1.Size = new System.Drawing.Size(120, 23);
            this.releaseLabel1.TabIndex = 4;
            this.releaseLabel1.Text = "label1";
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.albumsBindingSource, "cover", true));
            this.coverPictureBox.Location = new System.Drawing.Point(270, 11);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(292, 225);
            this.coverPictureBox.TabIndex = 6;
            this.coverPictureBox.TabStop = false;
            // 
            // id_groupLabel
            // 
            id_groupLabel.AutoSize = true;
            id_groupLabel.Location = new System.Drawing.Point(21, 219);
            id_groupLabel.Name = "id_groupLabel";
            id_groupLabel.Size = new System.Drawing.Size(48, 13);
            id_groupLabel.TabIndex = 7;
            id_groupLabel.Text = "id group:";
            // 
            // id_groupTextBox
            // 
            this.id_groupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "id_group", true));
            this.id_groupTextBox.Location = new System.Drawing.Point(75, 216);
            this.id_groupTextBox.Name = "id_groupTextBox";
            this.id_groupTextBox.Size = new System.Drawing.Size(120, 20);
            this.id_groupTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musik";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private MyDBDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox group_nameListBox;
        private System.Windows.Forms.Label countryLabel1;
        private System.Windows.Forms.Label genreLabel1;
        private System.Windows.Forms.Label debutLabel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource performersBindingSource;
        private MyDBDataSetTableAdapters.PerformersTableAdapter performersTableAdapter;
        private System.Windows.Forms.Label aliasLabel1;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label birthdateLabel1;
        private System.Windows.Forms.Label birthplaceLabel1;
        private System.Windows.Forms.Label heightLabel1;
        private System.Windows.Forms.Label weightLabel1;
        private System.Windows.Forms.Label positionLabel1;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label additionalLabel1;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MyDBDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private System.Windows.Forms.ListBox titleListBox;
        private System.Windows.Forms.Label releaseLabel1;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.TextBox id_groupTextBox;
    }
}

