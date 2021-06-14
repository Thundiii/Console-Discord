using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DiscordRPC;
using DiscordRPC.Logging;

namespace PlayStationDiscord
{
    public partial class MainForm : Form 
    {
        public enum Console
        {
            ConsoleDiscord,
            Ps2,
            Wii
        }

        public static String idleKey = "853801529739575297";
        public static String WiiKey = "853800132180443136";
        public static String ps2Key = "853764346027311114";

        public DiscordRpcClient client;
        public Console con;
        public MainForm()
        {
            InitializeComponent();
            con = Console.ConsoleDiscord;
            client = new DiscordRpcClient(idleKey);
            client.Initialize();
            setIdle();
            
        }

        private void setIdle()
        {
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = "",
                State = "Idle...",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = "idleicon",
                    
                    LargeImageText = getConsole(),
                }

            });
        }

        private String getConsole()
        {
            switch(con.ToString())
            {
                case "Ps2": return "PlayStation 2";
                case "Wii": return "Wii";
            }
            return "ConsoleDiscord";
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = tb_Details.Text,
                State = tb_State.Text,
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = tbIconID.Text,
                    LargeImageText = getConsole()
                }

            }); 

        }

        private void changeConsole(Console c)
        {
            switch(c)
            {
                case Console.Wii: client.Deinitialize(); con = Console.Wii; client = new DiscordRpcClient(WiiKey); client.Initialize(); setIdle(); break;
                case Console.Ps2: client.Deinitialize(); con = Console.Ps2; client = new DiscordRpcClient(ps2Key); client.Initialize(); setIdle(); break;

            }
        }

        private void playstationSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(playstationSwitch.Text)
            {
                case "Wii": changeConsole(Console.Wii); break;
                case "PlayStation 2": changeConsole(Console.Ps2); break;
            }

        }
    }
}
