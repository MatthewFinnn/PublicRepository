using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursBD
{
    public partial class EditAlbumForm : Form
    {
        public EditAlbumForm()
        {
            InitializeComponent();
        }

        private void albumsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.albumsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void EditAlbumForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.myDBDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.myDBDataSet.Albums);

        }
    }
}
