using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blatant_Autoclicker
{
    public partial class MainUI : Form
    {
        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public MainUI()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            #region Stuff

            title.Text = "AutoClicker";
            info1.Text = "Left Click CPS";
            lsliderval.Text = lcpsslider.Value.ToString() + " CPS";
            info3.Text = "Randomize (Recommended)";
            rsliderval.Text = rcpsslider.Value.ToString() + " CPS";

            #endregion
        }

        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lsliderchange(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            lsliderval.Text = lcpsslider.Value.ToString() + " CPS";
        }

        private void rsliderchange(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ValueChangedEventArgs e)
        {
            rsliderval.Text = rcpsslider.Value.ToString() + " CPS";
        }
        
        private void togButClick(object sender, EventArgs e)
        {
            if (toggleBut.Text.Contains("Enable"))
            {
                toggleBut.ForeColor = Color.FromArgb(80, 80, 80);
                toggleBut.IdleFillColor = Color.DodgerBlue;
                toggleBut.OnPressedState.FillColor = Color.DodgerBlue;
                toggleBut.Text = "Disable";
                lcpsrand.Enabled = false;
            }

            else if (toggleBut.Text.Contains("Disable"))
            {
                toggleBut.ForeColor = Color.DodgerBlue;
                toggleBut.IdleFillColor = Color.FromArgb(80, 80, 80);
                toggleBut.OnPressedState.FillColor = Color.FromArgb(80, 80, 80);
                toggleBut.Text = "Enable";
                lcpsrand.Enabled = true;
            }
        }

        int min;
        int max;

        private void randomTick(object sender, EventArgs e)
        {
            if (toggleBut.Text.Contains("Disable"))
            {
                if (lcpsrand.Checked == true)
                {
                    min = lcpsslider.Value - 6;
                    max = lcpsslider.Value + 6;
                    Random rand = new Random();
                    randomTB.Value = (rand.Next(min, max));
                    Console.WriteLine(randomTB.Value);
                }
                else
                {
                    randomTB.Value = lcpsslider.Value;
                }
            }
        }

        private void onMinChange(object sender, EventArgs e)
        {
            //if (bunifuRange1.RangeMin <= 5)
            //{
            //    bunifuRange1.RangeMin = 6;
            //}
        }

        private void checkChangeLeft(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
    }
}
