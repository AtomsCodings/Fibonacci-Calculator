/*****************************************************************************************************
* Page Version and Last Updated: Version 1.0 19/12/15 by A Thomas                                    *
*                                                                                                    *
* Code below only deals with displaying the Fibonacci sequence calculator only.                      * 
*                                                                                                    *
* Methods in class FormFibonacci: event handlers, CheckNToFindXnEntry(), CheckNToFindXnGoldenEntry(),* 
* ClearErrorAndAnswerMsgs(), ClearTextBoxes()                                                        *
*                                                                                                    *
* Calculations for this display are made in the Fibonacci class in Fibonacci.cs file                 *
* Fibonacci explanation page is in FormFibonacciExplanation class in the Form2.cs file               *
*                                                                                                    *                                                                                                   *
* The sequence has the pattern of:                                                                   * 
* (term)           n =  ...  -6   -5   -4   -3   -2   -1   0   1   2   3   4   5   6   ...           *
* (sequence no) x(n) =	...  -8    5   -3    2   -1    1   0   1   1   2   3   5   8   ...           *
*                                                                                                    *
* App is based on the formulas x(n) = x(n-1) + x(n-2), or the golden ratio formula                   *
* x(n) ≈ ( phi^n - (1 - phi)^n ) / √5.                                                               *
* n is the term and x(n) is the sequence number.                                                     *
*                                                                                                    *
* App designed for range to be term n= +/-45, and max entry to see if number is a X(n) = sequence    *
* number is +/- 2 * 10^9                                                                             *
*                                                                                                    *
* More information on the Fibonacci sequence itself is available in Form2.cs                         *
******************************************************************************************************/
using System;
using System.Windows.Forms;

