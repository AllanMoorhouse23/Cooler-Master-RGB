using Microsoft.Win32;
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

namespace Cooler_Master_RGB
{
    public partial class Form1 : Form
    {
        
        public const int MAX_LED_ROW = 6;
        public const int MAX_LED_COLUMN = 22;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys key);

        [DllImport("SDKDLL.dll")]
        public static extern bool EnableLedControl(bool bEnable);

        [DllImport("SDKDLL.dll")]
        public static extern void SetLedColor(int row, int col, byte r, byte g, byte b);

        [DllImport("SDKDLL.dll")]
        public static extern void SetFullLedColor(byte r, byte g, byte b);

        [DllImport("SDKDLL.dll")]
        public static extern bool IsDevicePlug();

        [DllImport("SDKDLL.dll")]
        public static extern uint GetRamUsage();

        [DllImport("SDKDLL.dll")]
        public static extern void SetControlDevice(DEVICE_INDEX devIndex);

        [DllImport("SDKDLL.dll")]
        public static extern bool SetAllLedColor(COLOR_MATRIX colorMatrix);


        public struct KEY_COLOR
        {
            public byte r, g, b;
            public KEY_COLOR(byte _r, byte _g, byte _b) {
                r = _r;
                g = _g;
                b = _b;
            }
        }


        public struct COLOR_MATRIX
        {
           public KEY_COLOR[,] keyColor;
            public COLOR_MATRIX(int MAX_LED_ROW, int MAX_LED_COLUMN) {

                keyColor = new KEY_COLOR[MAX_LED_ROW, MAX_LED_COLUMN];

            }
        }

        public static void test() {

            //KEY_COLOR keyCOLOR = new KEY_COLOR(255, 255, 255);

            //COLOR_MATRIX colorMatrix = new COLOR_MATRIX(MAX_LED_ROW, MAX_LED_COLUMN);

            //label1.Text = "Reached Position 1";

            //colorMatrix.keyColor[1, 1] = keyCOLOR;

            //label1.Text = "Reached Position 2";

        }

        
        //Test

        public enum DEVICE_INDEX
        {
            DEV_MKeys_L = 0, DEV_MKeys_S = 1, DEV_MKeys_L_White = 2, DEV_MKeys_M_White = 3, DEV_MMouse_L = 4
                    , DEV_MMouse_S = 5, DEV_MKeys_M = 6, DEV_MKeys_S_White = 7,
        };

        

        private static SessionSwitchEventHandler sseh;
        private bool state = false;

