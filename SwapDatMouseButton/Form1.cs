using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SwapDatMouseButton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // set up newline variabe for quick use
        string newLine = Environment.NewLine;

        // swap mouse set up for swap mouse button
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SwapMouseButton([param: MarshalAs(UnmanagedType.Bool)] bool fSwap);

        // swapMouseBtn event
        private void swapMouseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SystemInformation.MouseButtonsSwapped == true) // if swapped
                {
                    SwapMouseButton(false);
                    msgLog.Text += "Mouse buttons swapped back." + newLine;
                    MessageBox.Show("Mouse buttons swapped back.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SystemInformation.MouseButtonsSwapped == false) // if not swapped
                {
                    SwapMouseButton(true);
                    msgLog.Text += "Mouse buttons swapped." + newLine;
                    MessageBox.Show("Mouse buttons now swapped.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                msgLog.Text += "Something went seriously wrong." + newLine;
                MessageBox.Show(ex.Message);
            }
            
        }

        private void startUpCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\SwapDatMouseButton.bat";
                string batchContents = "@echo off" + newLine + "rundll32 user32, SwapMouseButton";

                System.IO.StreamWriter objWriter;
                objWriter = new System.IO.StreamWriter(fileName);

                objWriter.Write(batchContents);
                objWriter.Close();
                File.SetAttributes(fileName, FileAttributes.Hidden); // set file to hidden

                msgLog.Text += "Mouse buttons will now be swapped at startup." + newLine;
                MessageBox.Show("File successfully created.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                msgLog.Text += "Directory could not be found." + newLine;

                DialogResult result = MessageBox.Show("Directory could not be found.", "Invalid Directory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    startUpCreate.PerformClick();
                }
            }
            catch (Exception ex)
            {
                msgLog.Text += "Something went seriously wrong." + newLine;

                DialogResult result = MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    startUpCreate.PerformClick();
                }
            }
        }

        private void startUpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\SwapDatMouseButton.bat";
                if (File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);

                    msgLog.Text += "Startup file has been deleted." + newLine;
                    MessageBox.Show("File successfully deleted.", "Task Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (File.Exists(filePath) == false)
                {
                    msgLog.Text += "Could not delete file as none exists." + newLine;

                    DialogResult result = MessageBox.Show("File does not exist, would you like to retry?", "File Does Not Exist", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        startUpDelete.PerformClick();
                    }
                }
            }
            catch (Exception ex)
            {
                msgLog.Text += "Something went seriously wrong." + newLine;

                DialogResult result = MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    startUpDelete.PerformClick();
                }
            }
        }

    }
}
