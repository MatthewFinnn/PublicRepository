using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace KursBD
{
    public partial class EditSongForm : Form
    {
        enum Operation
        {
            Add = 1,  
            Edit, 
            Del,
            No
        }

        Operation op= Operation.No;
        string query;
        int index;
        int idAlbum;
        string name = "null", link_audio = "null", link_video = "null";
        string conn_param = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=abibok;Database=MyDB;";
        NpgsqlConnection conn;
        NpgsqlCommand comm;
        public EditSongForm()
        {
            InitializeComponent();
        }

        private void songsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            idAlbum = 0;
           
            bool converted = Int32.TryParse(label1.Text, out idAlbum);
            if (converted == false)
                return;
            switch (op)
            {
                case Operation.Add:
                    this.Validate();
                    this.songsBindingSource.EndEdit();
                    
                    if (songsDataGridView[1, index].Value.ToString() != "")
                        name = "'" + songsDataGridView[1, index].Value.ToString() + "'";
                    if (songsDataGridView[2, index].Value.ToString() != "")
                        link_audio = "'" + songsDataGridView[2, index].Value.ToString() + "'";
                    if (songsDataGridView[3, index].Value.ToString() != "")
                        link_video = "'" + songsDataGridView[3, index].Value.ToString() + "'";
                    query = "INSERT INTO public.\"Songs2\"(name, link_audio, link_video, id_album) VALUES(";
                        query += name + "," +
                            link_audio + "," +
                            link_video + "," +
                            idAlbum + ")";
                    break;
                case Operation.Del:
                    query = "DELETE FROM public.\"Songs2\" WHERE id_album="+ idAlbum+
                        " and name="+name;
                    break;
                case Operation.Edit:
                    this.Validate();
                    this.songsBindingSource.EndEdit();
                    if (songsDataGridView[1, index].Value.ToString() != "")
                        name = "'" + songsDataGridView[1, index].Value.ToString() + "'";
                    if (songsDataGridView[2, index].Value.ToString() != "")
                        link_audio = "'" + songsDataGridView[2, index].Value.ToString() + "'";
                    if (songsDataGridView[3, index].Value.ToString() != "")
                        link_video = "'" + songsDataGridView[3, index].Value.ToString() + "'";
                    query = "UPDATE public.\"Songs2\" SET " +
                        "name =" + name+", " +
                        "link_audio =" + link_audio+", " +
                        "link_video =" + link_video+" "+
                        "WHERE name='" +nameLabel1.Text+ "' and id_album="+label1.Text;
                    break;
            }

            comm = new NpgsqlCommand(query, conn);

            try
            {
                conn.Open(); //Открываем соединение.
                comm.ExecuteScalar();
                this.tableAdapterManager.UpdateAll(this.myDBDataSet);
            }
            catch (NpgsqlException ex) { }
            finally
            {
                conn.Close(); //Закрываем соединение. }
                op = Operation.No;
                name = "null"; link_audio = "null"; link_video = "null";
            }
        }

        private void EditSongForm_Load(object sender, EventArgs e)
        {
            this.groupsTableAdapter.Fill(this.myDBDataSet.Groups);
            this.albumsTableAdapter.Fill(this.myDBDataSet.Albums);
            this.songsTableAdapter.Fill(this.myDBDataSet.Songs);

            conn = new NpgsqlConnection(conn_param);

           
        }

        private void bindingNavigatorDeleteItem_MouseEnter(object sender, EventArgs e)
        {
            name = "'" + nameLabel1.Text + "'";
        }

        private void songsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (op == Operation.No)
            {
                op = Operation.Edit;
                index = e.RowIndex;
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            index = songsDataGridView.Rows.Count-1;
            op = Operation.Add;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {              
            op = Operation.Del;
        }
    }
}
