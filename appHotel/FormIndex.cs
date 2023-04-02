using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appHotel
{
    public partial class frmIndex : Form
    {
        //630; 458 tamaño del tabcontrol final
        //622; 390 tamaño de cada tabPage final

        //prueba del uso de githb

        //2

        bool hotel = false;
        bool guest = false;

        private List<TabPage> roomTabPages = new List<TabPage>();
        private List<TabPage> hotelTabPages = new List<TabPage>();

        private List<TabPage> hotelTabPagesNotExist = new List<TabPage>();
        private List<TabPage> guestTabPagesNotExist = new List<TabPage>();
        private List<TabPage> hotelTabPagesExist = new List<TabPage>();
        private List<TabPage> guestTabPagesExist = new List<TabPage>();

        private List<TabPage> guestTabPages = new List<TabPage>();
        private List<TabPage> mHostingTabPages = new List<TabPage>();
        private TabPage checkInTabPage = new TabPage();
        private TabPage checkOutTabPage = new TabPage();

        public frmIndex()
        {
            InitializeComponent();
            getTabPagesByFunctionality();
            checkFunctions();
        }

        void fillAuxList()
        {
            foreach (TabPage page in guestTabPages)
            {
                guestTabPagesExist.Add(page);
                if (page.Text.Equals("Insert Guest"))
                {
                    guestTabPagesNotExist.Add(page);
                }
            }

            foreach (TabPage page in hotelTabPages)
            {
                if (page.Text.Equals("Insert Hotel"))
                {
                    hotelTabPagesNotExist.Add(page);
                }
                else
                {
                    hotelTabPagesExist.Add(page);
                }
            }
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
            fillAuxList();
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

        void checkFunctions()
        {
            if (!hotel && !guest)
            {
                btnCheckIn.Visible = false;
                btnManageRoom.Visible = false;
                btnCheckOut.Visible = false;
                btnManageHosting.Visible = false;

                pnDivisorCheckIn.Visible = false;
                pnDivisorMRoom.Visible = false;
                pnDivisorCheckOut.Visible = false;
                pnDivisorMHosting.Visible = false;

                hotelTabPages = hotelTabPagesNotExist;
                guestTabPages = guestTabPagesNotExist;
            }
            else if (!hotel && guest)
            {
                btnCheckIn.Visible = false;
                btnManageRoom.Visible = false;
                btnCheckOut.Visible = false;
                btnManageHosting.Visible = false;

                pnDivisorCheckIn.Visible = false;
                pnDivisorMRoom.Visible = false;
                pnDivisorCheckOut.Visible = false;
                pnDivisorMHosting.Visible = false;

                hotelTabPages = hotelTabPagesNotExist;
                guestTabPages = guestTabPagesExist;
            }
            else if (hotel && !guest)
            {
                btnManageRoom.Visible = true;

                pnDivisorMRoom.Visible = true;

                hotelTabPages = hotelTabPagesExist;
                guestTabPages = guestTabPagesNotExist;
            }
            else
            {
                btnCheckIn.Visible = true;
                btnManageRoom.Visible = true;
                btnCheckOut.Visible = true;
                btnManageHosting.Visible = true;

                pnDivisorCheckIn.Visible = true;
                pnDivisorMRoom.Visible = true;
                pnDivisorCheckOut.Visible = true;
                pnDivisorMHosting.Visible = true;

                hotelTabPages = hotelTabPagesExist;
                guestTabPages = guestTabPagesExist;
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

        private void btnIHEnter_Click(object sender, EventArgs e)
        {
            if (!hotel)
            {
                hotel = true;
                checkFunctions();
                fillTabControlList(hotelTabPages);
            }
        }
        private void btnIGEnter_Click(object sender, EventArgs e)
        {
            if (!guest)
            {
                guest = true;
                checkFunctions();
                fillTabControlList(guestTabPages);
            }
        }
    }
}