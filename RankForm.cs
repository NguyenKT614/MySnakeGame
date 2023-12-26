using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class RankForm : Form
    {
        // Liên kết database
        private string connStr = @"Data Source=DESKTOP-B7G8SLV;Initial Catalog=LTTQ_Project;Integrated Security=True;Encrypt=False";

        // biến cho DataBase
        DateTime pTime;
        string pID = "", pName = "";
        int score;

        public RankForm()
        {
            InitializeComponent();
            LoadData();
        }

        public RankForm(DateTime pTime, string pID, string pName, int score)
        {
            InitializeComponent();
            this.pTime = pTime;
            this.pID = pID;
            this.pName = pName;
            this.score = score;
            addintoDatabase();
            LoadData();
        }

        // Lấy data từ CSDL
        private DataSet getdata()
        {
            DataSet dataSet = new DataSet();
            string query = "SELECT * FROM Player ORDER BY score DESC";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataSet);

                connection.Close();
            }
            return dataSet;

        }
        // Lưu thông tin người chơi vào database
        // Thêm dữ liệu người chơi vào trong CSDL
        private void addintoDatabase()
        {
            string query = @"
                            if (exists(select 1 from player where id = @id_value))
                                begin
                                    declare @HIGHER_score int,
                                            @PRE_score int,
                                            @PRESENT_score int
                                    set @PRESENT_score = @present_score_value
                                    
                                    select @PRE_score = score
                                    from player
                                    where id = @id_value

                                    if (@PRE_score > @PRESENT_score)
                                    begin 
                                        set @HIGHER_score = @PRE_score
                                    end
                                    else
                                    begin
                                        set @HIGHER_score = @PRESENT_score
                                    end

                                    update player
                                    set score = @HIGHER_score, time_played = @time_value
                                    where id = @id_value
                                end
                             else
                                begin
                                    insert into player(id,player_name,score,time_played) values (@id_value,@name_value,@present_score_value,@time_value)
                                end
                            ";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@id_value", pID);
                command.Parameters.AddWithValue("@name_value", pName);
                command.Parameters.AddWithValue("@present_score_value", score);
                command.Parameters.AddWithValue("@time_value", pTime.ToString());

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        // Load thông tin của database vào
        private void LoadData()
        {
            try
            {
                dataGridView1.DataSource = getdata().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
