namespace Fibonacci_Sequence
{
    partial class FormFibonacci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFibonacci));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explanationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelNFormulaStatic = new System.Windows.Forms.Label();
            this.labelGoldenFormulaStatic = new System.Windows.Forms.Label();
            this.labelNoInSequenceStatic = new System.Windows.Forms.Label();
            this.textBoxNTerm = new System.Windows.Forms.TextBox();
            this.textBoxNGoldenTerm = new System.Windows.Forms.TextBox();
            this.textBoxNoInSequence = new System.Windows.Forms.TextBox();
            this.labelNAnswerTerm = new System.Windows.Forms.Label();
            this.labelGoldenAnswerTerm = new System.Windows.Forms.Label();
            this.labelIsInSequence1 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelErrorMsg = new System.Windows.Forms.Label();
            this.labelNoteStatic = new System.Windows.Forms.Label();
            this.labelErrorMsg2 = new System.Windows.Forms.Label();
            this.labelErrorMsg3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelIsInSequence2 = new System.Windows.Forms.Label();
            this.labelIsInSequence3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.explanationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.quitToolStripMenuItem.Text = "Quit Application";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // explanationToolStripMenuItem
            // 
            this.explanationToolStripMenuItem.Name = "explanationToolStripMenuItem";
            this.explanationToolStripMenuItem.Size = new System.Drawing.Size(222, 20);
            this.explanationToolStripMenuItem.Text = "Explanation of the Fibonacci Sequence";
            this.explanationToolStripMenuItem.Click += new System.EventHandler(this.explanationToolStripMenuItem_Click);
            // 
            // labelNFormulaStatic
            // 
            this.labelNFormulaStatic.AutoSize = true;
            this.labelNFormulaStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNFormulaStatic.Location = new System.Drawing.Point(35, 116);
            this.labelNFormulaStatic.Name = "labelNFormulaStatic";
            this.labelNFormulaStatic.Size = new System.Drawing.Size(415, 13);
            this.labelNFormulaStatic.TabIndex = 1;
            this.labelNFormulaStatic.Tag = " ";
            this.labelNFormulaStatic.Text = "1.  Find the nth term of the Fibonacci sequence using the formula X(n) = X(n-1) +" +
    " X(n-2)";
            // 
            // labelGoldenFormulaStatic
            // 
            this.labelGoldenFormulaStatic.AutoSize = true;
            this.labelGoldenFormulaStatic.Location = new System.Drawing.Point(35, 202);
            this.labelGoldenFormulaStatic.Name = "labelGoldenFormulaStatic";
            this.labelGoldenFormulaStatic.Size = new System.Drawing.Size(563, 13);
            this.labelGoldenFormulaStatic.TabIndex = 2;
            this.labelGoldenFormulaStatic.Text = "2. Find the approximate nth term of the Fibonacci sequence using the golden ratio" +
    " formula X(n) ≈ ( ϕ^n - (1 - ϕ)^n ) / √5";
            // 
            // labelNoInSequenceStatic
            // 
            this.labelNoInSequenceStatic.AutoSize = true;
            this.labelNoInSequenceStatic.Location = new System.Drawing.Point(35, 292);
            this.labelNoInSequenceStatic.Name = "labelNoInSequenceStatic";
            this.labelNoInSequenceStatic.Size = new System.Drawing.Size(156, 13);
            this.labelNoInSequenceStatic.TabIndex = 3;
            this.labelNoInSequenceStatic.Text = "3. Find if number is in sequence";
            // 
            // textBoxNTerm
            // 
            this.textBoxNTerm.Location = new System.Drawing.Point(183, 143);
            this.textBoxNTerm.Name = "textBoxNTerm";
            this.textBoxNTerm.Size = new System.Drawing.Size(74, 20);
            this.textBoxNTerm.TabIndex = 4;
            // 
            // textBoxNGoldenTerm
            // 
            this.textBoxNGoldenTerm.Location = new System.Drawing.Point(183, 235);
            this.textBoxNGoldenTerm.Name = "textBoxNGoldenTerm";
            this.textBoxNGoldenTerm.Size = new System.Drawing.Size(74, 20);
            this.textBoxNGoldenTerm.TabIndex = 5;
            // 
            // textBoxNoInSequence
            // 
            this.textBoxNoInSequence.Location = new System.Drawing.Point(183, 319);
            this.textBoxNoInSequence.Name = "textBoxNoInSequence";
            this.textBoxNoInSequence.Size = new System.Drawing.Size(74, 20);
            this.textBoxNoInSequence.TabIndex = 6;
            // 
            // labelNAnswerTerm
            // 
            this.labelNAnswerTerm.AutoSize = true;
            this.labelNAnswerTerm.Location = new System.Drawing.Point(263, 146);
            this.labelNAnswerTerm.Name = "labelNAnswerTerm";
            this.labelNAnswerTerm.Size = new System.Drawing.Size(42, 13);
            this.labelNAnswerTerm.TabIndex = 7;
            this.labelNAnswerTerm.Text = "Answer";
            this.labelNAnswerTerm.Visible = false;
            // 
            // labelGoldenAnswerTerm
            // 
            this.labelGoldenAnswerTerm.AutoSize = true;
            this.labelGoldenAnswerTerm.Location = new System.Drawing.Point(263, 238);
            this.labelGoldenAnswerTerm.Name = "labelGoldenAnswerTerm";
            this.labelGoldenAnswerTerm.Size = new System.Drawing.Size(42, 13);
            this.labelGoldenAnswerTerm.TabIndex = 8;
            this.labelGoldenAnswerTerm.Text = "Answer";
            this.labelGoldenAnswerTerm.Visible = false;
            // 
            // labelIsInSequence1
            // 
            this.labelIsInSequence1.AutoSize = true;
            this.labelIsInSequence1.Location = new System.Drawing.Point(262, 322);
            this.labelIsInSequence1.Name = "labelIsInSequence1";
            this.labelIsInSequence1.Size = new System.Drawing.Size(42, 13);
            this.labelIsInSequence1.TabIndex = 9;
            this.labelIsInSequence1.Text = "Answer";
            this.labelIsInSequence1.Visible = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(183, 388);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 10;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelErrorMsg
            // 
            this.labelErrorMsg.AutoSize = true;
            this.labelErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMsg.Location = new System.Drawing.Point(263, 51);
            this.labelErrorMsg.Name = "labelErrorMsg";
            this.labelErrorMsg.Size = new System.Drawing.Size(78, 13);
            this.labelErrorMsg.TabIndex = 11;
            this.labelErrorMsg.Text = "Error Message:";
            this.labelErrorMsg.Visible = false;
            // 
            // labelNoteStatic
            // 
            this.labelNoteStatic.AutoSize = true;
            this.labelNoteStatic.ForeColor = System.Drawing.Color.Blue;
            this.labelNoteStatic.Location = new System.Drawing.Point(35, 51);
            this.labelNoteStatic.Name = "labelNoteStatic";
            this.labelNoteStatic.Size = new System.Drawing.Size(202, 13);
            this.labelNoteStatic.TabIndex = 12;
            this.labelNoteStatic.Text = "Note: You do not need to fill in every box.";
            // 
            // labelErrorMsg2
            // 
            this.labelErrorMsg2.AutoSize = true;
            this.labelErrorMsg2.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMsg2.Location = new System.Drawing.Point(263, 64);
            this.labelErrorMsg2.Name = "labelErrorMsg2";
            this.labelErrorMsg2.Size = new System.Drawing.Size(78, 13);
            this.labelErrorMsg2.TabIndex = 14;
            this.labelErrorMsg2.Text = "Error Message:";
            this.labelErrorMsg2.Visible = false;
            // 
            // labelErrorMsg3
            // 
            this.labelErrorMsg3.AutoSize = true;
            this.labelErrorMsg3.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMsg3.Location = new System.Drawing.Point(263, 77);
            this.labelErrorMsg3.Name = "labelErrorMsg3";
            this.labelErrorMsg3.Size = new System.Drawing.Size(78, 13);
            this.labelErrorMsg3.TabIndex = 15;
            this.labelErrorMsg3.Text = "Error Message:";
            this.labelErrorMsg3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(35, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Example";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(35, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "This famous sequence has the form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Term number n=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Term number n= ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sequence number X(n)=";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(26, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(512, 71);
            this.label6.TabIndex = 21;
            // 
            // labelIsInSequence2
            // 
            this.labelIsInSequence2.AutoSize = true;
            this.labelIsInSequence2.Location = new System.Drawing.Point(262, 335);
            this.labelIsInSequence2.Name = "labelIsInSequence2";
            this.labelIsInSequence2.Size = new System.Drawing.Size(51, 13);
            this.labelIsInSequence2.TabIndex = 22;
            this.labelIsInSequence2.Text = "Answer 2";
            this.labelIsInSequence2.Visible = false;
            // 
            // labelIsInSequence3
            // 
            this.labelIsInSequence3.AutoSize = true;
            this.labelIsInSequence3.Location = new System.Drawing.Point(262, 348);
            this.labelIsInSequence3.Name = "labelIsInSequence3";
            this.labelIsInSequence3.Size = new System.Drawing.Size(51, 13);
            this.labelIsInSequence3.TabIndex = 23;
            this.labelIsInSequence3.Text = "Answer 3";
            this.labelIsInSequence3.Visible = false;
            // 
            // FormFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 558);
            this.Controls.Add(this.labelIsInSequence3);
            this.Controls.Add(this.labelIsInSequence2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelErrorMsg3);
            this.Controls.Add(this.labelErrorMsg2);
            this.Controls.Add(this.labelNoteStatic);
            this.Controls.Add(this.labelErrorMsg);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelIsInSequence1);
            this.Controls.Add(this.labelGoldenAnswerTerm);
            this.Controls.Add(this.labelNAnswerTerm);
            this.Controls.Add(this.textBoxNoInSequence);
            this.Controls.Add(this.textBoxNGoldenTerm);
            this.Controls.Add(this.textBoxNTerm);
            this.Controls.Add(this.labelNoInSequenceStatic);
            this.Controls.Add(this.labelGoldenFormulaStatic);
            this.Controls.Add(this.labelNFormulaStatic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFibonacci";
            this.Text = "Fibonacci Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explanationToolStripMenuItem;
        private System.Windows.Forms.Label labelNFormulaStatic;
        private System.Windows.Forms.Label labelGoldenFormulaStatic;
        private System.Windows.Forms.Label labelNoInSequenceStatic;
        private System.Windows.Forms.TextBox textBoxNTerm;
        private System.Windows.Forms.TextBox textBoxNGoldenTerm;
        private System.Windows.Forms.TextBox textBoxNoInSequence;
        private System.Windows.Forms.Label labelNAnswerTerm;
        private System.Windows.Forms.Label labelGoldenAnswerTerm;
        private System.Windows.Forms.Label labelIsInSequence1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelErrorMsg;
        private System.Windows.Forms.Label labelNoteStatic;
        private System.Windows.Forms.Label labelErrorMsg2;
        private System.Windows.Forms.Label labelErrorMsg3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelIsInSequence2;
        private System.Windows.Forms.Label labelIsInSequence3;
    }
}