        /// <summary>
        /// Detect when a session switch occurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                if (state == false) {
                    EnableLedControl(true);
                }
                //Stop current effect
                tmrAnimation.Stop();
                SetFullLedColor(255, 0, 0);

            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                if (state == false)
                {
                    EnableLedControl(false);
                }
                else {
                    //Resume current effect
                    tmrAnimation.Start();
                }
            }
        }


         Effects_Set_1 _effects_set_1 = new Effects_Set_1();
         Effects_Set_2 _effects_set_2 = new Effects_Set_2();
         keyPressEffects _effects_KeyPress_1 = new keyPressEffects();
      

        public Form1()
        {
            InitializeComponent();

            sseh = new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            SystemEvents.SessionSwitch += sseh;

            _effects_KeyPress_1.TempColor = Color.FromArgb(_effects_KeyPress_1.primaryRED, _effects_KeyPress_1.primaryGREEN, _effects_KeyPress_1.primaryBLUE);
            panelPrimaryColor.BackColor = _effects_KeyPress_1.TempColor;
            _effects_KeyPress_1.TempColor = Color.FromArgb(_effects_KeyPress_1.secondaryRED, _effects_KeyPress_1.secondaryGREEN, _effects_KeyPress_1.secondaryBLUE);
            panelSecondary.BackColor = _effects_KeyPress_1.TempColor;

            SetControlDevice(DEVICE_INDEX.DEV_MKeys_L);

        }

        //--------------------------------------------------Application is closing-------------------------------------------------------

        /// <summary>
        /// Form Closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            closeApplication();         
        }

        /// <summary>
        /// Exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            closeApplication();
            this.Close();
        }

        /// <summary>
        /// Close application 
        ///    -Hands control back to keyboard
        ///    -Deregisters the session event handler
        ///    -Stops the animation timer.
        /// </summary>
        private void closeApplication() {
            EnableLedControl(false);
            SystemEvents.SessionSwitch -= sseh;
            tmrAnimation.Stop();
        }


        /// <summary>
        /// Timer, handles running the current effect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
     
            switch (selectedIndex) {
                case 0:
                    _effects_set_1.LineByLine();
                    break;
                case 1:
                    _effects_set_1.effectAltLines();
                    break;
                case 2:
                    _effects_set_1.effectSnakeLineByLine();
                    break;
                case 3:
                    _effects_set_1.effectSpiral();
                    break;
                case 4:
                    _effects_set_1.effectWipe();
                    break;
                case 5:
                    _effects_set_1.effectBreathing();
                    break;
                case 6:
                    _effects_set_1.effectRandom();
                    break;
                case 7:
                    _effects_set_1.effectRandomLines();
                    break;
                case 8:
                    _effects_set_1.effectRandomSquares();
                    break;
                case 9:
                    _effects_set_1.effectRandomSelectedLine();
                    break;
                case 10:
                    _effects_set_1.effectBall();
                    break;
                case 11:
                    _effects_set_1.effectColorCycle();
                    break;
                case 12:
                    _effects_set_2.effectVerticalLines();
                    break;
                case 13:
                    _effects_set_2.effectRainbow();
                    break;
                case 14:
                    _effects_KeyPress_1.keyPress();
                    break;
            }
        }

        /// <summary>
        /// App takes control of the keyboard backlighting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnable_Click(object sender, EventArgs e)
        {
            //Effects are disabled and are being turned on
            if (state == false) {
                EnableLedControl(true);
                if (comboBoxEffects.SelectedIndex == 14)
                {
                    SetFullLedColor(_effects_KeyPress_1.secondaryRED, _effects_KeyPress_1.secondaryGREEN, _effects_KeyPress_1.secondaryBLUE);
                }
                tmrAnimation.Start();
                buttonEnable.Text = "Disable";
                state = true;
               
            } else if (state == true) {
                EnableLedControl(false);
                tmrAnimation.Stop();
                buttonEnable.Text = "Enable";
                state = false;

            }
        }

        int selectedIndex = 0;
        
        /// <summary>
        /// Effect has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBoxEffects.SelectedIndex;
            if (comboBoxEffects.SelectedIndex == 14) {
                SetFullLedColor(_effects_KeyPress_1.secondaryRED, _effects_KeyPress_1.secondaryGREEN, _effects_KeyPress_1.secondaryBLUE);
            }
        }

        /// <summary>
        /// Changes the spped of the effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tmrAnimation.Interval = trackBar1.Value;          
        }

        /// <summary>
        /// Select primary color from a color dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPrimaryColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _effects_KeyPress_1.TempColor = colorDialog1.Color;
                panelPrimaryColor.BackColor = colorDialog1.Color;
                _effects_KeyPress_1.primaryRED = _effects_KeyPress_1.TempColor.R;
                _effects_KeyPress_1.primaryGREEN = _effects_KeyPress_1.TempColor.G;
                _effects_KeyPress_1.primaryBLUE = _effects_KeyPress_1.TempColor.B;
            }
        }

        /// <summary>
        /// Select secondary color from a color dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelSecondary_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _effects_KeyPress_1.TempColor = colorDialog1.Color;
                panelSecondary.BackColor = colorDialog1.Color;
                _effects_KeyPress_1.secondaryRED = _effects_KeyPress_1.TempColor.R;
                _effects_KeyPress_1.secondaryGREEN = _effects_KeyPress_1.TempColor.G;
                _effects_KeyPress_1.secondaryBLUE = _effects_KeyPress_1.TempColor.B;
            }
        }


        //---------------------------MINIMISE TO SYSTEM TRAY-----------------------------
        /// <summary>
        /// Opens the application from the system tray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// Hides the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Minimise to system tray
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }
        //------------------------^MINIMISE TO SYSTEM TRAY^-------------------------------


        //-------------------------------TAB CONTROLS------------------------------------
        private bool colorsVisible = false;
        private bool speedVisible = true;

        /// <summary>
        /// Spped tab clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpeed_Click(object sender, EventArgs e)
        {
            if (speedVisible == true) {
                tabCOntrolShowColors();
            }
            else {
                tabControlShowSpeed();
            }
        }

        /// <summary>
        /// Colors tab clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColors_Click(object sender, EventArgs e)
        {
            if (colorsVisible == true) {
                tabControlShowSpeed();  
            }
            else {
                tabCOntrolShowColors();
            }    
        }

        /// <summary>
        /// Show the speed tab
        /// </summary>
        private void tabControlShowSpeed()
        {

            panel4.Visible = false;
            colorsVisible = false;
            panel3.Visible = true;
            speedVisible = true;

            buttonColors.BackColor = Color.FromArgb(243, 156, 18);
            buttonColors.ForeColor = Color.FromArgb(255, 255, 255);
            buttonSpeed.BackColor = Color.FromArgb(255, 255, 255);
            buttonSpeed.ForeColor = Color.FromArgb(44, 62, 80);
        }

        /// <summary>
        /// Show colors tab
        /// </summary>
        private void tabCOntrolShowColors() {
           
            panel4.Visible = true;
            colorsVisible = true;
            panel3.Visible = false;
            speedVisible = false;

            buttonColors.BackColor = Color.FromArgb(255, 255, 255);
            buttonColors.ForeColor = Color.FromArgb(44, 62, 80);
            buttonSpeed.BackColor = Color.FromArgb(243, 156, 18);
            buttonSpeed.ForeColor = Color.FromArgb(255, 255, 255);
        }
        //------------------------------^TAB CONTROL^-----------------------------------


    }
}
