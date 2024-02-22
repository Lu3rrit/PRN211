using BussinessObject;
using DataAccess;
using DataAccess.Repository;
namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public MemberObject loginMember { get; set; }
        IMemberRepository memberRepository { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Welcome" + loginMember.Email;
        }
    }
}
