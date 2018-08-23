using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace SAMP_DefaultLauncher
{
    public partial class MainScreen : Form
    {
        string siteURL = "www.avantgarde-rp.ru";
        string serverSAMPIP = "31.31.199.48:1488";
        string serverCRMPIP = "31.31.199.48:1489";
        string serverCRMPSERGIP = "31.31.199.48:1490";
        string pathCRMP = null;

        public MainScreen()
        {
            InitializeComponent();
            label_error_message.Visible = false;
        }

        private void button_to_site_Click(object sender, EventArgs e)
        {
            Process.Start(siteURL);
        }

        private void button_to_game_Click(object sender, EventArgs e)
        {
            if (input_user_nickname.Text.Length < 3 || input_user_nickname.Text.Length > 22)
            {
                label_error_message.Text = "Некорректно заполнено поле \"Игровой ник\".";
                label_error_message.Visible = true;
                return;
            }
            if(select_game_samp.Checked)
            {
                label_error_message.Visible = false;
                Registry.CurrentUser.OpenSubKey(@"Software\SAMP", true).SetValue("PlayerName", input_user_nickname.Text);
                string pathGAME = (string)Registry.CurrentUser.OpenSubKey(@"Software\SAMP", true).GetValue("gta_sa_exe");
                pathGAME = pathGAME.Remove(pathGAME.Length - 10);
                Process.Start(pathGAME + "samp", serverSAMPIP);
            }
            else if(select_game_crmp_03e.Checked)
            {
                label_error_message.Visible = false;
                Registry.CurrentUser.OpenSubKey(@"Software\www.gtasrv.ru\CR-MP\GenerationC", true).SetValue("player_name", input_user_nickname.Text);
                if (pathCRMP == null)
                {
                    label_error_message.Text = "Не указан путь к папке multiplayer_c";
                    label_error_message.Visible = true;
                    return;
                }
                Process.Start(pathCRMP + "multiplayer_browser_cr", serverCRMPIP);
            }
            else if(select_game_crmp_037.Checked)
            {
                label_error_message.Visible = false;
                Registry.CurrentUser.OpenSubKey(@"Software\www.sampsrv.ru\CR-MP 0.3.7", true).SetValue("PlayerName", input_user_nickname.Text);
                string pathGAME = (string)Registry.CurrentUser.OpenSubKey(@"Software\www.sampsrv.ru\CR-MP 0.3.7", true).GetValue("multiplayer_exe");
                pathGAME = pathGAME.Remove(pathGAME.Length - 32);
                Process.Start(pathGAME + "multiplayer_browser_cr", serverCRMPSERGIP);
            }
            else
            {
                label_error_message.Text = "Не выбрана игра";
                label_error_message.Visible = true;
                return;
            }
        }

        private void button_select_crmp_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog crmp_folder = new FolderBrowserDialog();
            crmp_folder.Description = "Укажите путь к папке multiplayer_c";
            if (crmp_folder.ShowDialog() == DialogResult.OK) { 
                if (File.Exists(crmp_folder.SelectedPath.ToString() + "\\multiplayer_browser_cr.exe"))
                {
                    pathCRMP = crmp_folder.SelectedPath.ToString() + "\\";
                }
            }
        }
    }
}
