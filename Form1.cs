using ControlzEx.Standard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlzEx;
using System.Data.SqlServerCe;
using System.Data.Sql;
using System.Globalization;

namespace TaskBoard
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string projeadi;
        public string teknizukman;
        public string isaciklaması;
        public string notlar;
        public string tarih;
        public int kartno;
        public string tahminisüre;
        public string gerceklesensüre;

        public static int id;
        public string listtype;
        public Form1()
        {
            InitializeComponent();
            todolist.AllowDrop = true;
            inprogresslist.AllowDrop = true;
            revisionlist.AllowDrop = true;
            checklist.AllowDrop = true;
            donelist.AllowDrop = true;
        }
        
        private void todobutton_Click(object sender, EventArgs e)
        {
            if (todolist.Items.Count > 0)
            {
                id = todolist.Items.Count -1;
               
            }
            else
            {
                id = -1;
            }
            listtype = "taskinfo";
            card frm2 = new card(id,listtype);
           
            frm2.FormClosed += Frm2_FormClosed;
            frm2.ShowDialog();

            todolist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            todolist.DrawMode = DrawMode.OwnerDrawVariable;
            todolist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            todolist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.todolist);

        }

        private void Frm2_FormClosed(object sender, FormClosedEventArgs e)
        {

            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";
        SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand sc;
            SqlDataReader rd;
            if (listtype == "taskinfo") { 
               string sql = "Select Projeno from taskinfo where Id =@Id";

            try
            {
                sc = new SqlCommand(sql, con);
                sc.Parameters.AddWithValue("@Id", id);
                rd = sc.ExecuteReader();

                while (rd.Read())
                {
                    
                    todolist.Items.Add(rd.GetValue(0).ToString());
                    if (rd.GetValue(0) != null)
                    {
                        break;
                    }

                }
                sc.Dispose();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

            if (listtype == "taskinfo2")
            {
                string sql = "Select Projeno from taskinfo2 where Id =@Id";

                try
                {
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", id);
                    rd = sc.ExecuteReader();

                    while (rd.Read())
                    {

                        todolist.Items.Add(rd.GetValue(0).ToString());
                        if (rd.GetValue(0) != null)
                        {
                            break;
                        }

                    }
                    sc.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (listtype == "taskinfo3")
            {
                string sql = "Select Projeno from taskinfo3 where Id =@Id";

                try
                {
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", id);
                    rd = sc.ExecuteReader();

                    while (rd.Read())
                    {

                        todolist.Items.Add(rd.GetValue(0).ToString());
                        if (rd.GetValue(0) != null)
                        {
                            break;
                        }

                    }
                    sc.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (listtype == "taskinfo4")
            {
                string sql = "Select Projeno from taskinfo4 where Id =@Id";

                try
                {
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", id);
                    rd = sc.ExecuteReader();

                    while (rd.Read())
                    {

                        todolist.Items.Add(rd.GetValue(0).ToString());
                        if (rd.GetValue(0) != null)
                        {
                            break;
                        }

                    }
                    sc.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (listtype == "taskinfo5")
            {
                string sql = "Select Projeno from taskinfo5 where Id =@Id";

                try
                {
                    sc = new SqlCommand(sql, con);
                    sc.Parameters.AddWithValue("@Id", id);
                    rd = sc.ExecuteReader();

                    while (rd.Read())
                    {

                        todolist.Items.Add(rd.GetValue(0).ToString());
                        if (rd.GetValue(0) != null)
                        {
                            break;
                        }

                    }
                    sc.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void todolist_DrawItem(object sender, DrawItemEventArgs e)
        {

            ListBox theListBox = (ListBox)sender;
         
            Rectangle rect2 = new Rectangle(e.Bounds.X+10, e.Bounds.Y, e.Bounds.Width-20, e.Bounds.Height);

            if (theListBox.Items.Count >= 1)
            {
                Font font2 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
                TextFormatFlags flags = TextFormatFlags.WordBreak;
                TextRenderer.DrawText(e.Graphics, theListBox.Items[e.Index].ToString(), font2, rect2, Color.Black , flags);
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect2));
            }
            
            e.DrawFocusRectangle();
        }

        private void todolist_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            
            ListBox theListBox = (ListBox)sender;

            string itemString = (string)theListBox.Items[e.Index];

            string[] resultStrings = itemString.Split('.');

            if (resultStrings.Length > 2)
            {
                e.ItemHeight = 50;
            }
            else if(resultStrings.Length > 1)
            {
                e.ItemHeight = 40;
            }
            else
            {
                e.ItemHeight = 30;
            }
           
        }

        private void todolist_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks != 1)
            {
                todolist.MouseDoubleClick += new MouseEventHandler(todolist_MouseDoubleClick);
                return;
            }
            inprogresslist.DoDragDrop(todolist.SelectedItem.ToString(), DragDropEffects.Copy);
          
        }

        private void todolist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            int index = this.todolist.IndexFromPoint(e.Location);
            listtype = "taskinfo";
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                card frm2 = new card(index-1,listtype);
                frm2.ShowDialog();

            }
        }

        private void inprogresslist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
       
        private void inprogresslist_DragDrop(object sender, DragEventArgs e)
        {

            int index = todolist.SelectedIndex - 1;
            inprogresslist.Items.Add(e.Data.GetData(DataFormats.Text));
            todolist.Items.Remove(e.Data.GetData(DataFormats.Text));

            int index2 = inprogresslist.Items.Count-2;

            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            SqlCommand cm = new SqlCommand("select *from taskinfo where id=@id", con);
            cm.Parameters.AddWithValue("@id", index);
            SqlDataReader query = cm.ExecuteReader();

            while (query.Read())
            {
                string projeadi = query.GetValue(0).ToString();
                string teknizukman = query.GetValue(1).ToString();
                string isaciklaması = query.GetValue(2).ToString();
                string notlar = query.GetValue(3).ToString();
                string tarih = query.GetValue(4).ToString();
                int kartno = Convert.ToInt32(query.GetValue(5));
                string tahminisüre = query.GetValue(6).ToString();
                string gerceklesensüre = query.GetValue(7).ToString();
                if (query.GetValue(7) != null)
                {
                    query.Close();
                    con.Close();
                    con.Open();
                    SqlCommand cmdd = new SqlCommand("dbo.insertdata2", con);
                    cmdd.CommandType = CommandType.StoredProcedure;
                    cmdd.Parameters.AddWithValue("@projeno", projeadi.ToString());
                    cmdd.Parameters.AddWithValue("@teknikuzman", teknizukman.ToString());
                    cmdd.Parameters.AddWithValue("@işaciklaması", isaciklaması.ToString());
                    cmdd.Parameters.AddWithValue("@notlar", notlar.ToString());
                    cmdd.Parameters.AddWithValue("@tarih", tarih);
                    cmdd.Parameters.AddWithValue("@kartno", kartno);
                    cmdd.Parameters.AddWithValue("@tahminisüre", tahminisüre.ToString());
                    cmdd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.ToString());
                    cmdd.Parameters.AddWithValue("@Id", index2);

                    int i = cmdd.ExecuteNonQuery();
                    break;
                }
            }

            con.Close();
            con.Open();


            SqlCommand cmd = new SqlCommand("delete from taskinfo where Id=@Id", con);

            cmd.Parameters.AddWithValue("@Id", index);

            int j = cmd.ExecuteNonQuery();



        }

        private void revisionlist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;

            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void checklist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void donelist_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void revisionlist_DragDrop(object sender, DragEventArgs e)
        {
            int index = todolist.SelectedIndex - 1;
            revisionlist.Items.Add(e.Data.GetData(DataFormats.Text));
            todolist.Items.Remove(e.Data.GetData(DataFormats.Text));

            int index2 = revisionlist.Items.Count - 2;

            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            SqlCommand cm = new SqlCommand("select *from taskinfo where id=@id", con);
            cm.Parameters.AddWithValue("@id", index);
            SqlDataReader query = cm.ExecuteReader();

            while (query.Read())
            {
                string projeadi = query.GetValue(0).ToString();
                string teknizukman = query.GetValue(1).ToString();
                string isaciklaması = query.GetValue(2).ToString();
                string notlar = query.GetValue(3).ToString();
                string tarih = query.GetValue(4).ToString();
                int kartno = Convert.ToInt32(query.GetValue(5));
                string tahminisüre = query.GetValue(6).ToString();
                string gerceklesensüre = query.GetValue(7).ToString();
                if (query.GetValue(7) != null)
                {
                    query.Close();
                    con.Close();
                    con.Open();
                    SqlCommand cmdd = new SqlCommand("dbo.insertdata3", con);
                    cmdd.CommandType = CommandType.StoredProcedure;
                    cmdd.Parameters.AddWithValue("@projeno", projeadi.ToString());
                    cmdd.Parameters.AddWithValue("@teknikuzman", teknizukman.ToString());
                    cmdd.Parameters.AddWithValue("@işaciklaması", isaciklaması.ToString());
                    cmdd.Parameters.AddWithValue("@notlar", notlar.ToString());
                    cmdd.Parameters.AddWithValue("@tarih", tarih);
                    cmdd.Parameters.AddWithValue("@kartno", kartno);
                    cmdd.Parameters.AddWithValue("@tahminisüre", tahminisüre.ToString());
                    cmdd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.ToString());
                    cmdd.Parameters.AddWithValue("@Id", index2);

                    int i = cmdd.ExecuteNonQuery();
                    break;
                }
            }

            con.Close();
            con.Open();


            SqlCommand cmd = new SqlCommand("delete from taskinfo where Id=@Id", con);

            cmd.Parameters.AddWithValue("@Id", index);

            int j = cmd.ExecuteNonQuery();
        }

        private void checklist_DragDrop(object sender, DragEventArgs e)
        {
            int index = todolist.SelectedIndex - 1;
           checklist.Items.Add(e.Data.GetData(DataFormats.Text));
            todolist.Items.Remove(e.Data.GetData(DataFormats.Text));

            int index2 = checklist.Items.Count - 2;

            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            SqlCommand cm = new SqlCommand("select *from taskinfo where id=@id", con);
            cm.Parameters.AddWithValue("@id", index);
            SqlDataReader query = cm.ExecuteReader();

            while (query.Read())
            {
                string projeadi = query.GetValue(0).ToString();
                string teknizukman = query.GetValue(1).ToString();
                string isaciklaması = query.GetValue(2).ToString();
                string notlar = query.GetValue(3).ToString();
                string tarih = query.GetValue(4).ToString();
                int kartno = Convert.ToInt32(query.GetValue(5));
                string tahminisüre = query.GetValue(6).ToString();
                string gerceklesensüre = query.GetValue(7).ToString();
                if (query.GetValue(7) != null)
                {
                    query.Close();
                    con.Close();
                    con.Open();
                    SqlCommand cmdd = new SqlCommand("dbo.insertdata4", con);
                    cmdd.CommandType = CommandType.StoredProcedure;
                    cmdd.Parameters.AddWithValue("@projeno", projeadi.ToString());
                    cmdd.Parameters.AddWithValue("@teknikuzman", teknizukman.ToString());
                    cmdd.Parameters.AddWithValue("@işaciklaması", isaciklaması.ToString());
                    cmdd.Parameters.AddWithValue("@notlar", notlar.ToString());
                    cmdd.Parameters.AddWithValue("@tarih", tarih);
                    cmdd.Parameters.AddWithValue("@kartno", kartno);
                    cmdd.Parameters.AddWithValue("@tahminisüre", tahminisüre.ToString());
                    cmdd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.ToString());
                    cmdd.Parameters.AddWithValue("@Id", index2);

                    int i = cmdd.ExecuteNonQuery();
                    break;
                }
            }

            con.Close();
            con.Open();


            SqlCommand cmd = new SqlCommand("delete from taskinfo where Id=@Id", con);

            cmd.Parameters.AddWithValue("@Id", index);

            int j = cmd.ExecuteNonQuery();
        }

        private void donelist_DragDrop(object sender, DragEventArgs e)
        {
            int index = todolist.SelectedIndex - 1;
            donelist.Items.Add(e.Data.GetData(DataFormats.Text));
            todolist.Items.Remove(e.Data.GetData(DataFormats.Text));

            int index2 = donelist.Items.Count - 2;

            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";

            SqlConnection con = new SqlConnection(constring);
            con.Open();

            SqlCommand cm = new SqlCommand("select *from taskinfo where id=@id", con);
            cm.Parameters.AddWithValue("@id", index);
            SqlDataReader query = cm.ExecuteReader();

            while (query.Read())
            {
                string projeadi = query.GetValue(0).ToString();
                string teknizukman = query.GetValue(1).ToString();
                string isaciklaması = query.GetValue(2).ToString();
                string notlar = query.GetValue(3).ToString();
                string tarih = query.GetValue(4).ToString();
                int kartno = Convert.ToInt32(query.GetValue(5));
                string tahminisüre = query.GetValue(6).ToString();
                string gerceklesensüre = query.GetValue(7).ToString();
                if (query.GetValue(7) != null)
                {
                    query.Close();
                    con.Close();
                    con.Open();
                    SqlCommand cmdd = new SqlCommand("dbo.insertdata5", con);
                    cmdd.CommandType = CommandType.StoredProcedure;
                    cmdd.Parameters.AddWithValue("@projeno", projeadi.ToString());
                    cmdd.Parameters.AddWithValue("@teknikuzman", teknizukman.ToString());
                    cmdd.Parameters.AddWithValue("@işaciklaması", isaciklaması.ToString());
                    cmdd.Parameters.AddWithValue("@notlar", notlar.ToString());
                    cmdd.Parameters.AddWithValue("@tarih", tarih);
                    cmdd.Parameters.AddWithValue("@kartno", kartno);
                    cmdd.Parameters.AddWithValue("@tahminisüre", tahminisüre.ToString());
                    cmdd.Parameters.AddWithValue("@gerceklesensüre", gerceklesensüre.ToString());
                    cmdd.Parameters.AddWithValue("@Id", index2);

                    int i = cmdd.ExecuteNonQuery();
                    break;
                }
            }

            con.Close();
            con.Open();


            SqlCommand cmd = new SqlCommand("delete from taskinfo where Id=@Id", con);

            cmd.Parameters.AddWithValue("@Id", index);

            int j = cmd.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todolist.ItemHeight = 120;
            todolist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            todolist.DrawMode = DrawMode.OwnerDrawVariable;
            todolist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            todolist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.todolist);
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=taskcard;Integrated Security=True";

            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand sc;
            SqlDataReader rd;
            string sql = "Select işaciklaması from taskinfo where Id IS NOT NULL";

            try
            {
                sc = new SqlCommand(sql, con);
                
                rd = sc.ExecuteReader();

                while (rd.Read())
                {

                    todolist.Items.Add(rd.GetValue(0).ToString());

                }
                sc.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            inprogresslist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            inprogresslist.DrawMode = DrawMode.OwnerDrawVariable;
            inprogresslist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            inprogresslist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.inprogresslist);
            con.Open();
            SqlCommand sc2;
            SqlDataReader rd2;
            string sql2 = "Select işaciklaması from taskinfo2 where Id IS NOT NULL";

            try
            {
                sc2 = new SqlCommand(sql2, con);

                rd2 = sc2.ExecuteReader();

                while (rd2.Read())
                {

                    inprogresslist.Items.Add(rd2.GetValue(0).ToString());

                }
                sc2.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            revisionlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            revisionlist.DrawMode = DrawMode.OwnerDrawVariable;
            revisionlist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            revisionlist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.revisionlist);
            con.Open();
            SqlCommand sc3;
            SqlDataReader rd3;
            string sql3 = "Select işaciklaması from taskinfo3 where Id IS NOT NULL";

            try
            {
                sc3 = new SqlCommand(sql3, con);

                rd3 = sc3.ExecuteReader();

                while (rd3.Read())
                {

                    inprogresslist.Items.Add(rd3.GetValue(0).ToString());

                }
                sc3.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            checklist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            checklist.DrawMode = DrawMode.OwnerDrawVariable;
            checklist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            revisionlist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.checklist);
            con.Open();
            SqlCommand sc4;
            SqlDataReader rd4;
            string sql4 = "Select işaciklaması from taskinfo4 where Id IS NOT NULL";

            try
            {
                sc4 = new SqlCommand(sql4, con);

                rd4 = sc4.ExecuteReader();

                while (rd4.Read())
                {

                    inprogresslist.Items.Add(rd4.GetValue(0).ToString());

                }
                sc4.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            donelist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            donelist.DrawMode = DrawMode.OwnerDrawVariable;
            donelist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            donelist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.donelist);
            con.Open();
            SqlCommand sc5;
            SqlDataReader rd5;
            string sql5 = "Select işaciklaması from taskinfo5 where Id IS NOT NULL";

            try
            {
                sc5 = new SqlCommand(sql5, con);

                rd5 = sc5.ExecuteReader();

                while (rd5.Read())
                {

                    inprogresslist.Items.Add(rd5.GetValue(0).ToString());

                }
                sc5.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void inprogressbutton_Click(object sender, EventArgs e)
        {
            if (inprogresslist.Items.Count > 0)
            {
                id = inprogresslist.Items.Count - 1;

            }
            else
            {
                id = -1;
            }
            listtype = "taskinfo2";
            card frm2 = new card(id, listtype);
           
            frm2.FormClosed += Frm2_FormClosed;
            frm2.ShowDialog();


            inprogresslist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            inprogresslist.DrawMode = DrawMode.OwnerDrawVariable;
            inprogresslist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            inprogresslist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.inprogresslist);
        }

        private void inprogresslist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = inprogresslist.SelectedIndex ;
            listtype = "taskinfo2";
                card frm2 = new card(index - 1, listtype);
                frm2.ShowDialog();

        }

        private void revisionbutton_Click(object sender, EventArgs e)
        {
            if (revisionlist.Items.Count > 0)
            {
                id = revisionlist.Items.Count - 1;

            }
            else
            {
                id = -1;
            }
            listtype = "taskinfo3";
            card frm2 = new card(id, listtype);

            frm2.FormClosed += Frm2_FormClosed;
            frm2.ShowDialog();


            revisionlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            revisionlist.DrawMode = DrawMode.OwnerDrawVariable;
            revisionlist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            revisionlist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.revisionlist);
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            if (checklist.Items.Count > 0)
            {
                id = checklist.Items.Count - 1;

            }
            else
            {
                id = -1;
            }
            listtype = "taskinfo4";
            card frm2 = new card(id, listtype);

            frm2.FormClosed += Frm2_FormClosed;
            frm2.ShowDialog();


            checklist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            checklist.DrawMode = DrawMode.OwnerDrawVariable;
            checklist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            inprogresslist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.checklist);
        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            if (donelist.Items.Count > 0)
            {
                id = donelist.Items.Count - 1;

            }
            else
            {
                id = -1;
            }
            listtype = "taskinfo5";
            card frm2 = new card(id, listtype);

            frm2.FormClosed += Frm2_FormClosed;
            frm2.ShowDialog();


            donelist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            donelist.DrawMode = DrawMode.OwnerDrawVariable;
            donelist.MeasureItem +=
                new MeasureItemEventHandler(todolist_MeasureItem);
            donelist.DrawItem += new DrawItemEventHandler(todolist_DrawItem);
            this.Controls.Add(this.donelist);
        }

        private void revisionlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = revisionlist.SelectedIndex;
            listtype = "taskinfo3";
            card frm2 = new card(index - 1, listtype);
            frm2.ShowDialog();
        }

        private void checklist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = checklist.SelectedIndex;
            listtype = "taskinfo4";
            card frm2 = new card(index - 1, listtype);
            frm2.ShowDialog();
        }

        private void donelist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = donelist.SelectedIndex;
            listtype = "taskinfo5";
            card frm2 = new card(index - 1, listtype);
            frm2.ShowDialog();
        }
    }
}
