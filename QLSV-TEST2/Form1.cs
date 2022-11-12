using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLSV_TEST2
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        //co dau / nen them @
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select *from HocSinh";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nguoi dung chi dc doc
            txtMaHS.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaHS.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtNgaySinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDC.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDTB.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtML.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
        private void btnXemThôngTin_Click(object sender, EventArgs e)
        {
            QLSVDataContext db = new QLSVDataContext();
            dataGridView1.DataSource = db.HocSinhs.Select(d => d);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "insert into HocSinh values('"+txtMaHS.Text+"',N'"+txtTen.Text+"','"+dtNgaySinh.Text+"',N'"+txtDC.Text+"','"+txtDTB.Text+ "','" + txtML.Text + "')";
            //chi ra loi
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm thành công", "Thêm");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "delete from HocSinh where MaHS='" + txtMaHS.Text + "'";
            //chi ra loi
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Xoá thành công", "Xoá");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            //ko sua mahs vi do la primary key
            command.CommandText = "update HocSinh set TenHS= N'" + txtTen.Text + "', NgaySinh= '" + dtNgaySinh.Text+ "',DiaChi= N'" + txtDC.Text+ "',DTB= '" + txtDTB.Text+ "',MaLop= '" + txtML.Text + "'where MaHS = '" + txtMaHS.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa thành công", "Sửa");
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = "";
            txtTen.Text = "";
            dtNgaySinh.Text = "1/1/2000";
            txtDC.Text = "";
            txtDTB.Text = "";
            txtML.Text = "";
            MessageBox.Show("Khởi tạo thành công", "Khởi tạo");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            QLSVDataContext db = new QLSVDataContext();
            dataGridView1.DataSource = db.HocSinhs.Where(d => d.MaHS.Equals(txtTim.Text));
            MessageBox.Show("Tìm thành công", "Tìm");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có thực sự muốn thoát không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
