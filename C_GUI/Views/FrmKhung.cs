using C_GUI.ViewModels;

namespace C_GUI.Views
{
    public partial class FrmKhung : MetroFramework.Forms.MetroForm
    {
        private FrmTrangChu _frmTrangChu;
        public FrmTrangChu frmTrangChu { get { return _frmTrangChu; } set { _frmTrangChu = value; } }
        private FrmPhong _frmPhong;
        public FrmPhong frmPhong { get { return _frmPhong; } set { _frmPhong = value; } }
        private FrmHoaDon _frmHoaDon;
        public FrmHoaDon frmHoaDon { get { return _frmHoaDon; } set { _frmHoaDon = value; } }
        private FrmPhieuDichVu _frmPhieuDichVu;
        public FrmPhieuDichVu frmPhieuDichVu { get { return _frmPhieuDichVu; } set { _frmPhieuDichVu = value; } }
        private FrmKhachHang _frmKhachHang;
        public FrmKhachHang frmKhachHang { get { return _frmKhachHang; } set { _frmKhachHang = value; } }
        private FrmDichVu _frmDichVu;
        public FrmDichVu frmDichVu { get { return _frmDichVu; } set { _frmDichVu = value; } }
        private FrmLoaiPhong _frmLoaiPhong;
        public FrmLoaiPhong frmLoaiPhong { get { return _frmLoaiPhong; } set { _frmLoaiPhong = value; } }
        private FrmNhanVien _frmNhanVien;
        public FrmNhanVien frmNhanVien { get { return _frmNhanVien; } set { _frmNhanVien = value; } }
        private FrmThongKe _frmThongKe;
        public FrmThongKe frmThongKe { get { return _frmThongKe; } set { _frmThongKe = value; } }

        public static KhungViewModel khungVM;
        private Color _blueColorDefaul = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        private Color _whiteColorFontDefaul = Color.White;
        private Button _buttonSlideBarOldClicked;
        public FrmKhung()
        {
            InitializeComponent();
            InitialControlHandlers();
        }

        private void InitialControlHandlers()
        {
            //Khởi tạo khung VM
            khungVM = new KhungViewModel();

            this.Load += FrmKhung_Load;

            this.Activated += FrmKhung_AfterLoaded;

            btn_DangXuat.Click += Btn_DangXuat_Click;

            _buttonSlideBarOldClicked = new Button();

            // Thêm sự kiện click Tab btnTrangChu
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            this.btnPhieuDichVu.Click += new System.EventHandler(this.btnPhieuDichVu_Click);
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);


            // Khi load form, button Trang Chủ sẽ được nhấn
            object button1obj = btnTrangChu as object;
            button1_Click(button1obj, EventArgs.Empty);
            btnTrangChu_Click(button1obj, EventArgs.Empty);




            // Đồng hồ thời gian thực khởi chạy
            timer1.Start();
        }

        #region Chuyen TAB
        private void button1_Click(object sender, EventArgs e)
        {
            _buttonSlideBarOldClicked.BackColor = _blueColorDefaul;
            _buttonSlideBarOldClicked.ForeColor = _whiteColorFontDefaul;
            var button = sender as Button;
            _buttonSlideBarOldClicked = button;
            button.BackColor = _whiteColorFontDefaul;
            button.ForeColor = Form.DefaultForeColor;

        }
        private void btnThongKe_Click(object? sender, EventArgs e)
        {
            if (_frmThongKe == null)
            {
                _frmThongKe = new FrmThongKe();
                _frmThongKe.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmThongKe);
            }
            _frmThongKe.BringToFront();
            _frmThongKe.Show();
        }

        private void btnNhanVien_Click(object? sender, EventArgs e)
        {
            if (_frmNhanVien == null)
            {
                _frmNhanVien = new FrmNhanVien();
                _frmNhanVien.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmNhanVien);
            }
            _frmNhanVien.BringToFront();
            _frmNhanVien.Show();
        }

        private void btnLoaiPhong_Click(object? sender, EventArgs e)
        {
            if (_frmLoaiPhong == null)
            {
                _frmLoaiPhong = new FrmLoaiPhong();
                _frmLoaiPhong.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmLoaiPhong);
            }
            _frmLoaiPhong.BringToFront();
            _frmLoaiPhong.Show();
        }

        private void btnDichVu_Click(object? sender, EventArgs e)
        {
            if (_frmDichVu == null)
            {
                _frmDichVu = new FrmDichVu();
                _frmDichVu.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmDichVu);
            }
            _frmDichVu.BringToFront();
            _frmDichVu.Show();
        }

        private void btnKhachHang_Click(object? sender, EventArgs e)
        {
            if (_frmKhachHang == null)
            {
                _frmKhachHang = new FrmKhachHang();
                _frmKhachHang.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmKhachHang);
            }
            _frmKhachHang.BringToFront();
            _frmKhachHang.Show();
        }

        private void btnPhieuDichVu_Click(object? sender, EventArgs e)
        {
            if (_frmPhieuDichVu == null)
            {
                _frmPhieuDichVu = new FrmPhieuDichVu();
                _frmPhieuDichVu.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmPhieuDichVu);
            }
            _frmPhieuDichVu.BringToFront();
            _frmPhieuDichVu.Show();
        }

        private void btnHoaDon_Click(object? sender, EventArgs e)
        {
            if (_frmHoaDon == null)
            {
                _frmHoaDon = new FrmHoaDon();
                _frmHoaDon.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmHoaDon);
            }
            _frmHoaDon.BringToFront();
            _frmHoaDon.Show();
        }

        private void btnPhong_Click(object? sender, EventArgs e)
        {
            if (_frmPhong == null)
            {
                _frmPhong = new FrmPhong();
                _frmPhong.TopLevel = false;
                pnlNoiDungTab.Controls.Add(_frmPhong);
            }
            _frmPhong.BringToFront();
            _frmPhong.Show();
        }

        private void btnTrangChu_Click(object? sender, EventArgs e)
        {
            if (_frmTrangChu == null)
            {
                _frmTrangChu = new FrmTrangChu();
                _frmTrangChu.TopLevel = false;
                pnlNoiDungTab.Controls.Add(frmTrangChu);
            }
            frmTrangChu.BringToFront();
            frmTrangChu.Show();
        }
        #endregion

        private void Btn_DangXuat_Click(object? sender, EventArgs e)
        {
            khungVM.Execute(khungVM.LoadedCommand, this);
        }

        private void FrmKhung_Load(object? sender, EventArgs e)
        {
            //.Execute(khungVM.LoadedCommand, this);
        }

        private void FrmKhung_AfterLoaded(object? sender, EventArgs e)
        {
            this.Activated -= FrmKhung_AfterLoaded;
            khungVM.Execute(khungVM.LoadedCommand, this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.label8.Text = String.Format("{0:dddd, d/MM/yyyy}", now);
            this.label7.Text = String.Format("{0:hh:mm:ss tt}", now);
        }
    }
}
