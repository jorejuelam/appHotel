using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appHotel
{
    public partial class frmIndex : Form
    {
        //630; 458 tamaño del tabcontrol final
        //622; 390 tamaño de cada tabPage final

        //prueba del uso de githb

        bool hotel = true;
        bool Guest = true;

        private List<TabPage> roomTabPages = new List<TabPage>();
        private List<TabPage> hotelTabPages = new List<TabPage>();
        private List<TabPage> guestTabPages = new List<TabPage>();
        private List<TabPage> mHostingTabPages = new List<TabPage>();
        private TabPage checkInTabPage = new TabPage();
        private TabPage checkOutTabPage = new TabPage();
        public frmIndex()
        {
            InitializeComponent();
            verificar();
            getTabPagesByFunctionality();
        }

        void getTabPagesByFunctionality()
        {
            foreach (TabPage page in tcManage.TabPages)
            {
                if (page.Text.Contains("Room"))
                {
                    roomTabPages.Add(page);
                }
                else if (page.Text.Contains("Guest"))
                {
                    guestTabPages.Add(page);
                }
                else if (page.Text.Contains("Hotel"))
                {
                    hotelTabPages.Add(page);
                }
                else if (page.Text.Contains("Hosting"))
                {
                    mHostingTabPages.Add(page);
                }
                else if (page.Text.Equals("Check In"))
                {
                    checkInTabPage = page;
                }
                else if (page.Text.Equals("Check Out"))
                {
                    checkOutTabPage = page;
                }
            }
            tcManage.TabPages.Clear();
        }

        void fillTabControlList(List<TabPage> list)
        {
            tcManage.TabPages.Clear();
            foreach (TabPage page in list)
            {
                tcManage.TabPages.Add(page);
            }
        }

        void fillTabControlOne(TabPage page)
        {
            tcManage.TabPages.Clear();
            tcManage.TabPages.Add(page);
        }

        void verificar()
        {
            if (!hotel)
            {
                btnManageGuest.Location = new Point(0, 199);
                pnDivisorMGuest.Location = new Point(0, 240);

                btnCheckIn.Visible = false;
                btnManageRoom.Visible = false;
                btnCheckOut.Visible = false;
                btnManageHosting.Visible = false;

                pnDivisorEHosting.Visible = false;
                pnDivisorMRoom.Visible = false;
                pnDivisorTOHosting.Visible = false;
                pnDivisorMHosting.Visible = false;
            }
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            fillTabControlList(roomTabPages);
        }

        private void btnManageHotel_Click(object sender, EventArgs e)
        {
            fillTabControlList(hotelTabPages);
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            fillTabControlOne(checkInTabPage);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            fillTabControlOne(checkOutTabPage);
        }

        private void btnManageGuest_Click(object sender, EventArgs e)
        {
            fillTabControlList(guestTabPages);
        }

        private void btnManageHosting_Click(object sender, EventArgs e)
        {
            fillTabControlList(mHostingTabPages);
        }
    }
}