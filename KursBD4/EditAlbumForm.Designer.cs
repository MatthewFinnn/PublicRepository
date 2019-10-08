namespace KursBD
{
    partial class EditAlbumForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAlbumForm));
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label releaseLabel;
            System.Windows.Forms.Label coverLabel;
            System.Windows.Forms.Label id_groupLabel;
            this.myDBDataSet = new KursBD.MyDBDataSet();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsTableAdapter = new KursBD.MyDBDataSetTableAdapters.AlbumsTableAdapter();
            this.tableAdapterManager = new KursBD.MyDBDataSetTableAdapters.TableAdapterManager();
            this.albumsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.albumsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.coverTextBox = new System.Windows.Forms.TextBox();
            this.id_groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new KursBD.MyDBDataSetTableAdapters.GroupsTableAdapter();
            titleLabel = new System.Windows.Forms.Label();
            releaseLabel = new System.Windows.Forms.Label();
            coverLabel = new System.Windows.Forms.Label();
            id_groupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingNavigator)).BeginInit();
            this.albumsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumsTableAdapter = this.albumsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.mysek1TableAdapter = null;
            this.tableAdapterManager.mysek2TableAdapter = null;
            this.tableAdapterManager.mysekAllTableAdapter = null;
            this.tableAdapterManager.PerformersTableAdapter = null;
            this.tableAdapterManager.SongsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KursBD.MyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // albumsBindingNavigator
            // 
            this.albumsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.albumsBindingNavigator.BindingSource = this.albumsBindingSource;
            this.albumsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.albumsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.albumsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.albumsBindingNavigatorSaveItem});
            this.albumsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.albumsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.albumsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.albumsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.albumsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.albumsBindingNavigator.Name = "albumsBindingNavigator";
            this.albumsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.albumsBindingNavigator.Size = new System.Drawing.Size(559, 25);
            this.albumsBindingNavigator.TabIndex = 0;
            this.albumsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // albumsBindingNavigatorSaveItem
            // 
            this.albumsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.albumsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("albumsBindingNavigatorSaveItem.Image")));
            this.albumsBindingNavigatorSaveItem.Name = "albumsBindingNavigatorSaveItem";
            this.albumsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.albumsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.albumsBindingNavigatorSaveItem.Click += new System.EventHandler(this.albumsBindingNavigatorSaveItem_Click);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(12, 71);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(157, 20);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Название альбома:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.ForeColor = System.Drawing.Color.Navy;
            this.titleTextBox.Location = new System.Drawing.Point(175, 68);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(371, 26);
            this.titleTextBox.TabIndex = 2;
            // 
            // releaseLabel
            // 
            releaseLabel.AutoSize = true;
            releaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            releaseLabel.Location = new System.Drawing.Point(12, 105);
            releaseLabel.Name = "releaseLabel";
            releaseLabel.Size = new System.Drawing.Size(112, 20);
            releaseLabel.TabIndex = 3;
            releaseLabel.Text = "Дата выхода:";
            // 
            // releaseDateTimePicker
            // 
            this.releaseDateTimePicker.CalendarForeColor = System.Drawing.Color.Navy;
            this.releaseDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.releaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.albumsBindingSource, "release", true));
            this.releaseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releaseDateTimePicker.Location = new System.Drawing.Point(175, 100);
            this.releaseDateTimePicker.Name = "releaseDateTimePicker";
            this.releaseDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.releaseDateTimePicker.TabIndex = 4;
            // 
            // coverLabel
            // 
            coverLabel.AutoSize = true;
            coverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            coverLabel.Location = new System.Drawing.Point(12, 135);
            coverLabel.Name = "coverLabel";
            coverLabel.Size = new System.Drawing.Size(81, 20);
            coverLabel.TabIndex = 5;
            coverLabel.Text = "Обложка:";
            // 
            // coverTextBox
            // 
            this.coverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "cover", true));
            this.coverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coverTextBox.ForeColor = System.Drawing.Color.Navy;
            this.coverTextBox.Location = new System.Drawing.Point(175, 132);
            this.coverTextBox.Name = "coverTextBox";
            this.coverTextBox.Size = new System.Drawing.Size(371, 26);
            this.coverTextBox.TabIndex = 6;
            // 
            // id_groupLabel
            // 
            id_groupLabel.AutoSize = true;
            id_groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_groupLabel.Location = new System.Drawing.Point(12, 37);
            id_groupLabel.Name = "id_groupLabel";
            id_groupLabel.Size = new System.Drawing.Size(65, 20);
            id_groupLabel.TabIndex = 7;
            id_groupLabel.Text = "Группа:";
            // 
            // id_groupComboBox
            // 
            this.id_groupComboBox.DataSource = this.groupsBindingSource;
            this.id_groupComboBox.DisplayMember = "group_name";
            this.id_groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_groupComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_groupComboBox.ForeColor = System.Drawing.Color.Navy;
            this.id_groupComboBox.FormattingEnabled = true;
            this.id_groupComboBox.Location = new System.Drawing.Point(175, 34);
            this.id_groupComboBox.Name = "id_groupComboBox";
            this.id_groupComboBox.Size = new System.Drawing.Size(371, 28);
            this.id_groupComboBox.TabIndex = 8;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.myDBDataSet;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // EditAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 180);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(releaseLabel);
            this.Controls.Add(this.releaseDateTimePicker);
            this.Controls.Add(coverLabel);
            this.Controls.Add(this.coverTextBox);
            this.Controls.Add(id_groupLabel);
            this.Controls.Add(this.id_groupComboBox);
            this.Controls.Add(this.albumsBindingNavigator);
            this.Name = "EditAlbumForm";
            this.Text = "EditAlbumForm";
            this.Load += new System.EventHandler(this.EditAlbumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingNavigator)).EndInit();
            this.albumsBindingNavigator.ResumeLayout(false);
            this.albumsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private MyDBDataSetTableAdapters.AlbumsTableAdapter albumsTableAdapter;
        private MyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator albumsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton albumsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateTimePicker;
        private System.Windows.Forms.TextBox coverTextBox;
        private System.Windows.Forms.ComboBox id_groupComboBox;
        private MyDBDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
    }
}