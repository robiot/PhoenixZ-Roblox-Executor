using Microsoft.Win32;
using System;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PhoenixZ
{
    public class Module
    {
        private WebClient wc = new WebClient();

        private bool CheckLastestDll(RegistryKey registryKey)
        {
            string[] strArray = this.wc.DownloadString("https://raw.githubusercontent.com/GreenMs02/Update/master/Module.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (!(strArray[2] == "true") || !Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Roblox\\Versions\\" + strArray[3]))
                return false;
            registryKey.SetValue("Ver", (object)strArray[3]);
            return true;
        }

        private bool CheckDllUpdate()
        {
            string[] strArray = this.wc.DownloadString("https://raw.githubusercontent.com/GreenMs02/Update/master/Module.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\CoCO", true);
            if (registryKey == null)
            {
                Registry.CurrentUser.CreateSubKey("SOFTWARE\\\\CoCO").SetValue("Ver", (object)"0");
            }
            else
            {
                if (registryKey.GetValue("Ver").ToString() != strArray[0])
                {
                    registryKey.SetValue("Ver", (object)strArray[0]);
                    return true;
                }
                if (registryKey.GetValue("Ver").ToString() != strArray[3] && this.CheckLastestDll(registryKey))
                    return true;
            }
            return !File.Exists("PhoenixDLL.dll");
        }

        private bool DownloadDLL()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\CoCO", true);
            string[] strArray = this.wc.DownloadString("https://raw.githubusercontent.com/GreenMs02/Update/master/Module.txt").Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (registryKey.GetValue("Ver").ToString() == strArray[3] && this.CheckLastestDll(registryKey))
            {
                this.wc.DownloadFile(strArray[4], "PhoenixDLL.dll");
            }
            else
            {
                this.wc.DownloadFile(strArray[1], "PhoenixDLL.dll");
            }
            return File.Exists("PhoenixDLL.dll");
        }

        public void ExecuteScript(string Script)
        {
            if (Module.namedPipeExist("ocybedam"))
            {
                using (NamedPipeClientStream pipeClientStream = new NamedPipeClientStream(".", "ocybedam", PipeDirection.Out))
                {
                    pipeClientStream.Connect();
                    using (StreamWriter streamWriter = new StreamWriter((Stream)pipeClientStream, Encoding.Default, 999999))
                    {
                        streamWriter.Write(Script);
                        streamWriter.Dispose();
                    }
                    pipeClientStream.Dispose();
                }
            }
            else if (File.Exists("PhoenixDLL.dll"))
            {
                int num1 = (int)MessageBox.Show("Please inject Phoenix Z before executing", "Not injected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                int num2 = (int)MessageBox.Show("Dll deleted! check your antivirus", "DLLDoesntExist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void InjectDLL()
        {
            switch (DLLInjection.DllInjector.GetInstance.Inject("RobloxPlayerBeta", Application.StartupPath + "\\PhoenixDLL.dll"))
            {
                case DLLInjection.DllInjectionResult.DllNotFound:
                    int num1 = (int)MessageBox.Show("Couldn't find the dll!", "Error: Dll Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case DLLInjection.DllInjectionResult.GameProcessNotFound:
                    int num2 = (int)MessageBox.Show("No ROBLOX process found!", "Game Process Not Found", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case DLLInjection.DllInjectionResult.InjectionFailed:
                    int num3 = (int)MessageBox.Show("Injection failed! :(", "Injection Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
            }
        }

        public void LaunchExploit()
        {
            if (Module.namedPipeExist("ocybedam"))
            {
                int num1 = (int)MessageBox.Show("Phoenix Z is already attached", "Already Attached!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (!this.CheckDllUpdate() && File.Exists("PhoenixDLL.dll"))
                this.InjectDLL();
            else if (this.DownloadDLL())
            {
                this.InjectDLL();
            }
            else
            {
                int num2 = (int)MessageBox.Show("Cant download the lastest version!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private static bool namedPipeExist(string pipeName)
        {
            try
            {
                if (!Module.WaitNamedPipe(Path.GetFullPath(string.Format("\\\\.\\pipe\\{0}", (object)pipeName)), 0))
                {
                    switch (Marshal.GetLastWin32Error())
                    {
                        case 0:
                            return false;
                        case 2:
                            return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool WaitNamedPipe(string name, int timeout);
    }
}
