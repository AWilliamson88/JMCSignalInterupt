
namespace JMCSignalInterupt
{
    partial class JMCSignalInteruptForm
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
            this.StartAsyncBtnOne = new System.Windows.Forms.Button();
            this.StartAsyncBtnTwo = new System.Windows.Forms.Button();
            this.StartAsyncBtnThree = new System.Windows.Forms.Button();
            this.CancelAsyncBtnOne = new System.Windows.Forms.Button();
            this.CancelAsyncBtnTwo = new System.Windows.Forms.Button();
            this.CancelAsyncBtnThree = new System.Windows.Forms.Button();
            this.ProgressBarOne = new System.Windows.Forms.ProgressBar();
            this.ProgressBarTwo = new System.Windows.Forms.ProgressBar();
            this.ProgressBarThree = new System.Windows.Forms.ProgressBar();
            this.BGWorkerOne = new System.ComponentModel.BackgroundWorker();
            this.BGWorkerTwo = new System.ComponentModel.BackgroundWorker();
            this.LblOne = new System.Windows.Forms.Label();
            this.LblTwo = new System.Windows.Forms.Label();
            this.LblThree = new System.Windows.Forms.Label();
            this.StatusLblOne = new System.Windows.Forms.Label();
            this.StatusLblTwo = new System.Windows.Forms.Label();
            this.StatusLblThree = new System.Windows.Forms.Label();
            this.BGWorkerThree = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // StartAsyncBtnOne
            // 
            this.StartAsyncBtnOne.Location = new System.Drawing.Point(35, 130);
            this.StartAsyncBtnOne.Name = "StartAsyncBtnOne";
            this.StartAsyncBtnOne.Size = new System.Drawing.Size(75, 23);
            this.StartAsyncBtnOne.TabIndex = 0;
            this.StartAsyncBtnOne.Text = "Start";
            this.StartAsyncBtnOne.UseVisualStyleBackColor = true;
            this.StartAsyncBtnOne.Click += new System.EventHandler(this.StartAsyncBtnOne_Click);
            // 
            // StartAsyncBtnTwo
            // 
            this.StartAsyncBtnTwo.Location = new System.Drawing.Point(35, 263);
            this.StartAsyncBtnTwo.Name = "StartAsyncBtnTwo";
            this.StartAsyncBtnTwo.Size = new System.Drawing.Size(75, 23);
            this.StartAsyncBtnTwo.TabIndex = 1;
            this.StartAsyncBtnTwo.Text = "Start";
            this.StartAsyncBtnTwo.UseVisualStyleBackColor = true;
            this.StartAsyncBtnTwo.Click += new System.EventHandler(this.StartAsyncBtnTwo_Click);
            // 
            // StartAsyncBtnThree
            // 
            this.StartAsyncBtnThree.Location = new System.Drawing.Point(35, 392);
            this.StartAsyncBtnThree.Name = "StartAsyncBtnThree";
            this.StartAsyncBtnThree.Size = new System.Drawing.Size(75, 23);
            this.StartAsyncBtnThree.TabIndex = 2;
            this.StartAsyncBtnThree.Text = "Start";
            this.StartAsyncBtnThree.UseVisualStyleBackColor = true;
            this.StartAsyncBtnThree.Click += new System.EventHandler(this.StartAsyncBtnThree_Click);
            // 
            // CancelAsyncBtnOne
            // 
            this.CancelAsyncBtnOne.Location = new System.Drawing.Point(155, 129);
            this.CancelAsyncBtnOne.Name = "CancelAsyncBtnOne";
            this.CancelAsyncBtnOne.Size = new System.Drawing.Size(75, 23);
            this.CancelAsyncBtnOne.TabIndex = 3;
            this.CancelAsyncBtnOne.Text = "Cancel";
            this.CancelAsyncBtnOne.UseVisualStyleBackColor = true;
            this.CancelAsyncBtnOne.Click += new System.EventHandler(this.CancelAsyncBtnOne_Click);
            // 
            // CancelAsyncBtnTwo
            // 
            this.CancelAsyncBtnTwo.Location = new System.Drawing.Point(155, 262);
            this.CancelAsyncBtnTwo.Name = "CancelAsyncBtnTwo";
            this.CancelAsyncBtnTwo.Size = new System.Drawing.Size(75, 23);
            this.CancelAsyncBtnTwo.TabIndex = 4;
            this.CancelAsyncBtnTwo.Text = "Cancel";
            this.CancelAsyncBtnTwo.UseVisualStyleBackColor = true;
            this.CancelAsyncBtnTwo.Click += new System.EventHandler(this.CancelAsyncBtnTwo_Click);
            // 
            // CancelAsyncBtnThree
            // 
            this.CancelAsyncBtnThree.Location = new System.Drawing.Point(155, 391);
            this.CancelAsyncBtnThree.Name = "CancelAsyncBtnThree";
            this.CancelAsyncBtnThree.Size = new System.Drawing.Size(75, 23);
            this.CancelAsyncBtnThree.TabIndex = 5;
            this.CancelAsyncBtnThree.Text = "Cancel";
            this.CancelAsyncBtnThree.UseVisualStyleBackColor = true;
            this.CancelAsyncBtnThree.Click += new System.EventHandler(this.CancelAsyncBtnThree_Click);
            // 
            // ProgressBarOne
            // 
            this.ProgressBarOne.Location = new System.Drawing.Point(35, 79);
            this.ProgressBarOne.Name = "ProgressBarOne";
            this.ProgressBarOne.Size = new System.Drawing.Size(195, 23);
            this.ProgressBarOne.TabIndex = 6;
            // 
            // ProgressBarTwo
            // 
            this.ProgressBarTwo.Location = new System.Drawing.Point(35, 218);
            this.ProgressBarTwo.Name = "ProgressBarTwo";
            this.ProgressBarTwo.Size = new System.Drawing.Size(195, 23);
            this.ProgressBarTwo.TabIndex = 7;
            // 
            // ProgressBarThree
            // 
            this.ProgressBarThree.Location = new System.Drawing.Point(35, 358);
            this.ProgressBarThree.Name = "ProgressBarThree";
            this.ProgressBarThree.Size = new System.Drawing.Size(195, 23);
            this.ProgressBarThree.TabIndex = 8;
            // 
            // BGWorkerOne
            // 
            this.BGWorkerOne.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorkerOne_DoWork);
            this.BGWorkerOne.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorkerOne_ProgressChanged);
            this.BGWorkerOne.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorkerOne_RunWorkerCompleted);
            // 
            // BGWorkerTwo
            // 
            this.BGWorkerTwo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorkerTwo_DoWork);
            this.BGWorkerTwo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorkerTwo_ProgressChanged);
            this.BGWorkerTwo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorkerTwo_RunWorkerCompleted);
            // 
            // LblOne
            // 
            this.LblOne.AutoSize = true;
            this.LblOne.Location = new System.Drawing.Point(32, 39);
            this.LblOne.Name = "LblOne";
            this.LblOne.Size = new System.Drawing.Size(126, 13);
            this.LblOne.TabIndex = 9;
            this.LblOne.Text = "Background Worker One";
            // 
            // LblTwo
            // 
            this.LblTwo.AutoSize = true;
            this.LblTwo.Location = new System.Drawing.Point(32, 184);
            this.LblTwo.Name = "LblTwo";
            this.LblTwo.Size = new System.Drawing.Size(127, 13);
            this.LblTwo.TabIndex = 10;
            this.LblTwo.Text = "Background Worker Two";
            // 
            // LblThree
            // 
            this.LblThree.AutoSize = true;
            this.LblThree.Location = new System.Drawing.Point(32, 323);
            this.LblThree.Name = "LblThree";
            this.LblThree.Size = new System.Drawing.Size(134, 13);
            this.LblThree.TabIndex = 11;
            this.LblThree.Text = "Background Worker Three";
            // 
            // StatusLblOne
            // 
            this.StatusLblOne.AutoSize = true;
            this.StatusLblOne.Location = new System.Drawing.Point(165, 38);
            this.StatusLblOne.Name = "StatusLblOne";
            this.StatusLblOne.Size = new System.Drawing.Size(44, 13);
            this.StatusLblOne.TabIndex = 12;
            this.StatusLblOne.Text = "(Ready)";
            // 
            // StatusLblTwo
            // 
            this.StatusLblTwo.AutoSize = true;
            this.StatusLblTwo.Location = new System.Drawing.Point(166, 183);
            this.StatusLblTwo.Name = "StatusLblTwo";
            this.StatusLblTwo.Size = new System.Drawing.Size(44, 13);
            this.StatusLblTwo.TabIndex = 13;
            this.StatusLblTwo.Text = "(Ready)";
            // 
            // StatusLblThree
            // 
            this.StatusLblThree.AutoSize = true;
            this.StatusLblThree.Location = new System.Drawing.Point(169, 322);
            this.StatusLblThree.Name = "StatusLblThree";
            this.StatusLblThree.Size = new System.Drawing.Size(44, 13);
            this.StatusLblThree.TabIndex = 14;
            this.StatusLblThree.Text = "(Ready)";
            // 
            // BGWorkerThree
            // 
            this.BGWorkerThree.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorkerThree_DoWork);
            this.BGWorkerThree.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorkerThree_ProgressChanged);
            this.BGWorkerThree.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorkerThree_RunWorkerCompleted);
            // 
            // JMCSignalInteruptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 450);
            this.Controls.Add(this.StatusLblThree);
            this.Controls.Add(this.StatusLblTwo);
            this.Controls.Add(this.StatusLblOne);
            this.Controls.Add(this.LblThree);
            this.Controls.Add(this.LblTwo);
            this.Controls.Add(this.LblOne);
            this.Controls.Add(this.ProgressBarThree);
            this.Controls.Add(this.ProgressBarTwo);
            this.Controls.Add(this.ProgressBarOne);
            this.Controls.Add(this.CancelAsyncBtnThree);
            this.Controls.Add(this.CancelAsyncBtnTwo);
            this.Controls.Add(this.CancelAsyncBtnOne);
            this.Controls.Add(this.StartAsyncBtnThree);
            this.Controls.Add(this.StartAsyncBtnTwo);
            this.Controls.Add(this.StartAsyncBtnOne);
            this.KeyPreview = true;
            this.Name = "JMCSignalInteruptForm";
            this.Text = "JMC Signal Interupt";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JMCSignalInteruptForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartAsyncBtnOne;
        private System.Windows.Forms.Button StartAsyncBtnTwo;
        private System.Windows.Forms.Button StartAsyncBtnThree;
        private System.Windows.Forms.Button CancelAsyncBtnOne;
        private System.Windows.Forms.Button CancelAsyncBtnTwo;
        private System.Windows.Forms.Button CancelAsyncBtnThree;
        private System.Windows.Forms.ProgressBar ProgressBarOne;
        private System.Windows.Forms.ProgressBar ProgressBarTwo;
        private System.Windows.Forms.ProgressBar ProgressBarThree;
        private System.ComponentModel.BackgroundWorker BGWorkerOne;
        private System.ComponentModel.BackgroundWorker BGWorkerTwo;
        private System.Windows.Forms.Label LblOne;
        private System.Windows.Forms.Label LblTwo;
        private System.Windows.Forms.Label LblThree;
        private System.Windows.Forms.Label StatusLblOne;
        private System.Windows.Forms.Label StatusLblTwo;
        private System.Windows.Forms.Label StatusLblThree;
        private System.ComponentModel.BackgroundWorker BGWorkerThree;
    }
}

