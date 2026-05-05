using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using com.openkm.sdk4csharp;
using com.openkm.sdk4csharp.bean;
using com.openkm.sdk4csharp.impl;

using Microsoft.Win32;

namespace OpenKMUpdateSecurity
{
    public partial class frmMain : Form
    {
        void addLogText(string text)
        {
            string str_prev_text = richEditOutput.Text;

            if(!String.IsNullOrEmpty(str_prev_text))
            {
                str_prev_text = str_prev_text + "\n";
            }

            str_prev_text = str_prev_text + text;

            richEditOutput.Text = str_prev_text;
        }

        public frmMain()
        {
            InitializeComponent();

            // setup
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey software = hklm.OpenSubKey(@"SOFTWARE", true);
            RegistryKey myKey = software.CreateSubKey("MyApp");

            string str_address = (string)myKey.GetValue("address", "192.168.56.104");
            string str_port = (string)myKey.GetValue("port", "8280");
            string str_name = (string)myKey.GetValue("lastname", "");

            myKey.Close();
            software.Close();
            hklm.Close();

            editAddress.Text = str_address;
            editPort.Text = str_port;
            editLoginName.Text = str_name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Exit Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(ret == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str_address = editAddress.Text;
            string str_port = editPort.Text;
            string str_name = editLoginName.Text;
            string str_password = editLoginPassword.Text;
            string str_uuid = editUUID.Text;

            if(String.IsNullOrEmpty(str_address))
            {
                MessageBox.Show("Address is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(str_port))
            {
                MessageBox.Show("Port is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(str_name))
            {
                MessageBox.Show("Login Name is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(str_password))
            {
                MessageBox.Show("Password is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(str_uuid))
            {
                MessageBox.Show("UUID is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string host = "http://" + str_address + ":" + str_port + "/openkm";

            OKMWebservices ws = OKMWebservicesFactory.newInstance(host);

            richEditOutput.Text = "";

            try
            {
                ws.login(str_name, str_password);

                List<GrantedUser> guList = new List<GrantedUser>();
                List<GrantedRole> grList = new List<GrantedRole>();

                Dictionary<String, int> grants_roles = ws.auth.getGrantedRoles(str_uuid);
                Dictionary<String, int> grants_users = ws.auth.getGrantedUsers(str_uuid);
                foreach (KeyValuePair<string, int> kvp in grants_roles)
                {
                    System.Console.WriteLine("Role -> " + kvp.Key + " Permission -> " + kvp.Value);

                    GrantedRole gr = new GrantedRole();
                    gr.role = kvp.Key;
                    gr.permissions = kvp.Value;
                    grList.Add(gr);
                }
                foreach (KeyValuePair<string, int> kvp in grants_users)
                {
                    System.Console.WriteLine("User -> " + kvp.Key + " Permission -> " + kvp.Value);

                    GrantedUser gu = new GrantedUser();
                    gu.user = kvp.Key;
                    gu.permissions = kvp.Value;
                    guList.Add(gu);
                }

                addLogText("Try to overwrite all security settings for all sub folders and documents.....");

                ChangeSecurity changeSecurity = new ChangeSecurity();

                changeSecurity.recursive = true;
                changeSecurity.grantedRolesList = grList;
                changeSecurity.grantedUsersList = guList;

                ws.auth.overwriteSecurity(str_uuid, changeSecurity);

                addLogText("Update process is finished");

                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey software = hklm.OpenSubKey(@"SOFTWARE", true);
                RegistryKey myKey = software.CreateSubKey("MyApp");

                myKey.SetValue("address", str_address, RegistryValueKind.String);
                myKey.SetValue("port", str_port, RegistryValueKind.String);
                myKey.SetValue("lastname", str_name, RegistryValueKind.String);

                myKey.Close();
                software.Close();
                hklm.Close();
            }
            catch (Exception ex)
            {
                addLogText(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            editUUID.Text = "";
        }

    }
}
