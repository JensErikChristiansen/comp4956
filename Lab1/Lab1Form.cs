using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;
using Microsoft.Win32;

namespace Lab1 {
    /// <summary>
    /// Performs various activities as outlined in Lab 1.
    /// </summary>
    public partial class formLab1 : Form {
        public formLab1() {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves information from all of the disks.
        /// </summary>
        /// <param name="sender">unused</param>
        /// <param name="e">unused</param>
        private void buttonDiskInfoClick(object sender, EventArgs e) {
            
            ManagementObjectSearcher disks = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            info.Text = "Local Disks:";

            foreach (ManagementObject disk in disks.Get()) {

                info.Text += "Name: " + disk["Name"].ToString() + "\n";
                info.Text += "Description: " + disk["Description"].ToString() + "\n";
                info.Text += "Device ID: " + disk["DeviceID"].ToString() + "\n";

                String fileSystem = disk["FileSystem"] == null ? "" : disk["FileSystem"].ToString() + "\n";
                info.Text += "File System: " + fileSystem;

                UInt64 size = disk["Size"] == null ? 0 : UInt64.Parse(disk["Size"].ToString() + "\n");
                info.Text += "Size: " + Math.Round(size / Math.Pow(2, 20)) + "MB";

                UInt64 free = disk["Size"] == null ? 0 : UInt64.Parse(disk["FreeSpace"].ToString() + "\n");
                info.Text += "Free: " + Math.Round(free / Math.Pow(2, 20)) + "MB\n";

                UInt64 used = disk["Size"] == null ? 0 : size - free;
                info.Text += "Used: " + Math.Round(used / Math.Pow(2, 20)) + "MB\n";

                if (size != 0) {
                    info.Text += "Free Percentage: " + Math.Round((double)free / size * 100) + "%\n";
                    info.Text += "Used Percentage: " + Math.Round((double)used / size * 100) + "%\n";
                }

                info.Text += "\n";

            }
        }

        /// <summary>
        /// Retrieve information for all processes.
        /// </summary>
        /// <param name="sender">unused</param>
        /// <param name="e">unused</param>
        private void buttonProcessInfoClick(object sender, EventArgs e) {
            ManagementObjectSearcher processes = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
            info.Clear();
            foreach (ManagementObject process in processes.Get()) {
                info.Text += "Name: " + process["Name"].ToString() + "\n";
                info.Text += "Description: " + process["Description"].ToString() + "\n";
                info.Text += "Handle: " + process["Handle"].ToString() + "\n";

                UInt64 userModeTime = UInt64.Parse(process["UserModeTime"].ToString() + "\n");
                info.Text += "UserModeTime: " + userModeTime * .0001 + "msec\n";

                UInt64 kernelModeTime = UInt64.Parse(process["KernelModeTime"].ToString() + "\n");
                info.Text += "KernelModeTime: " + kernelModeTime * .0001 + "msec\n";

                info.Text += "\n";
            }
        }

        /// <summary>
        /// Registers a key for a new application.
        /// </summary>
        /// <param name="sender">unused</param>
        /// <param name="e">unused</param>
        private void buttonRegAppClick(object sender, EventArgs e) {

            RegisterDialog dialog = new RegisterDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\Technical Programming");
                Console.WriteLine("Year: " + dialog.Year);
                key.SetValue("Application", dialog.Application);
                key.SetValue("Specialty", dialog.Specialty);
                key.SetValue("ApplicationOwner", dialog.Owner);
                key.SetValue("Year", dialog.Year.ToString());
                info.Text = "Value added to registry";
            }

            

        }

        /// <summary>
        /// Change the color of Window Text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWinTextColorClick(object sender, EventArgs e) {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors", true);
                String color = dialog.Color.R + " " + dialog.Color.G + " " + dialog.Color.B;
                key.SetValue("WindowText", color);
                info.Text = "Changed Window Text Color to (" + color + ")";
            }
        }
    }
}
