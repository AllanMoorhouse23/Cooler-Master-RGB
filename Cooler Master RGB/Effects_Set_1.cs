using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cooler_Master_RGB
{
    class Effects_Set_1
    {
        public Effects_Set_1() {


        }

        Random random = new Random();

        private int pos_x = 0;
        private int pos_y = 0;
        private int randomChance = 0;
        public byte red = 255;
        public byte green = 0;
        public byte blue = 0;
        private int counter = 0;
        private string colorTo = "yellow";
        private int randomPos = 0;
        private bool checkCon = false;
        private int[] chosenOrder = new int[3] { -1, -1, -1 };

        [DllImport("SDKDLL.dll")]
        public static extern void SetLedColor(int row, int col, byte r, byte g, byte b);

        [DllImport("SDKDLL.dll")]
        public static extern void SetFullLedColor(byte r, byte g, byte b);

       // GEOFF WROTE THIS TEST COMMENT


        /// <summary>
        /// Line By Line Effect
        /// </summary>
        public void LineByLine() {
            if (pos_x > 21)
            {
                pos_x = 0;
                pos_y++;
            }
            else if (pos_y > 5)
            {
                pos_y = 0;
                pos_x = 0;
            }
            SetLedColor(pos_y, pos_x, red, green, blue);
            pos_x++;
            if (pos_x == 21 && pos_y == 5)
            {
                randomColor();
            }
        }


        /// <summary>
        /// Breathing Red Effect
        /// </summary>
        public void effectBreathing()
        {
            if (counter == 0)
            {
                red--;
            }
            else if (counter == 1)
            {
                red++;
            }
            if (red >= 255)
            {
                counter = 0;
            }
            else if (red <= 0)
            {
                counter = 1;
            }
            SetFullLedColor(red, green, blue);
        }


        /// <summary>
        /// Random Key Random Color Effect
        /// </summary>
        public void effectRandom()
        {
            pos_x = random.Next(0, 22);
            pos_y = random.Next(0, 6);
            randomColor();
            SetLedColor(pos_y, pos_x, red, green, blue);
        }


        /// <summary>
        /// Random Squares Effect
        /// </summary>
        public void effectRandomSquares()
        {

            pos_x = random.Next(0, 22);
            pos_y = random.Next(0, 6);

            //Center LED
            SetLedColor(pos_y, pos_x, red, green, blue);

            //Right
            SetLedColor(pos_y, (pos_x + 1), red, green, blue);
            //Left	
            SetLedColor(pos_y, (pos_x - 1), red, green, blue);
            //Up
            SetLedColor((pos_y - 1), pos_x, red, green, blue);
            //Down
            SetLedColor((pos_y + 1), pos_x, red, green, blue);

            //Top Left
            SetLedColor((pos_y - 1), (pos_x - 1), red, green, blue);
            //Top Right
            SetLedColor((pos_y - 1), (pos_x + 1), red, green, blue);
            //Bottom Left
            SetLedColor((pos_y + 1), (pos_x - 1), red, green, blue);
            //Bottom Right
            SetLedColor((pos_y + 1), (pos_x + 1), red, green, blue);

            randomColor();
        }


        /// <summary>
        /// Wipe Effect
        /// </summary>
        public void effectWipe()
        {

            for (int i = 0; i != 6; i++)
            {
                SetLedColor(i, pos_x, red, green, blue);
            }
            pos_x++;
            if (pos_x > 22)
            {
                randomColor();
            }
            if (pos_x > 22)
            {
                pos_x = 0;
            }
        }


        /// <summary>
        /// Random Lines Effects
        /// </summary>
        public void effectRandomLines()
        {
            SetLedColor(pos_y, pos_x, red, green, blue);
            //Move in current direction
            switch (counter)
            {
                case 0:
                    pos_x++;
                    break;
                case 1:
                    pos_y++;
                    break;
                case 2:
                    pos_x--;
                    break;
                case 3:
                    pos_y--;
                    break;
            }
            SetLedColor(pos_y, pos_x, red, green, blue);
            //As line is moving along select randomly to change direction
            //Biased towards going in the same direction
            randomChance = random.Next(0, 20);
            switch (randomChance)
            {
                case 0:
                    counter = 0;
                    break;
                case 1:
                    counter = 1;
                    break;
                case 2:
                    counter = 2;
                    break;
                case 3:
                    counter = 3;
                    break;
            }
            //If the line goes out of bounds turn off all keys
            if (pos_x > 21 || pos_x < 0 || pos_y < 0 || pos_y > 5)
            {
                SetFullLedColor(0, 0, 0);
                //Set new random location on edge of keyboard
                randomChance = random.Next(0,4);
                if (randomChance == 0)
                {
                    //Top
                    pos_x = random.Next(0,22);
                    pos_y = 0;
                }
                else if (randomChance == 1)
                {
                    //Bottom
                    pos_x = random.Next(0, 22);
                    pos_y = 5;
                }
                else if (randomChance == 2)
                {
                    //Left
                    pos_x = 0;
                    pos_y = random.Next(0, 6);
                }
                else
                {
                    //Right
                    pos_x = 21;
                    pos_y = random.Next(0, 6);
                }
                randomColor();
            }
        }


        /// <summary>
        /// Snake Line By Line Effect
        /// </summary>
        public void effectSnakeLineByLine()
        {
            SetLedColor(pos_y, pos_x, red, green, blue);
            switch (counter)
            {
                case 0:
                    pos_x++;
                    break;
                case 1:
                    pos_x--;
                    break;
            }
            switch (pos_x)
            {
                case 21:
                    SetLedColor(pos_y, pos_x, red, green, blue);
                    pos_y++;
                    SetLedColor(pos_y, pos_x, red, green, blue);
                    counter = 1;
                    break;
                case 0:
                    SetLedColor(pos_y, pos_x, red, green, blue);
                    pos_y++;
                    SetLedColor(pos_y, pos_x, red, green, blue);
                    counter = 0;
                    break;
            }
            if (pos_y > 5)
            {
                pos_x = 0;
                pos_y = 0;
                counter = 0;
                randomColor();
            }

        }


        /// <summary>
        /// Spiral Effect
        /// </summary>
        public void effectSpiral()
        {


            SetLedColor(pos_y, pos_x, red, green, blue);
            //Move in current direction
            switch (counter)
            {
                case 0:
                    pos_x++;
                    break;
                case 1:
                    pos_y++;
                    break;
                case 2:
                    pos_x--;
                    break;
                case 3:
                    pos_y--;
                    break;
            }



            //Change direction at certain points
            if (pos_x == 21 && pos_y == 0)
            {
                //Downwards
                counter = 1;

            }
            else if (pos_x == 21 && pos_y == 5)
            {
                //Left
                counter = 2;

            }
            else if (pos_x == 0 && pos_y == 5)
            {
                //Upwards
                counter = 3;

            }
            else if (pos_x == 0 && pos_y == 1)
            {
                //Right
                counter = 0;

            }
            else if (pos_x == 20 && pos_y == 1)
            {
                //Downward
                counter = 1;

            }
            else if (pos_x == 20 && pos_y == 4)
            {
                //Left
                counter = 2;

            }
            else if (pos_x == 1 && pos_y == 4)
            {
                //Upwards
                counter = 3;

            }
            else if (pos_x == 1 && pos_y == 2)
            {
                //Right
                counter = 0;

            }
            else if (pos_x == 19 && pos_y == 2)
            {
                //Downward
                counter = 1;

            }
            else if (pos_x == 19 && pos_y == 3)
            {
                //Left
                counter = 2;

            }
            else if (pos_x == 2 && pos_y == 3)
            {
                SetLedColor(pos_y, pos_x, red, green, blue);
                //Reset to start pos
                counter = 0;
                pos_x = 0;
                pos_y = 0;
                randomColor();
            }

        }


        /// <summary>
        /// 
        /// </summary>
        public void effectRandomSelectedLine()
        {

            SetLedColor(pos_y, pos_x, red, green, blue);

            //Move in current direction
            switch (counter)
            {
                case 0:
                    pos_x++;
                    break;
                case 1:
                    pos_y++;
                    break;
                case 2:
                    pos_x--;
                    break;
                case 3:
                    pos_y--;
                    break;
            }

            SetLedColor(pos_y, pos_x, red, green, blue);

            //If the line goes out of bounds turn off all keys
            if (pos_x > 21 || pos_x < 0 || pos_y < 0 || pos_y > 5)
            {
                SetFullLedColor(255, 255, 255);

                //Set new random location on edge of keyboard
                randomChance = random.Next(0, 4);

                if (randomChance == 0)
                {
                    //Top
                    pos_x = random.Next(0, 22);
                    pos_y = 0;
                    counter = 1;
                }
                else if (randomChance == 1)
                {
                    //Bottom
                    pos_x = random.Next(0, 22);
                    pos_y = 5;
                    counter = 3;
                }
                else if (randomChance == 2)
                {
                    //Left
                    pos_x = 0;
                    pos_y = random.Next(0, 6);
                    counter = 0;
                }
                else
                {
                    //Right
                    pos_x = 21;
                    pos_y = random.Next(0, 6);
                    counter = 2;
                }
                randomColor();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void effectAltLines()
        {

            if (counter == 0)
            {
                SetLedColor(0, pos_x, red, green, blue);
                SetLedColor(1, 22 - pos_x, red, green, blue);
                SetLedColor(2, pos_x, red, green, blue);
                SetLedColor(3, 22 - pos_x, red, green, blue);
                SetLedColor(4, pos_x, red, green, blue);
                SetLedColor(5, 22 - pos_x, red, green, blue);
                pos_x++;
            }
            else
            {
                SetLedColor(0, 22 - pos_x, red, green, blue);
                SetLedColor(1, pos_x, red, green, blue);
                SetLedColor(2, 22 - pos_x, red, green, blue);
                SetLedColor(3, pos_x, red, green, blue);
                SetLedColor(4, 22 - pos_x, red, green, blue);
                SetLedColor(5, pos_x, red, green, blue);
                pos_x++;
            }
            if (pos_x == 22)
            {
                if (counter == 1)
                {
                    counter = 0;
                }
                else
                {
                    counter = 1;
                }
                pos_x = 0;
                randomColor();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public void effectBall()
        {
            //Hit the top
            if (counter == 0 && pos_y == 0)
            {
                counter = 3;
            }
            if (counter == 1 && pos_y == 0)
            {
                counter = 2;
            }
            //Hit the left
            if (counter == 3 && pos_x == 0)
            {
                counter = 2;
            }
            if (counter == 0 && pos_x == 0)
            {
                counter = 1;
            }
            //Hit the bottom
            if (counter == 2 && pos_y == 5)
            {
                counter = 1;
            }
            if (counter == 3 && pos_y == 5)
            {
                counter = 0;
            }
            //Hit the right
            if (counter == 2 && pos_x == 21)
            {
                counter = 3;
            }
            if (counter == 1 && pos_x == 21)
            {
                counter = 0;
            }
            //Turn off trail
            SetLedColor(pos_y - 1, pos_x - 1, 0, 0, 0);
            SetLedColor(pos_y - 1, pos_x, 0, 0, 0);
            SetLedColor(pos_y - 1, pos_x + 1, 0, 0, 0);
            SetLedColor(pos_y, pos_x - 1, 0, 0, 0);
            SetLedColor(pos_y, pos_x + 1, 0, 0, 0);
            SetLedColor(pos_y + 1, pos_x - 1, 0, 0, 0);
            SetLedColor(pos_y + 1, pos_x, 0, 0, 0);
            SetLedColor(pos_y + 1, pos_x + 1, 0, 0, 0);
            switch (counter)
            {
                case 0:
                    SetLedColor(pos_y, pos_x, 0, 255, 0);
                    //Shift Up and to the Left
                    pos_x--;
                    pos_y--;
                    break;
                case 1:
                    SetLedColor(pos_y, pos_x, 0, 255, 0);
                    //Shift Up and to the Right
                    pos_x++;
                    pos_y--;
                    break;
                case 2:
                    SetLedColor(pos_y, pos_x, 0, 255, 0);
                    //Shift Down and to the Right
                    pos_x++;
                    pos_y++;
                    break;
                case 3:
                    SetLedColor(pos_y, pos_x, 0, 255, 0);
                    //Shift Down and to the Left
                    pos_x--;
                    pos_y++;
                    break;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        public void effectColorCycle()
        {

            if (colorTo == "yellow")
            {
                green += 5;
            }
            else if (colorTo == "green")
            {
                red -= 5;
            }
            else if (colorTo == "aqua")
            {
                blue += 5;
            }
            else if (colorTo == "blue")
            {
                green -= 5;
            }
            else if (colorTo == "pink")
            {
                red += 5;
            }
            else if (colorTo == "red")
            {
                blue -= 5;
            }

            SetFullLedColor(red, green, blue);

            if (red == 255 && green == 0 && blue == 255)
            {
                colorTo = "red";
            }
            else if (red == 255 && green == 0 && blue == 0)
            {
                colorTo = "yellow";
            }
            else if (red == 255 && green == 255 && blue == 0)
            {
                colorTo = "green";
            }
            else if (red == 0 && green == 255 && blue == 0)
            {
                colorTo = "aqua";
            }
            else if (red == 0 && green == 255 && blue == 255)
            {
                colorTo = "blue";
            }
            else if (red == 0 && green == 0 && blue == 255)
            {
                colorTo = "pink";
            }

        }







        private void randomColor()
        {

            chosenOrder[0] = -1;
            chosenOrder[1] = -1;
            chosenOrder[2] = -1;

            randomPos = random.Next(0, 3);
            chosenOrder[randomPos] = 255;
            checkCon = false;

            while (checkCon == false)
            {
                randomPos = random.Next(0, 3);
                if (chosenOrder[randomPos] == -1)
                {
                    chosenOrder[randomPos] = 0;
                    checkCon = true;
                }
            }

            checkCon = false;

            while (checkCon == false)
            {
                randomPos = random.Next(0, 3);
                if (chosenOrder[randomPos] == -1)
                {
                    chosenOrder[randomPos] = random.Next(0, 256);
                    checkCon = true;
                }
            }

            red = Convert.ToByte(chosenOrder[0]);
            green = Convert.ToByte(chosenOrder[1]);
            blue = Convert.ToByte(chosenOrder[2]);

           

        }




    }
}
