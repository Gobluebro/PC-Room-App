using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Room_App
{
    public partial class formNewProfile : Form
    {
        #region multiple calls methods
        private void FormChange()
        {
            formSettings frm = new formSettings();
            frm.Show();
            Visible = false;
        }
        private void FolderLocate(string location)
        {
            if (location == "WoW")
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtWoWLoc.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else if(location == "AddOn")
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtAddons.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else 
            {
                //location should be "OW"
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtOWLoc.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }
        #endregion

        public formNewProfile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormChange();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: Save profile
            if (chkOW.Checked)
            {

            }
            if (chkWOW.Checked)
            {

            }

            FormChange();
        }

        #region browse calls
        private void btnBrowseWoW_Click(object sender, EventArgs e)
        {
            FolderLocate("WoW");
        }
        private void btnWOWAddonsLoc_Click(object sender, EventArgs e)
        {
            FolderLocate("AddOn");
        }
        private void btnBrowseOW_Click(object sender, EventArgs e)
        {
            FolderLocate("OW");
        }
        #endregion

        private void chkWOW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWOW.Checked)
            {
                grpboxWOW.Visible = true;
            }
            else
            {
                grpboxWOW.Visible = false;
            }
        }

        private void chkOW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOW.Checked)
            {
                grpboxOW.Visible = true;
            }
            else
            {
                grpboxOW.Visible = false;
            }
        }
    }
}
