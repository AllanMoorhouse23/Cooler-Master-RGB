using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cooler_Master_RGB
{
    class Effects_Set_2
    {

        public Effects_Set_2() {

        }
        private int frame = 0;

        [DllImport("SDKDLL.dll")]
        public static extern void SetLedColor(int row, int col, byte r, byte g, byte b);


        private byte[] red_ = new byte[22] { 255, 255, 255, 255, 165, 90, 0, 0, 0, 0, 0, 0, 0, 90, 165, 255, 255, 255, 255, 255, 255, 255 };
        private byte[] green_ = new byte[22] { 0, 90, 165, 255, 255, 255, 255, 255, 255, 255, 165, 90, 0, 0, 0, 0, 0, 0, 0, 90, 165, 255 };
        private byte[] blue_ = new byte[22] { 0, 0, 0, 0, 0, 0, 0, 90, 165, 255, 255, 255, 255, 255, 255, 255, 165, 90, 0, 0, 0, 0 };
        private string[] colorTo_ = new string[22] { "yellow", "yellow", "yellow", "green", "green", "green", "aqua", "aqua", "aqua", "blue", "blue", "blue", "pink", "pink", "pink", "red", "red", "red", "yellow", "yellow", "yellow", "green" };

        public void effectRainbow()
        {

            for (int i = 0; i < 22; i++)
            {
                if (colorTo_[i] == "yellow")
                {
                    green_[i] += 15;
                }
                else if (colorTo_[i] == "green")
                {
                    red_[i] -= 15;
                }
                else if (colorTo_[i] == "aqua")
                {
                    blue_[i] += 15;
                }
                else if (colorTo_[i] == "blue")
                {
                    green_[i] -= 15;
                }
                else if (colorTo_[i] == "pink")
                {
                    red_[i] += 15;
                }
                else if (colorTo_[i] == "red")
                {
                    blue_[i] -= 15;
                }

                if (red_[i] == 255 && green_[i] == 0 && blue_[i] == 255)
                {
                    colorTo_[i] = "red";
                }
                else if (red_[i] == 255 && green_[i] == 0 && blue_[i] == 0)
                {
                    colorTo_[i] = "yellow";
                }
                else if (red_[i] == 255 && green_[i] == 255 && blue_[i] == 0)
                {
                    colorTo_[i] = "green";
                }
                else if (red_[i] == 0 && green_[i] == 255 && blue_[i] == 0)
                {
                    colorTo_[i] = "aqua";
                }
                else if (red_[i] == 0 && green_[i] == 255 && blue_[i] == 255)
                {
                    colorTo_[i] = "blue";
                }
                else if (red_[i] == 0 && green_[i] == 0 && blue_[i] == 255)
                {
                    colorTo_[i] = "pink";
                }
                //Loop through each row
                for (int j = 0; j < 6; j++)
                {
                    SetLedColor(j, i, red_[i], green_[i], blue_[i]);
                }
            }
        }




        public void effectVerticalLines() {

            switch (frame)
            {
                case 1:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 255, 0, 0);
                        SetLedColor(1, i, 255, 90, 0);
                        SetLedColor(2, i, 255, 165, 0);
                        SetLedColor(3, i, 255, 255, 0);
                        SetLedColor(4, i, 165, 255, 0);
                        SetLedColor(5, i, 90, 255, 0);
                    }
                    break;
                case 2:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 255, 90, 0);
                        SetLedColor(1, i, 255, 165, 0);
                        SetLedColor(2, i, 255, 255, 0);
                        SetLedColor(3, i, 165, 255, 0);
                        SetLedColor(4, i, 90, 255, 0);
                        SetLedColor(5, i, 0, 255, 0);
                    }
                    break;
                case 3:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 255, 165, 0);
                        SetLedColor(1, i, 255, 255, 0);
                        SetLedColor(2, i, 165, 255, 0);
                        SetLedColor(3, i, 90, 255, 0);
                        SetLedColor(4, i, 0, 255, 0);
                        SetLedColor(5, i, 0, 255, 90);
                    }
                    break;
                case 4:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 255, 255, 0);
                        SetLedColor(1, i, 165, 255, 0);
                        SetLedColor(2, i, 90, 255, 0);
                        SetLedColor(3, i, 0, 255, 0);
                        SetLedColor(4, i, 0, 255, 90);
                        SetLedColor(5, i, 0, 255, 165);
                    }
                    break;
                case 5:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 165, 255, 0);
                        SetLedColor(1, i, 90, 255, 0);
                        SetLedColor(2, i, 0, 255, 0);
                        SetLedColor(3, i, 0, 255, 90);
                        SetLedColor(4, i, 0, 255, 165);
                        SetLedColor(5, i, 0, 255, 255);
                    }
                    break;
                case 6:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 90, 255, 0);
                        SetLedColor(1, i, 0, 255, 0);
                        SetLedColor(2, i, 0, 255, 90);
                        SetLedColor(3, i, 0, 255, 165);
                        SetLedColor(4, i, 0, 255, 255);
                        SetLedColor(5, i, 0, 165, 255);
                    }
                    break;
                case 7:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 0, 255, 0);
                        SetLedColor(1, i, 0, 255, 90);
                        SetLedColor(2, i, 0, 255, 165);
                        SetLedColor(3, i, 0, 255, 255);
                        SetLedColor(4, i, 0, 165, 255);
                        SetLedColor(5, i, 0, 90, 255);
                    }
                    break;
                case 8:
                    for (int i = 0; i < 22; i++)
                    {
                        
                        SetLedColor(0, i, 0, 255, 90);
                        SetLedColor(1, i, 0, 255, 165);
                        SetLedColor(2, i, 0, 255, 255);
                        SetLedColor(3, i, 0, 165, 255);
                        SetLedColor(4, i, 0, 90, 255);
                        SetLedColor(5, i, 0, 0, 255);
                    }
                    break;
                case 9:
                    for (int i = 0; i < 22; i++)
                    {   
                        SetLedColor(0, i, 0, 255, 165);
                        SetLedColor(1, i, 0, 255, 255);
                        SetLedColor(2, i, 0, 165, 255);
                        SetLedColor(3, i, 0, 90, 255);
                        SetLedColor(4, i, 0, 0, 255);
                        SetLedColor(5, i, 90, 0, 255);
                    }
                    break;
                case 10:
                    for (int i = 0; i < 22; i++)
                    {
                       
                        SetLedColor(0, i, 0, 255, 255);
                        SetLedColor(1, i, 0, 165, 255);
                        SetLedColor(2, i, 0, 90, 255);
                        SetLedColor(3, i, 0, 0, 255);
                        SetLedColor(4, i, 90, 0, 255);
                        SetLedColor(5, i, 165, 0, 255);
                    }
                    break;
                case 11:
                    for (int i = 0; i < 22; i++)
                    {                       
                        SetLedColor(0, i, 0, 165, 255);
                        SetLedColor(1, i, 0, 90, 255);
                        SetLedColor(2, i, 0, 0, 255);
                        SetLedColor(3, i, 90, 0, 255);
                        SetLedColor(4, i, 165, 0, 255);
                        SetLedColor(5, i, 255, 0, 255);
                    }
                    break;
                case 12:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 0, 90, 255);
                        SetLedColor(1, i, 0, 0, 255);
                        SetLedColor(2, i, 90, 0, 255);
                        SetLedColor(3, i, 165, 0, 255);
                        SetLedColor(4, i, 255, 0, 255);
                        SetLedColor(5, i, 255, 0, 165);
                    }
                    break;
                case 13:
                    for (int i = 0; i < 22; i++)
                    {                     
                        SetLedColor(0, i, 0, 0, 255);
                        SetLedColor(1, i, 90, 0, 255);
                        SetLedColor(2, i, 165, 0, 255);
                        SetLedColor(3, i, 255, 0, 255);
                        SetLedColor(4, i, 255, 0, 165);
                        SetLedColor(5, i, 255, 0, 90);
                    }
                    break;
                case 14:
                    for (int i = 0; i < 22; i++)
                    {            
                        SetLedColor(0, i, 90, 0, 255);
                        SetLedColor(1, i, 165, 0, 255);
                        SetLedColor(2, i, 255, 0, 255);
                        SetLedColor(3, i, 255, 0, 165);
                        SetLedColor(4, i, 255, 0, 90);
                        SetLedColor(5, i, 255, 0, 0);
                    }
                    break;
                case 15:
                    for (int i = 0; i < 22; i++)
                    {           
                        SetLedColor(0, i, 165, 0, 255);
                        SetLedColor(1, i, 255, 0, 255);
                        SetLedColor(2, i, 255, 0, 165);
                        SetLedColor(3, i, 255, 0, 90);
                        SetLedColor(4, i, 255, 0, 0);
                        SetLedColor(5, i, 255, 90, 0);   
                    }
                    break;
                case 16:
                    for (int i = 0; i < 22; i++)
                    {     
                        SetLedColor(0, i, 255, 0, 255);
                        SetLedColor(1, i, 255, 0, 165);
                        SetLedColor(2, i, 255, 0, 90);
                        SetLedColor(3, i, 255, 0, 0);
                        SetLedColor(4, i, 255, 90, 0);
                        SetLedColor(5, i, 255, 165, 0);
                    }
                    break;
                case 17:
                    for (int i = 0; i < 22; i++)
                    { 
                        SetLedColor(0, i, 255, 0, 165);
                        SetLedColor(1, i, 255, 0, 90);
                        SetLedColor(2, i, 255, 0, 0);
                        SetLedColor(3, i, 255, 90, 0);
                        SetLedColor(4, i, 255, 165, 0);
                        SetLedColor(5, i, 255, 255, 0);
                    }
                    break;
                case 18:
                    for (int i = 0; i < 22; i++)
                    {
                        SetLedColor(0, i, 255, 0, 90);
                        SetLedColor(1, i, 255, 0, 0);
                        SetLedColor(2, i, 255, 90, 0);
                        SetLedColor(3, i, 255, 165, 0);
                        SetLedColor(4, i, 255, 255, 0);
                        SetLedColor(5, i, 165, 255, 0);
                    }
                    frame = 0;
                    break;
            }
            frame++;
        }


        public void lightning() {


        }

        public void tide() {
            


        }

        public void rain() {

        }


    }
}