namespace Fibonacci_Sequence
{
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reset form
            ClearTextBoxes();
            ClearErrorAndAnswerMsgs();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            CheckEntries();
        }

        private void explanationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFibonacciExplanation newform = new FormFibonacciExplanation();
            newform.Show();
        }

        /*commence my own methods to manipulate the current form object 
        ___________________________________________________________________________________________*/

        //clears any visible error and answer messages from previous usage
        //checks for an actual entry and display error message if necessary
        //if an entry exists, call on methods to check entries further & to perform calculations in Fibonacci class if appropriate
        public void CheckEntries()
        {
            ClearErrorAndAnswerMsgs();

            if (textBoxNTerm.Text == "" && textBoxNGoldenTerm.Text == "" && textBoxNoInSequence.Text == "")
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Error Message: Please enter a number before pressing Enter.";
            }
            else
            {
                if (textBoxNTerm.Text != "")
                    CheckNToFindXnEntry();
                if (textBoxNGoldenTerm.Text != "")
                    CheckNToFindXnGoldenEntry();
                if (textBoxNoInSequence.Text != "")
                    CheckNoInSequenceEntry();
            }
        }

        //check the first textbox entry: whole number, n-term range - and display error msg if appropriate
        //if entry OK, call on relevant method in Fibonacci class
        public void CheckNToFindXnEntry()
        {
            int nTerm = 0, xnAnswer = 0;

            if (int.TryParse(textBoxNTerm.Text, out nTerm))
            {
                if ((nTerm < -45) || (nTerm > 45))
                {
                    labelErrorMsg.Visible = true;
                    labelErrorMsg.Text = "Error Message: The first text box is out of the valid range of -45 to +45.";
                }
                else
                {
                    if (nTerm <= -1)
                        xnAnswer = Fibonacci.FindXnIfNSmallerThanZero(nTerm);
                    else if (nTerm >= 0)
                        xnAnswer = Fibonacci.FindXnIfNBiggerThanOrEqualsZero(nTerm);
                    labelNAnswerTerm.Visible = true;
                    labelNAnswerTerm.Text = "This term gives X(" + nTerm + ") = " + xnAnswer + " in the Fibonacci sequence.";
                }
            }
            else
            {
                labelErrorMsg.Visible = true;
                labelErrorMsg.Text = "Error Message: For the first text box, you can only enter a whole number in the range of +/-45.";
            }
        }

        //check the second textbox entry: whole number, n-term range - and display error msg if appropriate
        //if entry OK, call on relevant method in Fibonacci class
        public void CheckNToFindXnGoldenEntry()
        {
            int nGoldenTerm = 0;
            decimal xnGoldenAnswer = 0;

            if (int.TryParse(textBoxNGoldenTerm.Text, out nGoldenTerm))
            {
                if ((nGoldenTerm < -45) || (nGoldenTerm > 45))
                {
                    labelErrorMsg2.Visible = true;
                    labelErrorMsg2.Text = "Error Message: The second text box is out of the valid range of -45 to +45.";
                }
                else
                {
                    xnGoldenAnswer = Fibonacci.GoldenRatioFormula(nGoldenTerm);
                    labelGoldenAnswerTerm.Visible = true;
                    labelGoldenAnswerTerm.Text = "This term gives X(" + nGoldenTerm + ") ≈ " + xnGoldenAnswer + " in the Fibonacci sequence.";
                }
            }
            else
            {
                labelErrorMsg2.Visible = true;
                labelErrorMsg2.Text = "Error Message: For the second text box, you can only enter a whole number in the range of +/-45.";
            }
        }


        //check the third textbox entry: whole number, sequence range x(n) - and display error msg if appropriate
        //if entry OK, call on relevant method in Fibonacci class
        public void CheckNoInSequenceEntry()
        {
            int inSequenceNo = 0;
            int[] inSequenceOneNTermOrMore = new int[3] { -100, -100, -100 };
            int inSequenceOneNTerm = -100;

            if (int.TryParse(textBoxNoInSequence.Text, out inSequenceNo))
            {
                if ((inSequenceNo < -2000000000) || (inSequenceNo > 2000000000))
                {
                    labelErrorMsg3.Visible = true;
                    labelErrorMsg3.Text = "Error Message: The third text box is out of the valid range of -2000000000 to +2000000000.";
                }
                else
                {
                    if (inSequenceNo >= 0)
                    {
                        inSequenceOneNTermOrMore = Fibonacci.FindNIfXnBiggerThanOrEqualsZero(inSequenceNo);
                        if (inSequenceOneNTermOrMore[0] != -100)
                        {
                            labelIsInSequence1.Visible = true;
                            labelIsInSequence1.Text = "This number exists with the term number n = " + inSequenceOneNTermOrMore[0] + ". So X(" + inSequenceOneNTermOrMore[0] + ") = " + inSequenceNo + " in the Fibonacci sequence.";
                        }
                        if (inSequenceOneNTermOrMore[1] != -100)
                        {
                            labelIsInSequence2.Visible = true;
                            labelIsInSequence2.Text = "This number also exists with the term number n = " + inSequenceOneNTermOrMore[1] + ". So X(" + inSequenceOneNTermOrMore[1] + ") = " + inSequenceNo + " in the Fibonacci sequence.";
                        }
                        if (inSequenceOneNTermOrMore[2] != -100)
                        {
                            labelIsInSequence3.Visible = true;
                            labelIsInSequence3.Text = "This number also exists with the term number n = " + inSequenceOneNTermOrMore[2] + ". So X(" + inSequenceOneNTermOrMore[2] + ") = " + inSequenceNo + " in the Fibonacci sequence.";
                        }
                    }
                    else
                    {
                        inSequenceOneNTerm = Fibonacci.FindNIfXnSmallerThanZero(inSequenceNo);
                        if (inSequenceOneNTerm != -100)
                        {
                            labelIsInSequence1.Visible = true;
                            labelIsInSequence1.Text = "This number exists with the term number n = " + inSequenceOneNTerm + ". So X(" + inSequenceOneNTerm + ") = " + inSequenceNo + " in the Fibonacci sequence.";
                        }
                    }
                    if (inSequenceOneNTerm == -100 && inSequenceOneNTermOrMore[0] == -100)
                    {
                        labelIsInSequence1.Visible = true;
                        labelIsInSequence1.Text = "That number does not exist in the Fibonacci sequence.";
                    }

                }
            }
            else
            {
                labelErrorMsg3.Visible = true;
                labelErrorMsg3.Text = "Error Message: For the third text box, you can only enter a whole number in the range of +/- 2000000000.";
            }
        }

        public void ClearErrorAndAnswerMsgs()
        {
            labelErrorMsg.Visible = false;
            labelErrorMsg2.Visible = false;
            labelErrorMsg3.Visible = false;
            labelNAnswerTerm.Visible = false;
            labelGoldenAnswerTerm.Visible = false;
            labelIsInSequence1.Visible = false;
            labelIsInSequence2.Visible = false;
            labelIsInSequence3.Visible = false;
        }

        public void ClearTextBoxes()
        {
            textBoxNTerm.Text = "";
            textBoxNGoldenTerm.Text = "";
            textBoxNoInSequence.Text = "";
        }
    }
} 
        
   

