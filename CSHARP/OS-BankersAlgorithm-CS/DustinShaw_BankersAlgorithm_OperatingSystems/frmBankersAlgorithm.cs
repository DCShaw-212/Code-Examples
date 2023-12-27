//Name: Dustin Shaw
//Program: Banker's Algorithm
//Date: 10/14/2022



using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace DustinShaw_BankersAlgorithm_OperatingSystems
{
    public partial class frmBankersAlgorithm : Form
    {
        public frmBankersAlgorithm()
        {
            InitializeComponent();
        }

        //----------------DataMembers------------//////////////////////

        //---------For the initial Data and Displayed Data -----/////////

        List<string> fileStringList = new List<string>(); //list of strings from the .txt file
        List<Array> fileArrayList = new List<Array>(); //holds the array from the .split() function
        List<string> fileStringIndividuals = new List<string>(); //string array used for string manipulation
        int[,] fileIntArray; //int array that will build each of the smaller arrays responsible for calculations

        int numOfProccess; //the number of processes trying to run
        int numOfResourceTypes; //how many different resource types we are using
        int[] numOfInstances; //how many of each resource type we have available

        ///-------Allocations for each process-----/////
        ///How many of each resource types the process has reserved
        int[] allForP0;
        int[] allForP1;
        int[] allForP2;
        int[] allForP3;
        int[] allForP4;
        int[,] allocation = new int[5, 3];

        ///--------Maximum for each process-------/////
        ///The maximum demand of each process
        int[] maxForP0;
        int[] maxForP1;
        int[] maxForP2;
        int[] maxForP3;
        int[] maxForP4;
        int[,] max = new int[5, 3];

        ///-------Need for each process------///////
        ///The remaining resource needs of each process
        int[] needForP0;
        int[] needForP1;
        int[] needForP2;
        int[] needForP3;
        int[] needForP4;
        int[,] need = new int[5, 3];

        ///------Available Remaining Resources of each type-----/////
        int[] available;

        ///-------Extra Variables for indexing issues-------//////
        int maxValues;

        //Processes to be displayed to the gui and selected from during request
        string[] processes = { "P0", "P1", "P2", "P3", "P4" };

        //Solving the request problem
        int[] req = new int[3];
        

        //**When the form itself is loaded initially**//
        private void frmBankersAlgorithm_Load(object sender, EventArgs e)
        {
            
            foreach (var item in processes)
            {
                cboProcessRequest.Items.Add(item);
            }

            cboProcessRequest.SelectedIndex = 0;
 
        }

        ///----------The Button event section of the code --------//////

        //clicked when a process has made a new request, allowing the user to test addition resource requests
        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                
                ResourceRequest();//Calls the Resource-Request Algorithm when the request has been put through
                int s = cboProcessRequest.SelectedIndex;
                MessageBox.Show(s.ToString());

                
                    for (int j = 0; j < 3; j++)
                    {
                        lstSafeSequence.Items.Add(need[s, j].ToString());
                    }
                

            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Incorrect Input Formatting", "Argument Not Accepted");
            }



            this.RequestDisplay();
        }

        //When the browse button is clicked, the users file explorer  opens allowing them to choose
        //a .txt file to input into the algorithm
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {//allows the user to choose the .txt  file from the directory
                OpenFileDialog openFileDialog = new OpenFileDialog();
                //this line opens the file explorer
                openFileDialog.InitialDirectory = @"c://";
                //this line filters for .txt files only
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //this saves the place the the user chose the file from in the directory so they can go back
                openFileDialog.RestoreDirectory = true;



                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = "";
                    //get the file path
                    filePath = openFileDialog.FileName;
                    //display the file path to the gui
                    txtFileName.Text = filePath;

                    StreamReader textIn = new StreamReader(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read));

                    while (textIn.Peek() != -1)//check to make sure we are not at the end of the file
                    {
                        string row = textIn.ReadLine(); //read one line of the file at a time
                        fileStringList.Add(row); //add each line to a list of strings

                    }

                    //number of processes in the algorithm
                    numOfProccess = int.Parse(fileStringList[0]);

                    //number of resource types in the algorithm
                    numOfResourceTypes = int.Parse(fileStringList[1]);

                    //maxvalues to be used for indexing
                    maxValues = (numOfResourceTypes * numOfProccess * 2) + numOfResourceTypes;

                    int length = fileStringList.Count;
                    //clean up the data from the .txt file (deleting whitespaces)
                    foreach (var item in fileStringList)
                    {
                        string a = item.Trim();
                        a.Replace(" ", "");
                        string[] arr = a.Split();
                        fileArrayList.Add(arr);

                    }


                    //finding the remaining size of the array list
                    fileArrayList.RemoveAt(0);
                    fileArrayList.RemoveAt(0);


                    //creating individual values out of the .txt file data


                    foreach (var item in fileArrayList)
                    {
                        foreach (var val in item)
                        {
                            fileStringIndividuals.Add(val.ToString());
                        }
                    }

                    //converting string to integers
                    fileIntArray = new int[numOfProccess * 2 + 1, numOfResourceTypes];
                    int ind = 0;
                    for (int i = 0; i < fileStringList.Count; i++)
                    {

                        for (int j = 0; j < numOfResourceTypes; j++)
                        {
                            if (ind != maxValues)
                            {
                                fileIntArray[i, j] = int.Parse(fileStringIndividuals[ind]);
                                ind++;
                                continue;
                            }


                        }

                    }

                    /////-----------Setting the smaller arrays to be displayed to the gui -----//////

                    //Number of resource instances 
                    //Initialize(numOfInstances, 0);
                    numOfInstances = new int[numOfResourceTypes];
                    for (int i = 0; i < numOfResourceTypes; i++)
                    {
                        numOfInstances[i] = fileIntArray[0, i];
                    }

                    //Allocations
              
                    //P0
                    allForP0 = new int[numOfResourceTypes];
                    Initialize(allForP0, 1);

                    //P1
                    allForP1 = new int[numOfResourceTypes];
                    Initialize(allForP1, 2);
                    //P2
                    allForP2 = new int[numOfResourceTypes];
                    Initialize(allForP2, 3);
                    //P3
                    allForP3 = new int[numOfResourceTypes];
                    Initialize(allForP3, 4);
                    //P4
                    allForP4 = new int[numOfResourceTypes];
                    Initialize(allForP4, 5);
                    BuildAll();


                    //Maximum
                   
                    //P0
                    maxForP0 = new int[numOfResourceTypes];
                    Initialize(maxForP0, 6);
                    //P1
                    maxForP1 = new int[numOfResourceTypes];
                    Initialize(maxForP1, 7);
                    //P2
                    maxForP2 = new int[numOfResourceTypes];
                    Initialize(maxForP2, 8);
                    //P3
                    maxForP3 = new int[numOfResourceTypes];
                    Initialize(maxForP3, 9);
                    //P4
                    maxForP4 = new int[numOfResourceTypes];
                    Initialize(maxForP4, 10);
                    BuildMax();

                    //Need
                    need = Calc2DNeedArray();
                    //P0
                    needForP0 = new int[numOfResourceTypes];
                    needForP0 = NeedFill(0);
                    
                    //P1
                    needForP1 = new int[numOfResourceTypes];
                    needForP1 = NeedFill(1);
                    //P2
                    needForP2 = new int[numOfResourceTypes];
                    needForP2 = NeedFill(2);
                    //P3
                    needForP3 = new int[numOfResourceTypes];
                    needForP3 = NeedFill(3);

                    //P4
                    needForP4 = new int[numOfResourceTypes];
                    needForP4 = NeedFill(4);


                    //Available
                    available = new int[numOfResourceTypes];
                    CalcAvailable();

                    SafetyAlgorithm(); //Runs the safety algorithm for the first .txt upload

                    this.Display(); //displays the values to the gui
                    

                    textIn.Close();//close the stream reader to prevent errors

                    btnRequest.Enabled = true; //Enables the request button to work once a .txt file has been input into the program

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please try again.", "Something Went Wrong");
                throw;
            }
        }


        //when the exit button is pressed then the form will close
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-------------------------------Methods-----------------------------------------------//


        //converts data back into strings to be displayed in the gui
        private void Display()
        {
            txtNumberOfProcesses.Text = numOfProccess.ToString();
            txtNumberOfResourcesTypes.Text = numOfResourceTypes.ToString();

            txtNumberOfInstances.Text = (numOfInstances[0].ToString() + " " + numOfInstances[1].ToString() + " " + numOfInstances[2].ToString());

            txtAllocationForP0.Text = (allForP0[0].ToString() + " " + allForP0[1].ToString() + " " + allForP0[2].ToString());
            txtAllocationForP1.Text = (allForP1[0].ToString() + " " + allForP1[1].ToString() + " " + allForP1[2].ToString());
            txtAllocationForP2.Text = (allForP2[0].ToString() + " " + allForP2[1].ToString() + " " + allForP2[2].ToString());
            txtAllocationForP3.Text = (allForP3[0].ToString() + " " + allForP3[1].ToString() + " " + allForP3[2].ToString());
            txtAllocationForP4.Text = (allForP4[0].ToString() + " " + allForP4[1].ToString() + " " + allForP4[2].ToString());

            txtMaxP0.Text = (maxForP0[0].ToString() + " " + maxForP0[1].ToString() + " " + maxForP0[2].ToString());
            txtMaxP1.Text = (maxForP1[0].ToString() + " " + maxForP1[1].ToString() + " " + maxForP1[2].ToString());
            txtMaxP2.Text = (maxForP2[0].ToString() + " " + maxForP2[1].ToString() + " " + maxForP2[2].ToString());
            txtMaxP3.Text = (maxForP3[0].ToString() + " " + maxForP3[1].ToString() + " " + maxForP3[2].ToString());
            txtMaxP4.Text = (maxForP4[0].ToString() + " " + maxForP4[1].ToString() + " " + maxForP4[2].ToString());

            txtNeedForP0.Text = (needForP0[0].ToString() + " " + needForP0[1].ToString() + " " + needForP0[2].ToString());
            txtNeedForP1.Text = (needForP1[0].ToString() + " " + needForP1[1].ToString() + " " + needForP1[2].ToString());
            txtNeedForP2.Text = (needForP2[0].ToString() + " " + needForP2[1].ToString() + " " + needForP2[2].ToString());  
            txtNeedForP3.Text = (needForP3[0].ToString() + " " + needForP3[1].ToString() + " " + needForP3[2].ToString());
            txtNeedForP4.Text = (needForP4[0].ToString() + " " + needForP4[1].ToString() + " " + needForP4[2].ToString());

            txtAvailable.Text = (available[0].ToString() + " " + available[1].ToString() + " " + available[2].ToString());

            
        }

        private void RequestDisplay()
        {
            txtNumberOfProcesses.Text = numOfProccess.ToString();
            txtNumberOfResourcesTypes.Text = numOfResourceTypes.ToString();

            txtNumberOfInstances.Text = (numOfInstances[0].ToString() + " " + numOfInstances[1].ToString() + " " + numOfInstances[2].ToString());

                for (int j = 0; j < numOfResourceTypes; j++)
                {
                    allForP0[j] = allocation[0, j];
                    allForP1[j] = allocation[1, j];
                    allForP2[j] = allocation[2, j];
                    allForP3[j] = allocation[3, j];
                    allForP4[j] = allocation[4, j];
                }

                for (int j = 0; j < numOfResourceTypes; j++)
                {
                    maxForP0[j] = max[0, j];
                    maxForP1[j] = max[1, j];
                    maxForP2[j] = max[2, j];
                    maxForP3[j] = max[3, j];
                    maxForP4[j] = max[4, j];
                }

            NeedFill(0);
            NeedFill(1);
            NeedFill(2);
            NeedFill(3);
            NeedFill(4);


            txtAllocationForP0.Text = (allForP0[0].ToString() + " " + allForP0[1].ToString() + " " + allForP0[2].ToString());
            txtAllocationForP1.Text = (allForP1[0].ToString() + " " + allForP1[1].ToString() + " " + allForP1[2].ToString());
            txtAllocationForP2.Text = (allForP2[0].ToString() + " " + allForP2[1].ToString() + " " + allForP2[2].ToString());
            txtAllocationForP3.Text = (allForP3[0].ToString() + " " + allForP3[1].ToString() + " " + allForP3[2].ToString());
            txtAllocationForP4.Text = (allForP4[0].ToString() + " " + allForP4[1].ToString() + " " + allForP4[2].ToString());

            txtMaxP0.Text = (maxForP0[0].ToString() + " " + maxForP0[1].ToString() + " " + maxForP0[2].ToString());
            txtMaxP1.Text = (maxForP1[0].ToString() + " " + maxForP1[1].ToString() + " " + maxForP1[2].ToString());
            txtMaxP2.Text = (maxForP2[0].ToString() + " " + maxForP2[1].ToString() + " " + maxForP2[2].ToString());
            txtMaxP3.Text = (maxForP3[0].ToString() + " " + maxForP3[1].ToString() + " " + maxForP3[2].ToString());
            txtMaxP4.Text = (maxForP4[0].ToString() + " " + maxForP4[1].ToString() + " " + maxForP4[2].ToString());

            txtNeedForP0.Text = (needForP0[0].ToString() + " " + needForP0[1].ToString() + " " + needForP0[2].ToString());
            txtNeedForP1.Text = (needForP1[0].ToString() + " " + needForP1[1].ToString() + " " + needForP1[2].ToString());
            txtNeedForP2.Text = (needForP2[0].ToString() + " " + needForP2[1].ToString() + " " + needForP2[2].ToString());
            txtNeedForP3.Text = (needForP3[0].ToString() + " " + needForP3[1].ToString() + " " + needForP3[2].ToString());
            txtNeedForP4.Text = (needForP4[0].ToString() + " " + needForP4[1].ToString() + " " + needForP4[2].ToString());

            txtAvailable.Text = (available[0].ToString() + " " + available[1].ToString() + " " + available[2].ToString());
            
          

        }



        //**Fills the smaller arrays from the larger arrays and gives them their value**/
        public void Initialize(int[] arr, int ind)
        {

            for (int i = 0; i < numOfResourceTypes; i++)
            {

                arr[i] = fileIntArray[ind, i];

            }
        }

        public void UpdateArrays(int [,] arr2D , int [] arr, int ind)
        {
            for (int i = 0; i < 3; i++)
            {
                arr[i] = arr2D[ind, i];
            }
           
        }

        //**Converts the text entered into the gui into an integer array with no whitespace to used for calculation later **//
        public void BuildRequestArray()
        {
            int selected = cboProcessRequest.SelectedIndex;
            string s = txtProcessRequest.Text;
            int [] arr = new int[3];
            string[] stringArr = new string[3];

            if (ProcessSelected(s))
            {
                //delete any whitespace the user might have added
                s.Trim();
                s.Replace(" ", "");

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(s[i].ToString());
                }
                
            }

            for (int j = 0; j < 3; j++)
            {
                req[j] = arr[j];
            }
        
        }


        ///****Banker's Algorithm***/////


        ///***Safety Algorithm***/////
        ///

        public void SafetyAlgorithm()
        {
            int count = 0;
            List<string> SafeSequence = new List<string>();
            bool KeepChecking = true;
            bool[] Finish = new bool[numOfProccess];
            for (int i = 0; i < numOfProccess; i++)
            {
                Finish[i] = false;
            }
            
            while (KeepChecking)
            {
                for (int i = 0; i < 5; i++) //Step 2:
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Finish[i] == false && need[i, j] <= available[j])
                        {
                            Finish[i] = true;
                            available[j] = available[j] + allocation[i, j];
                            SafeSequence.Add(processes[i]);
                            count++;
                            //back to step 2:
                        }
                       
                    }
                }

                if (Finish[0] && Finish[1] && Finish[2] && Finish[3] && Finish[4])
                {
                    //MessageBox.Show("System is in a safe state");
                    KeepChecking = false;
                    break;
                }
                
            }
          
            string msg0 = SafeSequence[0];
            string msg1 = SafeSequence[1];
            string msg2 = SafeSequence[2];
            string msg3 = SafeSequence[3];
            string msg4 = SafeSequence[4];

            string msg = "Safe Sequence: < " + msg0 + " " + msg1 + " " + msg2 + " " + msg3 + " " + msg4 + " >";
            lstSafeSequence.Items.Add(msg);
            SafeSequence.Clear();


        }

        ///****Resource-Request Algorithm****///


        ///*** This function determines if a request can be met if it can will update the safesequence***///
        public void ResourceRequest()
        {
            int selected = cboProcessRequest.SelectedIndex; //the process that is requesting resources
            BuildRequestArray(); //creates the request array
            //pretend allocations
            int[] tempAvailable = available;
            int[] tempRequest = req;
            int[,] tempAll = allocation;
            int[,] tempNeed = need;
            List<string> SafeSequence = new List<string>();
            //variables to check the safe state

            bool[] finish = new bool[numOfProccess];
            for (int i = 0; i < finish.Length; i++)
            {
                finish[i] = false;
            }
            int count = 0;
            for (int j = 0; j < 3; j++)
            {
                if (req[j] <= need[selected, j] && req[j] <= available[j]) //checks if the process can claim anymore resources
                {
                    count++;
                }
                else
                {
                    lstSafeSequence.Items.Add("P[" + selected + "] has exceed its maximum claim and cannot run.");
                    lstSafeSequence.Items.Add(" Or P[" + selected + "] must wait. Resources are unavailable.");

                    break;
                }
            }
            if (count == 3)
            {
                  //temporarily allocate requested resources

                    for (int i = 0; i < 3; i++)
                    {
                        tempAvailable[i] = tempAvailable[i] - tempRequest[i];
                        tempAll[selected, i] = tempAll[selected, i] + tempRequest[i];
                        tempNeed[selected, i] = tempNeed[selected, i] - tempRequest[i];
                    }

                    for (int k = 0; k < numOfResourceTypes; k++)
                    {
                        if (need[selected, k] <= available[k]) //if safe -> The resources are allocated to Pi
                        {
                            allocation[selected, k] = tempAll[selected, k];
                            need[selected, k] = tempNeed[selected, k];
                            available[k] = tempAvailable[k];
                            
                            

                        }
                        //if unsafe -> Pi must wait and the old resource-allocating is restored
                    }

                RequestDisplay();

            }
               
            }
                 


        

        //**Test to see if the process was selected**///
        public bool ProcessSelected(string s)
        {
            if (s != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

  
        //**Calculates the need of each process**//
        public int [,] Calc2DNeedArray()
        {
            int[,] tempNeed = new int[5, 3];
            //max - all
            for (int i = 0; i < 5; i++)
            {
                for (int j  = 0; j < 3; j++)
                {

                    tempNeed[i, j] = max[i, j] - allocation[i, j];
                }
            }

            return tempNeed;
        }

        public int [] NeedFill(int ind)
        {
            int[] tempNeed = new int[3];
            for (int i = 0; i < numOfResourceTypes; i++)
            {
                tempNeed[i] = need[ind, i];
            }

            return tempNeed;
        }

        //**Calculates the total remaining amount of resources available for each type**//
        public void CalcAvailable()
        {
            int[] totalAllocated = new int[numOfResourceTypes];
            
                //total allocated
                for (int i = 0; i < numOfResourceTypes; i++)
                {
                    for (int j = 0; j < numOfProccess; j++)
                    {
                    totalAllocated[i]  += allocation[j, i];
                    }
                }

            ////number of instances - total allocated is available
            //available[i] = numOfInstances[i] - totalAllocated;
            for (int i = 0; i < numOfResourceTypes; i++)
            {
                available[i] = numOfInstances[i] - totalAllocated[i];
            }

            for (int i = 0; i < 3; i++)
            {
                lstSafeSequence.Items.Add(totalAllocated[i].ToString());
            }
             
        }

        /*Makes available into 2D array*/
        public void Calc2DAvailable()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    available[j] = numOfInstances[j] - allocation[i, j];
                }
            }

        }

        /*Builds a 2D array for all of the allocations */
        public void BuildAll()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(allForP0[j] < 0)
                    {
                        allForP0[j] *= -1;
                    }
                    allocation[i, j] = allForP0[j];
                }
            }

            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (allForP1[j] < 0)
                    {
                        allForP1[j] *= -1;
                    }
                    allocation[i, j] = allForP1[j];
                }
            }

            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (allForP2[j] < 0)
                    {
                        allForP2[j] *= -1;
                    }
                    allocation[i, j] = allForP2[j];
                }
            }

            for (int i = 3; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (allForP3[j] < 0)
                    {
                        allForP3[j] *= -1;
                    }
                    allocation[i, j] = allForP3[j];
                }
            }

            for (int i = 4; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (allForP4[j] < 0)
                    {
                        allForP4[j] *= -1;
                    }
                    allocation[i, j] = allForP4[j];
                }
            }
        }

        /*Builds a 2D array for all the processes maximums*/
        public void BuildMax()
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (maxForP0[j] < 0)
                    {
                        maxForP0[j] *= -1;
                    }
                    max[i, j] = maxForP0[j];
                }
            }

            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (maxForP1[j] < 0)
                    {
                        maxForP1[j] *= -1;
                    }
                    max[i, j] = maxForP1[j];
                }
            }

            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (maxForP2[j] < 0)
                    {
                        maxForP2[j] *= -1;
                    }
                    max[i, j] = maxForP2[j];
                }
            }

            for (int i = 3; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (maxForP3[j] < 0)
                    {
                        maxForP3[j] *= -1;
                    }
                    max[i, j] = maxForP3[j];
                }
            }

            for (int i = 4; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (maxForP4[j] < 0)
                    {
                        maxForP4[j] *= -1;
                    }
                    max[i, j] = maxForP4[j];
                }
            }
        }


    }
}
