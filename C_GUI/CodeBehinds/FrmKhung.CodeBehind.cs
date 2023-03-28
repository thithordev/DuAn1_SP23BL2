using C_GUI.ViewModels;

namespace C_GUI.Views
{
    partial class FrmKhung
    {
        private FrmTrangChu _frmTrangChu;
        public FrmTrangChu frmTrangChu { get { return _frmTrangChu; } set { _frmTrangChu = value; } }



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


            // Khi load form, button Trang Chủ sẽ được nhấn
            object button1obj = btnTrangChu as object;
            button1_Click(button1obj, EventArgs.Empty);
            btnTrangChu_Click(button1obj, EventArgs.Empty);


            // Đồng hồ thời gian thực khởi chạy
            timer1.Start();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            _buttonSlideBarOldClicked.BackColor = _blueColorDefaul;
            _buttonSlideBarOldClicked.ForeColor = _whiteColorFontDefaul;
            var button = sender as Button;
            _buttonSlideBarOldClicked = button;
            button.BackColor = _whiteColorFontDefaul;
            button.ForeColor = Form.DefaultForeColor;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.label8.Text = String.Format("{0:dddd, MM/d/yyyy}", now);
            this.label7.Text = String.Format("{0:hh:mm:ss tt}", now);
        }


    }
}