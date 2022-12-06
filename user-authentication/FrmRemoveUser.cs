using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_authentication
{
    public partial class FrmRemoveUser : Form
    {
        #region Singleton in the window
        private static FrmRemoveUser _instance;

        public static FrmRemoveUser GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new FrmRemoveUser();
            }

            return _instance;
        }
        #endregion

        //-- FrmRemoveUser
        public FrmRemoveUser()
        {
            InitializeComponent();
        }

        private void FrmRemoveUser_Load(object sender, EventArgs e)
        {
            cbxUsers.DataSource = UserRepository.FindAllUsers();
            cbxUsers.Text = "Select the user";
        }
        //--//

        //-- btnRemoveUser
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

        }
        //--//
    }
}
