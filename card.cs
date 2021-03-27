using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBoard
{
    public partial class card : Form
    {
        public int a = 0;
        public string tabletype;
        public List<int> keys = new List<int>();
        public card(int id, string listtype)
        {
            a = id;
            tabletype = listtype;
            
        InitializeComponent();
        }

        private void card_Load(object sender, EventArgs e)
        {
           

            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand sc;
                SqlDataReader rd;
            if (tabletype == "taskinfo")
            {
                
                try
                {
                    string sql = "select Tarih,Durum,YapılacakIs,Aciklama from IsTakibi where Id =@Id ";
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();
                    int i = 0;

                    while (rd.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = rd.GetValue(0).ToString();
                        dataGridView1.Rows[i].Cells[1].Value = rd.GetValue(1).ToString();
                        dataGridView1.Rows[i].Cells[2].Value = rd.GetValue(2).ToString();
                        dataGridView1.Rows[i].Cells[3].Value = rd.GetValue(3).ToString();
                        i++;
                    }

                    rd.Close();
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {
                    string sql = "Select Projeno,teknikuzman,işaciklaması,notlar,tarih,kartno,tahminisüre,gerceklesensüre from taskinfo where Id =@Id";
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();

                    while (rd.Read())
                    {

                        projeadı.Text = rd.GetValue(0).ToString();
                        teknikuz.Text = rd.GetValue(1).ToString();
                        işaciklama.Text = rd.GetValue(2).ToString();
                        notlar.Text = rd.GetValue(3).ToString();
                        tarih.Text = rd.GetValue(4).ToString();
                        kartno.Text = rd.GetValue(5).ToString();
                        tahminisüre.Text = TahminiSüreHesaplama().ToString()+"gün";
                        gerceklesensüre.Text = rd.GetValue(7).ToString();


                        if (rd.GetValue(0) != null)
                        {

                            sc.Dispose();
                            rd.Close();
                            con.Close();
                            break;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (tabletype == "taskinfo2")
            {

                try
                {
                    string sql = "select Tarih,Durum,YapılacakIs,Aciklama from IsTakibi2 where Id =@Id ";
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();
                    int i = 0;

                    while (rd.Read())
                    {

                        dataGridView1.Rows[i].Cells[0].Value = rd.GetValue(0).ToString();
                        dataGridView1.Rows[i].Cells[1].Value = rd.GetValue(1).ToString();
                        dataGridView1.Rows[i].Cells[2].Value = rd.GetValue(2).ToString();
                        dataGridView1.Rows[i].Cells[3].Value = rd.GetValue(3).ToString();

                        dataGridView1.Rows.Add();
                        i++;
                    }
                    rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               

                try
                {
                    string sql = "Select Projeno,teknikuzman,işaciklaması,notlar,tarih,kartno,tahminisüre,gerceklesensüre from taskinfo2 where Id =@Id";
                    con.Close();
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    SqlCommand scc;
                    SqlDataReader rdd;
                    scc = new SqlCommand(sql, conn);
                    scc.Parameters.AddWithValue("@Id", a);
                    rdd = scc.ExecuteReader();

                    while (rdd.Read())
                    {

                        projeadı.Text = rdd.GetValue(0).ToString();
                        teknikuz.Text = rdd.GetValue(1).ToString();
                        işaciklama.Text = rdd.GetValue(2).ToString();
                        notlar.Text = rdd.GetValue(3).ToString();
                        tarih.Text = rdd.GetValue(4).ToString();
                        kartno.Text = rdd.GetValue(5).ToString();
                        tahminisüre.Text = TahminiSüreHesaplama().ToString()+"gün";
                        gerceklesensüre.Text = rdd.GetValue(7).ToString();
                        if (rdd.GetValue(7) != null)
                        {
                            break;
                        }

                    }
                    scc.Dispose();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (tabletype == "taskinfo3")
            {

                try
                {
                    string sql = "select Tarih,Durum,YapılacakIs,Aciklama from IsTakibi3 where Id =@Id ";
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();
                    int i = 0;

                    while (rd.Read())
                    {

                        dataGridView1.Rows[i].Cells[0].Value = rd.GetValue(0).ToString();
                        dataGridView1.Rows[i].Cells[1].Value = rd.GetValue(1).ToString();
                        dataGridView1.Rows[i].Cells[2].Value = rd.GetValue(2).ToString();
                        dataGridView1.Rows[i].Cells[3].Value = rd.GetValue(3).ToString();

                        dataGridView1.Rows.Add();
                        i++;
                    }
                    rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                try
                {
                    string sql = "Select Projeno,teknikuzman,işaciklaması,notlar,tarih,kartno,tahminisüre,gerceklesensüre from taskinfo3 where Id =@Id";
                    con.Close();
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    SqlCommand scc;
                    SqlDataReader rdd;
                    scc = new SqlCommand(sql, conn);
                    scc.Parameters.AddWithValue("@Id", a);
                    rdd = scc.ExecuteReader();

                    while (rdd.Read())
                    {

                        projeadı.Text = rdd.GetValue(0).ToString();
                        teknikuz.Text = rdd.GetValue(1).ToString();
                        işaciklama.Text = rdd.GetValue(2).ToString();
                        notlar.Text = rdd.GetValue(3).ToString();
                        tarih.Text = rdd.GetValue(4).ToString();
                        kartno.Text = rdd.GetValue(5).ToString();
                        tahminisüre.Text = TahminiSüreHesaplama().ToString() + "gün";
                        gerceklesensüre.Text = rdd.GetValue(7).ToString();
                        if (rdd.GetValue(7) != null)
                        {
                            break;
                        }

                    }
                    scc.Dispose();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (tabletype == "taskinfo4")
            {

                try
                {
                    string sql = "select Tarih,Durum,YapılacakIs,Aciklama from IsTakibi4 where Id =@Id ";
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();
                    int i = 0;

                    while (rd.Read())
                    {

                        dataGridView1.Rows[i].Cells[0].Value = rd.GetValue(0).ToString();
                        dataGridView1.Rows[i].Cells[1].Value = rd.GetValue(1).ToString();
                        dataGridView1.Rows[i].Cells[2].Value = rd.GetValue(2).ToString();
                        dataGridView1.Rows[i].Cells[3].Value = rd.GetValue(3).ToString();

                        dataGridView1.Rows.Add();
                        i++;
                    }
                    rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                try
                {
                    string sql = "Select Projeno,teknikuzman,işaciklaması,notlar,tarih,kartno,tahminisüre,gerceklesensüre from taskinfo4 where Id =@Id";
                    con.Close();
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    SqlCommand scc;
                    SqlDataReader rdd;
                    scc = new SqlCommand(sql, conn);
                    scc.Parameters.AddWithValue("@Id", a);
                    rdd = scc.ExecuteReader();

                    while (rdd.Read())
                    {

                        projeadı.Text = rdd.GetValue(0).ToString();
                        teknikuz.Text = rdd.GetValue(1).ToString();
                        işaciklama.Text = rdd.GetValue(2).ToString();
                        notlar.Text = rdd.GetValue(3).ToString();
                        tarih.Text = rdd.GetValue(4).ToString();
                        kartno.Text = rdd.GetValue(5).ToString();
                        tahminisüre.Text = TahminiSüreHesaplama().ToString() + "gün";
                        gerceklesensüre.Text = rdd.GetValue(7).ToString();
                        if (rdd.GetValue(7) != null)
                        {
                            break;
                        }

                    }
                    scc.Dispose();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (tabletype == "taskinfo5")
            {

                try
                {
                    string sql = "select Tarih,Durum,YapılacakIs,Aciklama from IsTakibi5 where Id =@Id ";
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();
                    int i = 0;

                    while (rd.Read())
                    {

                        dataGridView1.Rows[i].Cells[0].Value = rd.GetValue(0).ToString();
                        dataGridView1.Rows[i].Cells[1].Value = rd.GetValue(1).ToString();
                        dataGridView1.Rows[i].Cells[2].Value = rd.GetValue(2).ToString();
                        dataGridView1.Rows[i].Cells[3].Value = rd.GetValue(3).ToString();

                        dataGridView1.Rows.Add();
                        i++;
                    }
                    rd.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                try
                {
                    string sql = "Select Projeno,teknikuzman,işaciklaması,notlar,tarih,kartno,tahminisüre,gerceklesensüre from taskinfo5 where Id =@Id";
                    con.Close();
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    SqlCommand scc;
                    SqlDataReader rdd;
                    scc = new SqlCommand(sql, conn);
                    scc.Parameters.AddWithValue("@Id", a);
                    rdd = scc.ExecuteReader();

                    while (rdd.Read())
                    {

                        projeadı.Text = rdd.GetValue(0).ToString();
                        teknikuz.Text = rdd.GetValue(1).ToString();
                        işaciklama.Text = rdd.GetValue(2).ToString();
                        notlar.Text = rdd.GetValue(3).ToString();
                        tarih.Text = rdd.GetValue(4).ToString();
                        kartno.Text = rdd.GetValue(5).ToString();
                        tahminisüre.Text = TahminiSüreHesaplama().ToString() + "gün";
                        gerceklesensüre.Text = rdd.GetValue(7).ToString();
                        if (rdd.GetValue(7) != null)
                        {
                            break;
                        }

                    }
                    scc.Dispose();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";
      
        private void card_FormClosing(object sender, FormClosingEventArgs e)
        {

            Cardinfo ci = new Cardinfo();
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            if (tabletype == "taskinfo")
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [taskinfo] WHERE ([Id] = @Id)", con);
                check_User_Name.Parameters.AddWithValue("@Id", a);
                int UserExist = (int)check_User_Name.ExecuteScalar();
                MessageBox.Show(UserExist.ToString());
                if (UserExist >0)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("update IsTakibi(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + "','" + dataGridView1.Rows[i].Cells[2] + "','" + dataGridView1.Rows[i].Cells[3] + "','" + a + "') where id='" + a + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    UpdateData();
                }
                else{

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("insert into IsTakibi(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + Convert.ToDateTime(dataGridView1.Rows[i].Cells[0].Value) + "', '" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + a + "') ", con);
                        cmd.ExecuteNonQuery();
                    }
                    InsertData();

                }
            }
            if (tabletype == "taskinfo2")
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [taskinfo2] WHERE ([Id] = @Id)", con);
                check_User_Name.Parameters.AddWithValue("@Id", a);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("update IsTakibi2(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + "','" + dataGridView1.Rows[i].Cells[2] + "','" + dataGridView1.Rows[i].Cells[3] + "','" + a + "') where id='"+a+"'", con);
                        cmd.ExecuteNonQuery();
                    }
                    UpdateData();
                }
                else {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("insert into IsTakibi2(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + ",'" + dataGridView1.Rows[i].Cells[2] + ",'" + dataGridView1.Rows[i].Cells[3] + ",'" + a + ") ", con);
                        cmd.ExecuteNonQuery();
                    }
                    InsertData();
                }
            }

            if (tabletype == "taskinfo3")
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [taskinfo3] WHERE ([Id] = @Id)", con);
                check_User_Name.Parameters.AddWithValue("@Id", a);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("update IsTakibi3(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + "','" + dataGridView1.Rows[i].Cells[2] + "','" + dataGridView1.Rows[i].Cells[3] + "','" + a + "') where id='" + a + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    UpdateData();
                }
                else
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("insert into IsTakibi3(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + ",'" + dataGridView1.Rows[i].Cells[2] + ",'" + dataGridView1.Rows[i].Cells[3] + ",'" + a + ") ", con);
                        cmd.ExecuteNonQuery();
                    }
                    InsertData();
                }
            }

            if (tabletype == "taskinfo4")
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [taskinfo4] WHERE ([Id] = @Id)", con);
                check_User_Name.Parameters.AddWithValue("@Id", a);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("update IsTakibi4(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + "','" + dataGridView1.Rows[i].Cells[2] + "','" + dataGridView1.Rows[i].Cells[3] + "','" + a + "') where id='" + a + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    UpdateData();
                }
                else
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("insert into IsTakibi4(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + ",'" + dataGridView1.Rows[i].Cells[2] + ",'" + dataGridView1.Rows[i].Cells[3] + ",'" + a + ") ", con);
                        cmd.ExecuteNonQuery();
                    }
                    InsertData();
                }
            }

            if (tabletype == "taskinfo5")
            {
                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM [taskinfo5] WHERE ([Id] = @Id)", con);
                check_User_Name.Parameters.AddWithValue("@Id", a);
                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("update IsTakibi5(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + "','" + dataGridView1.Rows[i].Cells[2] + "','" + dataGridView1.Rows[i].Cells[3] + "','" + a + "') where id='" + a + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    UpdateData();
                }
                else
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlCommand cmd = new SqlCommand("insert into IsTakibi5(Tarih,Durum,YapılacakIs,Aciklama,Id) values('" + dataGridView1.Rows[i].Cells[0] + "', '" + dataGridView1.Rows[i].Cells[1] + ",'" + dataGridView1.Rows[i].Cells[2] + ",'" + dataGridView1.Rows[i].Cells[3] + ",'" + a + ") ", con);
                        cmd.ExecuteNonQuery();
                    }
                    InsertData();
                }
            }
        }

        private void InsertData()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();

            if (tabletype == "taskinfo")
            {

                SqlCommand cmd = new SqlCommand("dbo.insertdata", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);

                int i = cmd.ExecuteNonQuery();
            }
            else if (tabletype == "taskinfo2")
            {


                SqlCommand cmd = new SqlCommand("dbo.insertdata2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
            }

            else if (tabletype == "taskinfo3")
            {


                SqlCommand cmd = new SqlCommand("dbo.insertdata3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
            }

            else if (tabletype == "taskinfo4")
            {


                SqlCommand cmd = new SqlCommand("dbo.insertdata4", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
            }

            else if (tabletype == "taskinfo5")
            {


                SqlCommand cmd = new SqlCommand("dbo.insertdata5", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
            }
        }

        private void UpdateData()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (tabletype == "taskinfo")
            {
                SqlCommand cmd = new SqlCommand("dbo.updatedata", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
                int i = cmd.ExecuteNonQuery();
            }
            else if (tabletype=="taskinfo2")
            {
                SqlCommand cmd = new SqlCommand("dbo.updatedata2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
                int i = cmd.ExecuteNonQuery();

            }

            else if (tabletype == "taskinfo3")
            {
                SqlCommand cmd = new SqlCommand("dbo.updatedata3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
                int i = cmd.ExecuteNonQuery();

            }

            else if (tabletype == "taskinfo4")
            {
                SqlCommand cmd = new SqlCommand("dbo.updatedata4", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
                int i = cmd.ExecuteNonQuery();

            }

            else if (tabletype == "taskinfo5")
            {
                SqlCommand cmd = new SqlCommand("dbo.updatedata5", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@projeno", projeadı.Text);
                cmd.Parameters.AddWithValue("@teknikuzman", teknikuz.Text);
                cmd.Parameters.AddWithValue("@işaciklaması", işaciklama.Text);
                cmd.Parameters.AddWithValue("@notlar", notlar.Text);
                cmd.Parameters.AddWithValue("@tarih", Convert.ToDateTime(tarih.Text));
                cmd.Parameters.AddWithValue("@kartno", kartno.Text);
                cmd.Parameters.AddWithValue("@tahminisüre", TahminiSüreHesaplama().ToString());
                cmd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.Text);
                cmd.Parameters.AddWithValue("@Id", a);
                int i = cmd.ExecuteNonQuery();

            }
        }

        private int TahminiSüreHesaplama()
        {
            string Acıklama;
            var xValues = new double[]
                               {
                                  30,50,45,16,120,240
                               };
            var yValues = new double[]
                              {
                                  2,3,2.5,1,5.5,12
                              };

            double rSquared, intercept, slope;

            LinearRegression(xValues, yValues, out rSquared, out intercept, out slope);

            //Console.WriteLine($"R-squared = {rSquared}");
            //Console.WriteLine($"Intercept = {intercept}");
            //Console.WriteLine($"Slope = {slope}");


            int predictedValue = 0;
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand sc;
            SqlDataReader rd;
            if (tabletype == "taskinfo")
            {
                string sql = "Select Aciklama from IsTakibi where Id =@Id";

                try
                {
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();

                    while (rd.Read())
                    {

                        Acıklama = rd.GetValue(0).ToString();
                        


                            predictedValue += Convert.ToInt32( (slope * Convert.ToDouble(Acıklama.Length)) + intercept);
                            
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return 000;
                }
            }
            if (tabletype == "taskinfo2")
            {
                string sql = "Select Aciklama from IsTakibi2 where Id =@Id";

                try
                {

                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", a);
                    rd = sc.ExecuteReader();

                    while (rd.Read())
                    {

                        Acıklama = rd.GetValue(0).ToString();



                            predictedValue += Convert.ToInt32( (slope * Convert.ToInt32(Acıklama)) + intercept);

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return 000;
                }
            }
            return ((int)predictedValue);
        }

        public static void LinearRegression(
            double[] xVals,
            double[] yVals,
            out double rSquared,
            out double yIntercept,
            out double slope)
        {
            if (xVals.Length != yVals.Length)
            {
                throw new Exception("Input values should be with the same length.");
            }

            double sumOfX = 0;
            double sumOfY = 0;
            double sumOfXSq = 0;
            double sumOfYSq = 0;
            double sumCodeviates = 0;

            for (var i = 0; i < xVals.Length; i++)
            {
                var x = xVals[i];
                var y = yVals[i];
                sumCodeviates += x * y;
                sumOfX += x;
                sumOfY += y;
                sumOfXSq += x * x;
                sumOfYSq += y * y;
            }

            var count = xVals.Length;
            var ssX = sumOfXSq - ((sumOfX * sumOfX) / count);
            var ssY = sumOfYSq - ((sumOfY * sumOfY) / count);

            var rNumerator = (count * sumCodeviates) - (sumOfX * sumOfY);
            var rDenom = (count * sumOfXSq - (sumOfX * sumOfX)) * (count * sumOfYSq - (sumOfY * sumOfY));
            var sCo = sumCodeviates - ((sumOfX * sumOfY) / count);

            var meanX = sumOfX / count;
            var meanY = sumOfY / count;
            var dblR = rNumerator / Math.Sqrt(rDenom);

            rSquared = dblR * dblR;
            yIntercept = meanY - ((sCo / ssX) * meanX);
            slope = sCo / ssX;
        }
    }


}

