using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BOL;

namespace BugTracker
{
    public partial class MainMenu : DevExpress.XtraEditors.XtraForm
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Load += MainMenu_Load;           
        }

        void MainMenu_Load(object sender, EventArgs e)
        {
            if(Glob.User.RightID==9)
            {
                tileItem1.Visible = true;
                tileItem3.Visible = true;
            }
            else
            {
        
            }
        }
        public static void F_Show()
        {
            using (MainMenu dlg = new MainMenu())
            {

                dlg.ShowDialog();
            }
        }

        private void tileItem1_ItemClick(object sender,TileItemEventArgs e)
        {
            RegisterForm.F_Show();
        }
        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            Users.F_Show();
            
        }

        private void tileItem2_ItemClick_1(object sender, TileItemEventArgs e)
        {

            Tasks.F_Show();
        }

        
       

    }
    
}