using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class ScreenSaverForm : Form
    {
        private Point mouseLocation;
        private Random rand = new Random();
        private bool previewMode = false;

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);


        public ScreenSaverForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
        }

        public ScreenSaverForm(IntPtr PreviewWndHandle)
        {
            InitializeComponent();

            // Set the preview window as the parent of this window
            SetParent(this.Handle, PreviewWndHandle);

            // Make this a child window so it will close when the parent dialog closes
            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(this.Handle, -16, new IntPtr(GetWindowLong(this.Handle, -16) | 0x40000000));

            // Place our window inside the parent
            Rectangle ParentRect;
            GetClientRect(PreviewWndHandle, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            // Make text smaller
            textLabel.Font = new System.Drawing.Font("Arial", 6);

            previewMode = true;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            Cursor.Hide();
            TopMost = true;

            moveTimer.Interval = 3000;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // Terminate if mouse is moved a significant distance
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    Application.Exit();
            }

            // Update current mouse location
            mouseLocation = e.Location;
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void moveTimer_Tick(object sender, System.EventArgs e)
        {
            // Move text to new location
            textLabel.Left = rand.Next(Math.Max(1, Bounds.Width - textLabel.Width));
            textLabel.Top = rand.Next(Math.Max(1, Bounds.Height - textLabel.Height));
        }

    }
}