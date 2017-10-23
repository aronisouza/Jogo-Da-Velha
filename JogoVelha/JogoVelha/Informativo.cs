using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class Informativo : Form
    {
        public Informativo()
        {
            InitializeComponent();
        }

        #region Move Janela
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void moveJ(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
