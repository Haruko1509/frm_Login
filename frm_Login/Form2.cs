using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace frm_Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static string sqlcon = "Data Source=LAPTOP-SKJ2KMRL\\SQLEXPRESS;Initial Catalog=QLBV;Persist Security Info=True;User ID=sa;Password=15092004;Encrypt=True;TrustServerCertificate=True";
        static SqlConnection con = new SqlConnection(sqlcon);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối nếu đang đóng
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    MessageBox.Show("Kết nối mở thành công!");
                }
                string query = "SELECT * FROM taikhoan WHERE tenDangNhap = '"+ textBox2.Text.Trim()+"'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                { SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    sdr.Fill(table);
                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show(textBox2.Text + "is already exit", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                string gioiTinh = "";
                if (radioButton1.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (radioButton2.Checked)
                {
                    gioiTinh = "Nữ";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Thoát nếu chưa chọn giới tính
                }
                string insertData = @"INSERT INTO taikhoan (tenDangNhap, hoVaTen, email, matKhau, gioiTinh, typeUser)
                                      VALUES (@tenDangNhap, @hoVaTen, @email, @matKhau, @gioiTinh, @typeUser)";
                    using (SqlCommand insertCmd = new SqlCommand(insertData, con))
                    {
                    insertCmd.Parameters.AddWithValue("@tenDangNhap",textBox2.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@hoVaTen",textBox4.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@email",textBox1.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@matKhau", textBox3.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                    insertCmd.Parameters.AddWithValue("@typeUser", "User");
                    int result = insertCmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo kết nối được đóng
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 lform = new Form1();
            lform.Show();
            this.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = checkBox2.Checked ? '\0' : '*';
        }
    }
}
