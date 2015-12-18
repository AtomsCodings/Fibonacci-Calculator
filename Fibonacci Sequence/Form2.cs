/*****************************************************************************************************
* Page Version and Last Updated: Version 1.0 16/12/15 by A Thomas                                    *
*                                                                                                    *
* Code below only deals with displaying the Fibonacci explanation only.                              * 
*                                                                                                    *
* Methods in class FormFibonacciExplanation: event handlers                                          *
*                                                                                                    *
* Calculations for the fibonacci calculator display are made in the Fibonacci class in               *
* Fibonacci.cs file                                                                                  *
* Fibonacci display for the Fibonacci calculator is in FormFibonacci class in the Form1.cs file      *
*****************************************************************************************************/
using System;
using System.Windows.Forms;

namespace Fibonacci_Sequence
{
    public partial class FormFibonacciExplanation : Form
    {
        public FormFibonacciExplanation()
        {
            InitializeComponent();
        }

        private void quitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToMainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
