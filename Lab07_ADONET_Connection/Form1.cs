using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab07_ADONET_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DbConnectionFactory.Create())
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công: " + conn.Database);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}
