using Phoenix.DiscordRpcF;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PhoenixZ;

namespace Phoenix
{
    public partial class main : Form
    {
        public Module api = new Module();

        public bool scriptsFolderFound = false;

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public main()
        {
            InitializeComponent();
        }


        private void main_Load(object sender, EventArgs e)
        {
            //Discord
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("791259721700999200", ref this.handlers, true, null);
            this.presence.state = "Using Phoenix Z";
            this.presence.largeImageKey = "bigphoneix";
            DiscordRpc.UpdatePresence(ref this.presence);

            //ScriptsBox
            scriptsBox.Items.Clear();

            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(@".\scripts");
                FileInfo[] TxtFiles = dinfo.GetFiles("*.txt");
                FileInfo[] LuaFiles = dinfo.GetFiles("*.lua");

                foreach (FileInfo file in TxtFiles)
                {
                    scriptsBox.Items.Add("⠀-" + file.Name);
                }
                foreach (FileInfo file in LuaFiles)
                {
                    scriptsBox.Items.Add("⠀-" + file.Name);
                }

                scriptsFolderFound = true;
            }
            catch (Exception)
            {
                scriptsBox.Items.Add("            ----Folder not found----");
                scriptsFolderFound = false;
                MessageBox.Show("Make sure there is a 'scripts' folder inside the base directory", "Folder not found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do You Really Want To Close Phoenix Z ?", "Phoenix Z", MessageBoxButtons.YesNo);
            bool flag = dialogResult == DialogResult.Yes;
            if (flag)
            {
                Application.Exit();
            }
            else
            {
                bool flag2 = dialogResult == DialogResult.No;
                if (flag2)
                {
                }
            }
            //Application.Exit();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void scriptsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.scriptsBox.SelectedIndex != -1)
            {
                if (scriptsFolderFound)
                {
                    string SelectedItemStr = this.scriptsBox.SelectedItem.ToString();
                    char[] delete = { '⠀', '-'};
                    string NewString = this.scriptsBox.SelectedItem.ToString().TrimStart(delete);
                    scriptBox.Text = (System.IO.File.ReadAllText("scripts\\" + NewString));
                    scriptsBox.SelectedIndex = -1;
                }
                else
                {
                    scriptsBox.SelectedIndex = -1;
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            scriptBox.Clear();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                scriptBox.Clear();
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.scriptBox.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void discordLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/vzMhsaqj36");
        }

        private void killRblx_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                process.Kill();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dr = new SaveFileDialog();
            dr.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";

            if (dr.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                string sourceCode = scriptBox.Text;
                File.WriteAllText(dr.FileName, sourceCode);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void injectBtn_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            api.ExecuteScript(scriptBox.Text);
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alwaysOnTopToolStripMenuItem.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void refreshScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scriptsBox.Items.Clear();

            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(@".\scripts");
                FileInfo[] TxtFiles = dinfo.GetFiles("*.txt");
                FileInfo[] LuaFiles = dinfo.GetFiles("*.lua");

                foreach (FileInfo file in TxtFiles)
                {
                    scriptsBox.Items.Add("⠀-" + file.Name);
                }
                foreach (FileInfo file in LuaFiles)
                {
                    scriptsBox.Items.Add("⠀-" + file.Name);
                }

                scriptsFolderFound = true;
            }
            catch (Exception)
            {
                scriptsBox.Items.Add("            ----Folder not found----");
                scriptsFolderFound = false;
                MessageBox.Show("Make sure there is a 'scripts' folder inside the base directory", "Folder not found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
