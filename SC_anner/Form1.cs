using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_anner
{
    public partial class frmMain : Form
    {
        int resHeight = Screen.PrimaryScreen.Bounds.Height;
        int resWidth = Screen.PrimaryScreen.Bounds.Width;

        public frmMain()
        {
            InitializeComponent();
            prepRepair();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            //Bring up folder browser dialog and set output to textbox text
            openFileDialog1.Title = "Please Select a File";

            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.FileName = "report.html";
            openFileDialog1.ShowDialog();
            //TODO Set up for net share upload or email
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            postRepair();
            Application.Exit();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //Prep
            this.prepRepair();
            //Repair
            this.perfRepair();
            //Post
            this.postRepair();
            Console.WriteLine("Saving...");

            if (cbRKill.Checked)
            {
                Console.WriteLine("Rkill selected");

            }

            Console.WriteLine("Running...");
        }

        private void prepRepair()
        {
            //Todo - Add other stuff like update
            //Gather client data
            gatherClient();
            //UNINSTALL NEEDED PROGRAMS
            //checkInstalled();

            //DOWNLOAD NEEDED PROGRAMS
        }

        private void gatherClient()
        {
            //TODO Format into form to print
            String computerName, processor, ram, osVersion, bitVersion, username;
            string[] logicalDrives;
            //TODO Check if UEFI/Secure boot enabled
            computerName = Environment.MachineName;
            osVersion = Environment.OSVersion.ToString();
            logicalDrives = Environment.GetLogicalDrives();
            processor = Environment.ProcessorCount.ToString();
            if (Environment.Is64BitOperatingSystem)
            {
                bitVersion = "64";
            }
            else { bitVersion = "32"; }
            //Gives weird number for physical memory
            //Processor gives core count not mfg or anything
            username = Environment.UserName;
            ram = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory.ToString();
            Console.WriteLine("INFORMATION");
            Console.WriteLine("----------------------");
            Console.WriteLine("Computer Name: {0}", computerName);
            Console.WriteLine("User Name: {0}", username);
            Console.WriteLine("RAM: {0}", ram);
            Console.WriteLine("Processor: {0}", processor);
            Console.WriteLine("OS Version: {0}", osVersion);
            Console.WriteLine("{0}-bit", bitVersion);
            Console.WriteLine();
            Console.WriteLine("LOGICAL DRIVES");
            Console.WriteLine("--------------------");
            foreach (string drive in logicalDrives)
            {
                Console.WriteLine(drive);
            }
            Console.WriteLine("Resolution: " + resWidth + "x" + resHeight);
        }

        private void checkInstalled()
        //Check if programs that are needed are present on system. If so, uninstall for fresh copy
        {
            Mbam();
            System.Threading.Thread.Sleep(5000);
        }

        private void Mbam()
        {
            if (Directory.Exists(@"C:\Program Files\Malwarebytes\Anti-Malware"))
            {
                Console.WriteLine("MBAM Directory found");
                if (File.Exists(@"C:\Program Files\Malwarebytes\Anti-Malware\mbam.exe"))
                {
                    Console.WriteLine("MBAM exe found");
                    Process.Start(@"C:\Program Files\Malwarebytes\Anti-Malware\unins000.exe");
                    Console.WriteLine("Uninstalling MBAM...");
                    //Do uninstall
                    Console.WriteLine("20s passed, MBAM should be uninstalled.");
                    //Rerun this to delete the directory
                    Mbam();
                }
                else
                {
                    Directory.Delete(@"C:\Program Files\Malwarebytes\Anti-Malware");
                    Console.WriteLine("Deleted MBAM directory");
                    //Run this to install MBAM again
                    Mbam();
                }
            }
            else
            {
                //Get installer, click through
                using (var client = new WebClient())
                {
                    Console.WriteLine("Downloading MBAM...");
                    client.DownloadFile("https://data-cdn.mbamupdates.com/web/mb3-setup-consumer/mb3-setup-consumer-3.5.1.2522-1.0.374-1.0.5797.exe", "mbam.exe");
                    Console.WriteLine("MBAM Downloaded");
                    Console.WriteLine("Installing...");
                    Process.Start("mbam.exe");
                    //mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
                    //mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
                }


            }
        }



        private void perfRepair()
        {
            if (cbMbam.Checked)
            {
                Console.WriteLine("Mbam selected");
                if (Directory.Exists(@"C:\Program Files\Malwarebytes\Anti-Malware"))
                {
                    Console.WriteLine("MBAM Directory found");
                    if (File.Exists(@"C:\Program Files\Malwarebytes\Anti-Malware\mbam.exe"))
                    {
                        Console.WriteLine("MBAM exe found");
                        Process.Start(@"C:\Program Files\Malwarebytes\Anti-Malware\mbam.exe");
                        Console.WriteLine("MBAM starting...");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("5s passed, MBAM should be started");
                    }
                }
            }
        }

        private void postRepair()
        {
            //Delete Rkill log file
            //Delete tdss log file
            //Uninstall MBAM
            //Uninstall CCleaner
            //Delete installers
            //Delete this?
        }
        #region Click simulator
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
        #endregion
    }
}


