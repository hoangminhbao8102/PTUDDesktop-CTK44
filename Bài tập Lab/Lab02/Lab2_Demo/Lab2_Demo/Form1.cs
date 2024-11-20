namespace Lab2_Demo
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
            {
                s += int.Parse(lblTienTHA.Text.Split('.')[0]);
            }
            if (chkTinHocB.Checked)
            {
                s += int.Parse(lblTienTHB.Text.Split('.')[0]);
            }
            if (chkTiengAnhA.Checked)
            {
                s += int.Parse(lblTienTAA.Text.Split('.')[0]);
            }
            if (chkTiengAnhB.Checked)
            {
                s += int.Parse(lblTienTAB.Text.Split('.')[0]);
            }
            this.txtTongTien.Text = s + ".000 đồng";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = true;
            this.chkTiengAnhB.Checked = true;
            this.chkTinHocA.Checked = true;
            this.chkTinHocB.Checked = true;
            this.txtTongTien.Text = "";
        }
    }
}
