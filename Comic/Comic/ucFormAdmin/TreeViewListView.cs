using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
namespace Comic.ucFormAdmin
{
    public partial class TreeViewListView : UserControl
    {
        public TreeViewListView()
        {
            InitializeComponent();
        }
        public void loadTreeView()
        {
            string sChuoiTruyVan = @"select distinct [username] from [dbo].[history_user]";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sChuoiTruyVan);
            //DataTable dt = new DataTable();
            //dt.Load(readerstore);
            tvStore.Nodes.Clear();
            //while (readerstore.Read())
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string username = dt.Rows[i]["username"].ToString();
                //int storeid=dt.Rows[i][""]
                //  string username = readerstore.GetString(0);
                string query = string.Format("EXEC LayDate_S @username");
                // string q1 = string.Format("select [date_S] from date_username where username='{0}'", username);
                //   string query = @"select distinct date_S,history_user.username from [dbo].[history_user],[dbo].[user] where [history_user].[username]=[user].[username]";
                DataTable readerdate = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
                // SqlDataReader readerdate = DataProvider.Instance.TruyVanExecuteReader(q1);
                TreeNode nodeUser = new TreeNode();
                nodeUser.Text = username;
                nodeUser.Name = username;
                for (int j = 0; j < readerdate.Rows.Count; j++)
                {
                    string date = readerdate.Rows[j]["date_S"].ToString();
                    TreeNode nodeDate = new TreeNode();
                    nodeDate.Text = date;
                    nodeUser.Nodes.Add(nodeDate);
                    string query1 = string.Format("select distinct store_name,[history_user].[store_id] from history_user,[dbo].[store] where [history_user].[store_id]=[store].[store_id] and username='{0}' and date_s='{1}'", username, date);
                    DataTable readerstorename = DataProvider.Instance.ExecuteQuery(query1);
                    for(int k=0;k<readerstorename.Rows.Count;k++)
                    {
                        string storename = readerstorename.Rows[k]["store_name"].ToString();
                        int storeid = int.Parse(readerstorename.Rows[k]["store_id"].ToString());
                        TreeNode nodeStoreName = new TreeNode();
                        nodeStoreName.Text = storename;
                        string query2 = string.Format("select distinct chaptername from [history_user] where username='{0}' and date_S='{1}'  and store_id='{2}'", username, date, storeid);
                        DataTable readerchaptername = DataProvider.Instance.ExecuteQuery(query2);
                        nodeDate.Nodes.Add(nodeStoreName);
                        for(int l = 0; l < readerchaptername.Rows.Count; l++)
                        {
                                    string chapter_name = readerchaptername.Rows[l]["chaptername"].ToString();
                                    TreeNode nodeChapterName = new TreeNode();
                                     nodeChapterName.Text =chapter_name ;
                                     nodeStoreName.Nodes.Add(nodeChapterName);
                                    string query3 = string.Format("select time_S from [history_user] where username='{0}' and date_S='{1}'  and store_id='{2}' and chaptername=N'{3}'", username, date, storeid, chapter_name);
                                        DataTable readertime = DataProvider.Instance.ExecuteQuery(query3);
                            for (int o = 0; o < readertime.Rows.Count; o++)
                            {
                                string time = readertime.Rows[o]["time_S"].ToString();
                                TreeNode nodeTime = new TreeNode();
                                nodeTime.Text = time;             
                                nodeChapterName.Nodes.Add(nodeTime);
                            }
                        }
                    }
                }
                // //readerstore.Close();
                // while (readerdate.Read())
                // {
                //     string date = readerdate.GetString(0);
                //     //   // string storeid = readerdate.GetString(1);
                //     TreeNode nodeDate = new TreeNode();
                //     nodeDate.Text = date;
                //     nodeDate.Name = date;
                //     nodeUser.Nodes.Add(nodeDate);
                //      string query1 = string.Format("select distinct store_name,[history_user].[store_id] from history_user,[dbo].[store] where [history_user].[store_id]=[store].[store_id] and username='{0}' and date_s='{1}'", username,date);
                //     SqlDataReader readerstorename = DataProvider.Instance.TruyVanExecuteReader(query1);                 
                //     while(readerstorename.Read())
                //     {
                //         string storename = readerstorename.GetString(0);
                //         int storeid = readerstorename.GetInt32(1);
                //         TreeNode nodeStoreName = new TreeNode();
                //         nodeStoreName.Text = storename;
                //         nodeStoreName.Name = storename;
                //         nodeDate.Nodes.Add(nodeStoreName);
                //         string query2 = string.Format("select distinct chaptername from [history_user] where username='{0}' and date_S='{1}'  and store_id='{2}'", username, date, storeid);
                //         SqlDataReader readerchaptername = DataProvider.Instance.TruyVanExecuteReader(query2);
                //         while (readerchaptername.Read())
                //         {
                //             string chapter_name = readerchaptername.GetString(0);
                //             TreeNode nodeChapterName = new TreeNode();
                //             nodeChapterName.Text = chapter_name;
                //             nodeChapterName.Name = chapter_name;
                //             nodeStoreName.Nodes.Add(nodeChapterName);
                //             string query3 = string.Format("select time_S from [history_user] where username='{0}' and date_S='{1}'  and store_id='{2}' and chaptername=N'{3}'", username, date, storeid,chapter_name);
                //             SqlDataReader readertime = DataProvider.Instance.TruyVanExecuteReader(query3);
                //             while (readertime.Read())
                //             {
                //                 string time = readertime.GetString(0);
                //                 TreeNode nodeTime = new TreeNode();
                //                 nodeTime.Text = time;
                //                 nodeTime.Name = time;
                //                 nodeChapterName.Nodes.Add(nodeTime);
                //             }
                //         }
                //        // readerchaptername.Close();
                //     }
                //     //readerstorename.Close();
                // }
                tvStore.Nodes.Add(nodeUser);
                //readerdate.Close();      
            }
            // readerstore.Close();
        }

        private void TreeViewListView_Load(object sender, EventArgs e)
        {
            //loadTreeView();
            LoadcomboUserName();
            LoadcomboStar();
        }
        void LoadcomboUserName()
        {
            string sql = "select distinct username from history_user";
            DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
            cbUserName.DataSource = dt;
            cbUserName.DisplayMember = "username";
            cbUserName.ValueMember = "username";
        }
        void LoadcomboStar()
        {
            string sql = string.Format("select distinct star from [dbo].[store]");
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            cbSao.DataSource = dt;
            cbSao.DisplayMember = "star";
            cbSao.ValueMember = "star";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadTreeView();
        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select distinct date_S from history_user where username='{0}'", cbUserName.SelectedValue.ToString());
                DataTable dt = DataProvider.Instance.TruyVanDataTable(sql);
                cbDate.DataSource = dt;
                cbDate.DisplayMember = "date_S";
                cbDate.ValueMember = "date_S";
            }
            catch (SqlException)
            {
            }
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = string.Format("EXEC TruyVanTongLuotXem @username , @date");
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql, new object[] { cbUserName.SelectedValue.ToString(), cbDate.SelectedValue.ToString() });
            dgvHISTORY.DataSource = dt;
        }

        private void cbSao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select dbo.Tongtruyen('{0}') as TongTruyen", cbSao.SelectedValue.ToString());
                var dt = DataProvider.Instance.ExecuteScalar(sql);
                txtTongTruyen.Text = dt.ToString();
            }
            catch (SqlException)
            {
            }
        }

    }
}
