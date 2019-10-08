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

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Albums". При необходимости она может быть перемещена или удалена.
            this.albumsTableAdapter.Fill(this.myDBDataSet.Albums);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Performers". При необходимости она может быть перемещена или удалена.
            this.performersTableAdapter.Fill(this.myDBDataSet.Performers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Performers". При необходимости она может быть перемещена или удалена.
            this.performersTableAdapter.Fill(this.myDBDataSet.Performers);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDBDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.myDBDataSet.Groups);
            


        }

        private void groupsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDBDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = true;
        }

        private void performersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //imagePictureBox.ImageLocation = "https://banana.by/uploads/posts/2019-01/1548481504_banana.by-rossyp-02.jpg";
        }

    }
}
