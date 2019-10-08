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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.groupsBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        //}

        private void MainForm_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.mysekAll". При необходимости она может быть перемещена или удалена.
            this.mysekAllTableAdapter.Fill(this.myDBDataSet.mysekAll);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.mysek2". При необходимости она может быть перемещена или удалена.
            this.mysek2TableAdapter.Fill(this.myDBDataSet.mysek2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.mysek1". При необходимости она может быть перемещена или удалена.
            this.mysek1TableAdapter.Fill(this.myDBDataSet.mysek1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Songs2". При необходимости она может быть перемещена или удалена.
            this.songs2TableAdapter.Fill(this.myDBDataSet.Songs2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.myDBDataSet.Albums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Performers". При необходимости она может быть перемещена или удалена.
            this.performersTableAdapter.Fill(this.myDBDataSet.Performers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.myDBDataSet.Groups);
            this.songsTableAdapter.Fill(this.myDBDataSet.Songs);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = true;
        }



        private void nameListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (link_videoLabel1.Text != "")
            {
                axVLCPlugin22.playlist.stop();
                axVLCPlugin22.playlist.items.clear();
                axVLCPlugin22.playlist.add(link_videoLabel1.Text);
                axVLCPlugin22.playlist.play();
            }
        }

        private void group_nameListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditGroupForm egf = new EditGroupForm();
            egf.ShowDialog();
            this.groupsTableAdapter.Fill(this.myDBDataSet.Groups);
        }
    }
}
