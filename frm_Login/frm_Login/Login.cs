using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text; 

namespace frm_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string HashMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi sang chuỗi hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2").ToUpper());
                }
                return builder.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        static string sqlcon = "Data Source=LAPTOP-SKJ2KMRL\\SQLEXPRESS;Initial Catalog=QLBV;Persist Security Info=True;User ID=sa;Password=15092004;Encrypt=True;TrustServerCertificate=True";
        static SqlConnection con = new SqlConnection(sqlcon);
        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            { 
                // Mở kết nối nếu đang đóng
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    MessageBox.Show("Kết nối mở thành công!");
                }
                string tenDangNhapHash = HashMD5(textBox1.Text.Trim());
                string matKhauHash = HashMD5(textBox2.Text.Trim());

                // Truy vấn SQL tham số hóa
                string query = "SELECT matKhau FROM taikhoan WHERE tenDangNhap = @tenDangNhap";
                SqlCommand cmd = new SqlCommand(query, con);

                // Gắn tham số để đảm bảo bảo mật
                cmd.Parameters.AddWithValue("@tenDangNhap", tenDangNhapHash);
         

                // Thực thi truy vấn
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.HasRows)
                    {
                        sdr.Read(); // Đọc dòng đầu tiên

                        // So sánh mật khẩu
                        if (sdr["matKhau"].ToString().Equals(matKhauHash))
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại. Sai mật khẩu! " + sdr["matKhau"].ToString()+"\n"+matKhauHash, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi và hiển thị thông báo
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

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = check1.Checked ? '\0' : '*';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp sForm = new SignUp();
            sForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
