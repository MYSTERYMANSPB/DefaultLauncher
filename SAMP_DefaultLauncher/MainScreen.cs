using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;

namespace SAMP_DefaultLauncher
{
    public partial class MainScreen : Form
    {
        string site_URL = "www.avantgarde-rp.ru";
        /*
        string serverSAMPIP = "31.31.199.48:1488";
        string serverCRMPIP = "31.31.199.48:1489";
        string serverCRMPSERGIP = "31.31.199.48:1490";
        */
        string path_CRMP = null;

        enum Errors : byte
        {
            INVALID_USER_NAME = 0,
            INVALID_CRMP_PATH,
            NO_SELECTED_GAME,
            INVALID_SERVER_IP
        };

        string[] error_text =
        {
            @"Некорректно заполнено поле ""Игровой ник""",
            "Не указан путь к папке multiplayer_cr",
            "Не выбрана игра",
            "Некорректный адрес сервера"
        };
        
        public MainScreen()
        {
            InitializeComponent();
            label_error_message.Visible = false;
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            Process.Start(site_URL);
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            var regx_name= new Regex(@"^[A-Za-z0-9_]+$");
            var mathces_name = regx_name.Matches(user_nickname.Text);
            int name_len = user_nickname.Text.Length;

            if ((!(name_len >= 3 && name_len <= 20)) || (mathces_name.Count == 0))
            {
                label_error_message.Text = error_text[(int)Errors.INVALID_USER_NAME];
                label_error_message.Visible = true;
                return;
            }

            var regx_server = new Regex(@"^(\d{1,4}).(\d{1,4}).(\d{1,4}):(\d{4})$");
            var mathces_server = regx_server.Matches(server_ip.Text);

            if (mathces_server.Count == 0)
            {
                label_error_message.Text = error_text[(int)Errors.INVALID_SERVER_IP];
                label_error_message.Visible = true;
                return;
            }

            if (select_game_samp.Checked)
            {
                label_error_message.Visible = false;

                Registry
                    .CurrentUser
                    .OpenSubKey(@"Software\SAMP", true)
                    .SetValue("PlayerName", user_nickname.Text);

                string path_GAME = $"{Registry.CurrentUser.OpenSubKey(@"Software\SAMP", true).GetValue("gta_sa_exe")}";
                path_GAME = path_GAME.Remove(path_GAME.Length - 10);
                Process.Start($"{path_GAME}samp", server_ip.Text);
            }
            else if(select_game_crmp_03e.Checked)
            {
                label_error_message.Visible = false;

                Registry
                    .CurrentUser
                    .OpenSubKey(@"Software\www.gtasrv.ru\CR-MP\GenerationC", true)
                    .SetValue("player_name", user_nickname.Text);

                if (path_CRMP == null)
                {
                    label_error_message.Text = error_text[(int)Errors.INVALID_CRMP_PATH];
                    label_error_message.Visible = true;
                    return;
                }
                Process.Start($"{path_CRMP}multiplayer_browser_cr", server_ip.Text);
            }
            else if(select_game_crmp_037.Checked)
            {
                label_error_message.Visible = false;

                Registry
                    .CurrentUser
                    .OpenSubKey(@"Software\www.sampsrv.ru\CR-MP 0.3.7", true)
                    .SetValue("PlayerName", user_nickname.Text);

                string path_GAME = $"{Registry.CurrentUser.OpenSubKey(@"Software\www.sampsrv.ru\CR-MP 0.3.7", true).GetValue("multiplayer_exe")}";
                path_GAME = path_GAME.Remove(path_GAME.Length - 32);
                Process.Start($"{path_GAME}multiplayer_browser_cr", server_ip.Text);
            }
            else
            {
                label_error_message.Text = error_text[(int)Errors.NO_SELECTED_GAME];
                label_error_message.Visible = true;
                return;
            }
        }

        private void btnCRPath_Click(object sender, EventArgs e)
        {
            var crmp_folder = new FolderBrowserDialog();
            string path = $@"{crmp_folder.SelectedPath}\";

            crmp_folder.Description = "Укажите путь к папке multiplayer_cr";
            if (crmp_folder.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists($@"{path}multiplayer_browser_cr.exe"))
                {
                    path_CRMP = path;
                }
            }
        }
    }
}
