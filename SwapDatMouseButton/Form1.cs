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

namespace SwapDatMouseButton
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
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
                    MessageBox.Show("Mouse buttons swapped back.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SystemInformation.MouseButtonsSwapped == false) // if not swapped
                {
                    SwapMouseButton(true);
                    MessageBox.Show("Mouse buttons now swapped.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void startUpCreate_Click(object sender, EventArgs e)
        {
            string fileName = "%AppData%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\SwapDatMouseButton.bat";
        }

    }
}
