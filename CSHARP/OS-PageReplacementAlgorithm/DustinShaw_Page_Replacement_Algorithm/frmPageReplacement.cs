//Name: Dustin Shaw
//Program: Page Replacement Algorithm
//Date: 11/9/2022


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DustinShaw_Page_Replacement_Algorithm
{
    public partial class frmPageReplacement : Form
    {
        public frmPageReplacement()
        {
            InitializeComponent();
        }

        //Datamembers of the program
        LinkedList <string> referenceStringList = new LinkedList<string>();
        LinkedList <string> fifoInFrames = new LinkedList<string>();
        LinkedList<string> lruInFrames = new LinkedList<string>();
        LinkedList<string> lruCheckBack = new LinkedList<string>();
        LinkedList<string> optInFrames = new LinkedList<string>();
        LinkedList<string> optCheckForward = new LinkedList<string>();

        List<string> displayList = new List<string>();
        

        int numOfFrames = 0;
        int refListSize = 20;
        int fifoPageFaults = 0;
        int lruPageFaults = 0;
        int optPageFaults = 0;

        //Things to do when the form is loaded

        private void frmPageReplacement_Load(object sender, EventArgs e)
        {
            //building the combo box so the user can select how many frames they need
            cboFramesSelected.Items.Add(1);
            cboFramesSelected.Items.Add(2);
            cboFramesSelected.Items.Add(3);
            cboFramesSelected.Items.Add(4);
            cboFramesSelected.Items.Add(5);
            cboFramesSelected.Items.Add(6);
            cboFramesSelected.Items.Add(7);

            cboFramesSelected.SelectedIndex = 0;
        }


        //Input section where input is taken in and processed then returned to the user
        private void btnSort_Click(object sender, EventArgs e)
        {
            //Check to see if the user wanted a random reference string
            if (cbRandomReference.Checked)
            {
                //generate a random reference string
                Random randInt = new Random();

                //Building the display for the reference string randomly
                for (int i = 0; i < 20; i++)
                {
                    displayList.Add(randInt.Next(0, 9).ToString());
                    
                }

                //display the random reference string to the user
                for (int i = 0; i < 20; i++)
                {
                    txtUserEnteredReference.Text += " " + displayList[i].ToString();
                }
            }
            else
            {
                //check if the user has entered their own reference string
                if (txtUserEnteredReference.Text != "")
                {
                    //set the user ref string to the ref string list
                    RemoveSpace(txtUserEnteredReference);
                    

                    if (displayList.Count == 20)
                    {
                        //display the users own reference string back to them
                        txtUserEnteredReference.Clear();
                        for (int i = 0; i < 20; i++)
                        {
                           
                            txtUserEnteredReference.Text += " " + displayList[i].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Reference string must be of size 20.", "Reference String Size Error");
                    }
                   
                }
                else// inform the user that they haven not selected to do random ref string and they have not entered their own
                {
                    MessageBox.Show("You have not chosen a reference string.");
                }
            }

            //setting the number of frames from the combobox
            numOfFrames = Convert.ToInt32(cboFramesSelected.SelectedItem);

            BuildReferenceList(); //Creates the linked list to be fed into the algorithms

            //Running The Alogorithms here
            FirstInLastOut();
            LeastRecentlyUsed();
            Optimal();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBTN_Click(object sender, EventArgs e) //clears the entire board so the user can start over. 
        {
            txtUserEnteredReference.Clear();

            referenceStringList.Clear();

            fifoInFrames.Clear();
            lruInFrames.Clear();
            optInFrames.Clear();

            numOfFrames = 0;
            cboFramesSelected.SelectedIndex = 0;

            displayList.Clear();

            fifoPageFaults = 0;
            lruPageFaults = 0;
            optPageFaults = 0;


        }


        ///////////////////////////Algorithms/////////////////////////////// 


        ///********************First-In Last Out**********************//////
        
        public void FirstInLastOut()
        {


            while (referenceStringList.Count != 0) //when this loop ends we know we've checked every number
            {

                int count = 0;

                while (count < numOfFrames) //Fills the intial values into the frame
                {
                    if (!fifoInFrames.Contains(referenceStringList.ElementAt(0).ToString())) //check if the item in the frame is the same as the next item in the reference string
                    {
                        fifoInFrames.AddLast(referenceStringList.ElementAt(0).ToString()); //adds the first value into the frames
                        fifoPageFaults++; //adds to the page fault count
                        referenceStringList.RemoveFirst(); //removes the first node of the input string linked list
                        count++; //increases count to see if the frames
                    }
                    else
                    {
                        referenceStringList.RemoveFirst(); //just remove the first value in reference list, because it was used and we no longer need it
                    }
                }

                while (referenceStringList.Count != 0)
                {
                    if (!fifoInFrames.Contains(referenceStringList.ElementAt(0).ToString())) //check if the item in the frame is the same as the next item in the reference string
                    {
                        fifoInFrames.RemoveFirst(); //Take the olderst value off the frames which happens to be the top or first
                        fifoInFrames.AddLast(referenceStringList.ElementAt(0).ToString()); //add the value from the refList to the bottom of the frames
                        fifoPageFaults++; //incremement the number of page faults
                    }
                

                    referenceStringList.RemoveFirst(); //remove the first node from the refList because it has been used
                }
             
            }

            //Distplay the number of FIFO page faults to the list box
            lstOutPut.Items.Add("The number of page faults with FIFO is " + fifoPageFaults);

            //Rebuild the reference string list
            BuildReferenceList();
           

        }


        ///********************Least-Recently Used*******************///////
        

        public void LeastRecentlyUsed()
        {
            int countFrames = 0;
            int refCounter = 0;
            LinkedListNode<string> lruPointer = referenceStringList.First;

            while (countFrames < numOfFrames) //Fill the initial frames
            {
                if (!lruInFrames.Contains(lruPointer.Value)) //check if the item in the frame is the same as the next item in the reference string
                {
                    lruInFrames.AddLast(lruPointer.Value); //adds the first value into the frames
                    lruPageFaults++; //adds to the page fault count
                    countFrames++; //increases count to see if the frames have been filled
                }
                else //The frames did contain the value from the reference string so we want to put it into order of lru
                {
                    lruInFrames.Remove(lruPointer.Value); //Removes the value from its position in the frame linked list
                    lruInFrames.AddLast(lruPointer.Value); //Adds it to the end of frame signifying that its the most recently used value
                }

                lruPointer = lruPointer.Next; //moves the 'pointer' to the next position in the reference string
               
            }

            while (refCounter < refListSize && lruPointer != null) //Goes through the entire reference string
            {
                if(!lruInFrames.Contains(lruPointer.Value)) //The frames were filled so we're checking here if the newest refString value is in the frames
                {
                    lruInFrames.RemoveFirst(); //The value was not in the frames so we'll remove the oldest occurring value
                    lruPageFaults++; //increasing the page faults because the value was not in the frames
                    lruInFrames.AddLast(lruPointer.Value); //add the most recently used value to the end of the frames
                }
                else
                {
                    lruInFrames.Remove(lruPointer.Value); //The value was in the frames, so we removed it
                    lruInFrames.AddLast(lruPointer.Value); //Then placed it at the end frame to signify that it was just used
                }

                lruPointer = lruPointer.Next; //move to the next value in refList

                refCounter++; //inc the counter to go through the whole reference list
            }
            //MessageBox.Show("The oldest value was found: " + oldestValueFound + " times.");
            //Display the number of LRU page faults to the list box
            lstOutPut.Items.Add("The number of page faults with LRU is " + lruPageFaults);
            

        }

        ///*************************Optimal***************************//////

        public void Optimal()
        {
            int countFrames = 0; //used to fill the frames
            int refCount = 0; //used to go through the entire reference list
            LinkedListNode<string> optFillPointer = referenceStringList.First; // this will be used to fill the frames 
            LinkedListNode<string> optSearchPointer = optFillPointer.Next; //A pointer we'll use to index the reference list but backwards to check which value will not be used for the longest time
            LinkedList<string> order = new LinkedList<string>();

            while (countFrames < numOfFrames) //fill the initial frames to run optimal
            {
               if(!optInFrames.Contains(optFillPointer.Value))
                {
                    optInFrames.AddLast(optFillPointer.Value); //adds the first value into the frames
                    optPageFaults++; //adds to the page fault count
                    countFrames++; //increases count to see if the frames have been filled
                }

                optFillPointer = optFillPointer.Next; //move the fill pointer to the next node in the reference list
                optSearchPointer = optFillPointer.Next; //Move the search pointer to the next node in the reference list
            }

            refCount = refListSize - numOfFrames;
           
         

            while (optFillPointer != null) //cycle through the entire reference list
            {
                //search through the refList to check when the values in the frames will be used next and place the least likely to be used at the top
                while(optSearchPointer!= null && optInFrames.Contains(optFillPointer.Value))
                {
                  
                    if (optInFrames.Contains(optSearchPointer.Value)) //check to see if the value is in the frame
                    {
                        optInFrames.Remove(optSearchPointer.Value);
                        optInFrames.AddLast(optSearchPointer.Value);
                      //  MessageBox.Show(optSearchPointer.Value);
                    }

                    optSearchPointer = optSearchPointer.Next;

                }

                optSearchPointer = optFillPointer.Next; // Research the search pointer so the loop can continue running

                if (!optInFrames.Contains(optFillPointer.Value)) //Check to see if the value in the reference list was in the frame
                {
                    optInFrames.RemoveFirst(); //Since the first value is supposedly the least likely to occur value we're going to replace it
                    optInFrames.AddFirst(optFillPointer.Value); // Add the new value to the first position
                    optPageFaults++; //increase page faults because the value wasn't in the frame
                }
               
                optFillPointer = optFillPointer.Next; //move to the next value in refList
                
                if(optFillPointer != null)
                {
                    optSearchPointer = optFillPointer.Next; //move to the value just beyond the fill pointer

                }
                refCount++; //inc the counter to go through the whole reference list


            }
          
            //Display the number of Opt page faults to the list box
            lstOutPut.Items.Add("The number of page faults with Opt is " + optPageFaults);
        
        }

        /////***********************Conversion Methods********************///////////////////////


        private void RemoveSpace(TextBox text) //Takes the reference string that the user has input
                                               //Converts it to a string, and trims of any unwanted white spaces
                                               //Then adds it to the reference string list to be used later
        {
            string s = text.Text;
            s.Trim();
            s.Replace(" ", "");
            string[] arr = s.Split();

            foreach (var item in arr)
            {
                foreach (var val in item)
                {
                    displayList.Add(val.ToString());
                }

            }

        }

        //Convert the displayList into a Linked list to be used for the algorithms
        public void BuildReferenceList()
        {

            for (int i = 0; i < 20; i++)
            {
                referenceStringList.AddLast(displayList[i]);
            }

        }

    }
}
