using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assn3Template
{
    public partial class Form1 : Form
    {
        const int PANEL_SIZE = 25;
        const int SQUARE_SIZE = 10;
        Panel[,] panelArray = new Panel[SQUARE_SIZE, SQUARE_SIZE];
        Color[,] colorArray = new Color[SQUARE_SIZE, SQUARE_SIZE];
        



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SQUARE_SIZE; i++)
            {
                for (int j = 0; j < SQUARE_SIZE; j++)
                {
                    Panel nextPanel = new Panel();
                    panelArray[i, j] = nextPanel;
                    nextPanel.BackColor = Color.DarkGray;
                    nextPanel.Size = new Size(PANEL_SIZE, PANEL_SIZE);
                    nextPanel.Location = new Point(10 + (PANEL_SIZE + 10) * j, 10 + (PANEL_SIZE + 10) * i);
                    nextPanel.Click += new EventHandler(clickPanel);

                    ((Form)sender).Controls.Add(nextPanel);


                }

            }
        }

        private void clickPanel(object sender, EventArgs e)
        {
            //Initialize the variable for the panel

            Panel colorPanel = (Panel)(sender);

            //Conditional statements to change panel color when clicked.

            if (colorPanel.BackColor == Color.DarkGray)
            {
                colorPanel.BackColor = Color.Green;
            }
            else if (colorPanel.BackColor == Color.Green)
            {
                colorPanel.BackColor = Color.DarkGray;
            }



        }

        private void btnOneIteration_Click(object sender, EventArgs e)
        {
            RunOneIteration();
        }

        //Main part of the program



        //Function to test if indicies are valid

        public static bool IndicieTest(int value1, int value2)
        {

            if (value1 < 0 && value2 < 0)
                return false;
            else if (value1 >= SQUARE_SIZE && value2 >= SQUARE_SIZE)
                return false;
            else
                return true;
        }

        // Runs the game and sets the colors

        public void RunOneIteration()
        {
            for (int i = 0; i < SQUARE_SIZE; i++)
            {
                for (int j = 0; j < SQUARE_SIZE; j++)
                {

                    
                    Color[,] huePanel = new Color[SQUARE_SIZE, SQUARE_SIZE];


                    foreach (Panel panel in panelArray)

                    {
                        int neighbors = 0;
                        //Checks indicie validation while it's true run

                        

                        //Checks if the color is green, if yes add to neighbors

                        //Checks neighbor to the east
                       if (IndicieTest(i, j + 1))
                       {
                            if (huePanel[i, j + 1] == Color.Green)
                              neighbors++;
                       }

                        //Checks neighbor to the southeast
                       if (IndicieTest(i + 1, j + 1))
                        {
                            if (huePanel[i + 1, j + 1] == Color.Green)
                                neighbors++;
                        }

                        //checks neighbor to the south
                        if (IndicieTest(i + 1, j) && huePanel[i + 1, j] == Color.Green)
                        {
                            if (huePanel[i + 1, j] == Color.Green)
                                neighbors++;
                        }

                        //checks neighbor to the the southwes
                        if (IndicieTest(i + 1, j - 1))
                        {
                            if (huePanel[i + 1, j - 1] == Color.Green)
                                neighbors++;
                        }

                        //Checks neighbor to the west
                        if (IndicieTest(i, j - 1))
                        {
                            if (panelArray[i, j - 1].BackColor == Color.Green)
                                neighbors++;
                        }

                        //checks neighbor to the northwest

                        if (IndicieTest(i - 1, j - 1))
                        {
                            if (panelArray[i - 1, j - 1].BackColor == Color.Green)
                                neighbors++;
                        }

                        //checks neighbor to the north

                        if (IndicieTest(i - 1, j))
                        {
                            if (panelArray[i - 1, j].BackColor == Color.Green)
                                neighbors++;
                        }

                        //checks neighbor to the northeast

                        if (IndicieTest(i - 1, j + 1))
                        {
                            if (panelArray[i - 1, j + 1].BackColor == Color.Green)
                                neighbors++;
                        }



                        //Game Logic Rules

                        //Underpopulation Death

                        if (neighbors < 2 && panelArray[i, j].BackColor == Color.Green)
                        {
                            huePanel[i, j] = Color.DarkGray;
                            panelArray[i, j].BackColor = huePanel[i, j];
                        }

                        //lives

                        else if (neighbors == 2 || neighbors == 3)

                        {
                            if (panelArray[i, j].BackColor == Color.Green)
                            {
                                huePanel[i, j] = Color.Green;
                                panelArray[i, j].BackColor = huePanel[i, j];
                            }
                        }

                        //Over Population Death

                        else if (neighbors > 3 && panelArray[i, j].BackColor == Color.Green)

                        {
                            huePanel[i, j] = Color.DarkGray;
                            panelArray[i, j].BackColor = huePanel[i, j];
                        }

                        //Reproduction

                        else if (neighbors == 3 && panelArray[i,j].BackColor == Color.DarkGray)

                        {
                            huePanel[i, j] = Color.Green;
                            panelArray[i, j].BackColor = huePanel[i, j];
                        }

                        else

                        {
                            huePanel[i, j] = Color.DarkGray;
                        }



                        Refresh();

                        //panelArray[i, j].BackColor = huePanel[i, j];


                    }
            
                }
            }

            
        }

        private void multiIteration_Click(object sender, EventArgs e)
        {
            //set var for iteration

            int iteration = (int)iterationCount.Value;


            // Loops for multiple iterations of the game
            for (int i = 0; i < iteration; i++)
            {
                RunOneIteration();

                System.Threading.Thread.Sleep(1000);
            }
        }


    }
}
    


