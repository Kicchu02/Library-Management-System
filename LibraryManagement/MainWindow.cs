using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagement
{
    public partial class MainWindow : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public MainWindow()
        {
            InitializeComponent();
            SendMessage(textBoxBookID.Handle, EM_SETCUEBANNER, 0, "Book ID");
            SendMessage(textBoxBookName.Handle, EM_SETCUEBANNER, 0, "Book Name");
            SendMessage(textBoxAuthorName.Handle, EM_SETCUEBANNER, 0, "Author Name");
            SendMessage(textBoxPublication.Handle, EM_SETCUEBANNER, 0, "Publication");
            SendMessage(textBoxPublishedYear.Handle, EM_SETCUEBANNER, 0, "Published Year");
        }

        private void linkLabelSourceCodeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // System.Diagnostics.Process.Start("https://github.com/Kicchu02/Library-Management-System.git");
            // ProcessStartInfo processStartInfo = new ProcessStartInfo("https://github.com/Kicchu02/Library-Management-System.git");
            // Process.Start(processStartInfo);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
