using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMCSignalInterupt
{
    public partial class JMCSignalInteruptForm : Form
    {
        public JMCSignalInteruptForm()
        {
            InitializeComponent();
            // Worker one.
            BGWorkerOne.WorkerReportsProgress = true;
            BGWorkerOne.WorkerSupportsCancellation = true;
            
            BGWorkerTwo.WorkerReportsProgress = true;
            BGWorkerTwo.WorkerSupportsCancellation = true;

            BGWorkerThree.WorkerReportsProgress = true;
            BGWorkerThree.WorkerSupportsCancellation = true;
        }

        #region Buttons

        #region B1

        /// <summary>
        /// Tell the worker to start working or pick up where he left off previously.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartAsyncBtnOne_Click(object sender, EventArgs e)
        {
            int value = 0;


            if (ProgressBarOne.Value != 100)
            {
                value = ProgressBarOne.Value;
            }

            if (BGWorkerOne.IsBusy != true)
            {
                // Start the asyncronous operation.
                BGWorkerOne.RunWorkerAsync(value);

                StatusLblOne.Text = "(Working)";
                StatusLblOne.ForeColor = Color.Blue;
            }
        }

        /// <summary>
        /// Tell the worker to stop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelAsyncBtnOne_Click(object sender, EventArgs e)
        {
            if (BGWorkerOne.WorkerSupportsCancellation == true)
            {
                // Cancel the asyncronous operation.
                BGWorkerOne.CancelAsync();
            }
        }

        #endregion

        #region B2

        /// <summary>
        /// Tell the worker to start working or pick up where he left off previously.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartAsyncBtnTwo_Click(object sender, EventArgs e)
        {
            int value = 0;
            
            if (ProgressBarTwo.Value != 100)
            {
                value = ProgressBarTwo.Value;
            }

            if (BGWorkerTwo.IsBusy != true)
            {
                // Start the asyncronous operation.
                BGWorkerTwo.RunWorkerAsync(value);

                StatusLblTwo.Text = "(Working)";
                StatusLblTwo.ForeColor = Color.Blue;
            }
            
        }

        /// <summary>
        /// Tell the worker to stop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelAsyncBtnTwo_Click(object sender, EventArgs e)
        {
            if (BGWorkerTwo.WorkerSupportsCancellation == true)
            {
                // Cancel the asyncronous operation.
                BGWorkerTwo.CancelAsync();
            }
        }
        #endregion

        #region B3

        /// <summary>
        /// Tell the worker to start working or pick up where he left off previously.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartAsyncBtnThree_Click(object sender, EventArgs e)
        {
            int value = 0;
            
            if (ProgressBarThree.Value != 100)
            {
                value = ProgressBarThree.Value;
            }

            if (BGWorkerThree.IsBusy != true)
            {
                // Start the asyncronous operation.
                BGWorkerThree.RunWorkerAsync(value);

                StatusLblThree.Text = "(Working)";
                StatusLblThree.ForeColor = Color.Blue;
            }
            
        }

        /// <summary>
        /// Tell the worker to stop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelAsyncBtnThree_Click(object sender, EventArgs e)
        {
            if (BGWorkerThree.WorkerSupportsCancellation == true)
            {
                BGWorkerThree.CancelAsync();
            }
        }
        #endregion

        #endregion

        #region WorkerOne

        /// <summary>
        /// Tell the worker what to do.
        /// <br></br>
        /// Calls the ReportProgress method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerOne_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int value = (int)e.Argument;

            for (int i = value; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                } else
                {
                    // Put the thread to sleep for a short time
                    // Otherwise the process will finish way too quickly.
                    System.Threading.Thread.Sleep(25);

                    worker.ReportProgress(i);
                }
            }
        }

        /// <summary>
        /// Defines what to do when the worker progresses in it's work.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerOne_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarOne.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// What the worker is to do when he stops. whether from cancelling, error or completion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerOne_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                StatusLblOne.Text = "(Cancelled)";
                StatusLblOne.ForeColor = Color.Red;
            }
            else if (e.Error != null)
            {
                StatusLblOne.Text = "(Error!!)";
                StatusLblOne.ForeColor = Color.Red;
            }
            else
            {
                StatusLblOne.Text = "(Done!)";
                StatusLblOne.ForeColor = Color.Green;
                ProgressBarOne.Value = 100;
            }
        }
        #endregion
        
        #region WorkerTwo

        /// <summary>
        /// Tell the worker what to do.
        /// <br></br>
        /// Calls the ReportProgress method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerTwo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int value = (int)e.Argument;

            for (int i = value; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Put the thread to sleep for a short time
                    // Otherwise the process will finish way too quickly.
                    System.Threading.Thread.Sleep(75);

                    // Report progress triggers the progress changed event.
                    worker.ReportProgress(i);
                }
            }
        }

        /// <summary>
        /// Defines what to do when the worker progresses in it's work.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerTwo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarTwo.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// What the worker is to do when he stops. whether from cancelling, error or completion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerTwo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                StatusLblTwo.Text = "(Cancelled)";
                StatusLblTwo.ForeColor = Color.Red;
            }
            else if (e.Error != null)
            {
                StatusLblTwo.Text = "(Error!!)";
                StatusLblTwo.ForeColor = Color.Red;
            }
            else
            {
                StatusLblTwo.Text = "(Done!)";
                StatusLblTwo.ForeColor = Color.Green;
                ProgressBarTwo.Value = 100;
            }
        }
        #endregion

        #region WorkerThree

        /// <summary>
        /// Tell the worker what to do.
        /// <br></br>
        /// Calls the ReportProgress method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerThree_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int value = (int)e.Argument;

            for (int i = value; i <= 100; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Put the thread to sleep for a short time
                    // Otherwise the process will finish way too quickly.
                    System.Threading.Thread.Sleep(100);

                    // Report progress triggers the progress changed event.
                    worker.ReportProgress(i);
                }
            }
        }

        /// <summary>
        /// Defines what to do when the worker progresses in it's work.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerThree_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarThree.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// What the worker is to do when he stops. whether from cancelling, error or completion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGWorkerThree_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                StatusLblThree.Text = "(Cancelled)";
                StatusLblThree.ForeColor = Color.Red;
            }
            else if (e.Error != null)
            {
                StatusLblThree.Text = "(Error!!)";
                StatusLblThree.ForeColor = Color.Red;
            }
            else
            {
                StatusLblThree.Text = "(Done!)";
                StatusLblThree.ForeColor = Color.Green;
                ProgressBarThree.Value = 100;
            }
        }




        #endregion

        /// <summary>
        /// Method to Trigger the different start and cancel buttons using different keydown combinations.
        /// </summary>
        /// <param name="sender">The form.</param>
        /// <param name="e">The Keys you have pressed down.</param>
        private void JMCSignalInteruptForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.Shift)
            {
                switch (e.KeyValue)
                {
                    case '1':
                        StartAsyncBtnOne.PerformClick();
                        break;
                    case 'A':
                        CancelAsyncBtnOne.PerformClick();
                        break;
                    case '2':
                        StartAsyncBtnTwo.PerformClick();
                        break;
                    case 'B':
                        CancelAsyncBtnTwo.PerformClick();
                        break;
                    case '3':
                        StartAsyncBtnThree.PerformClick();
                        break;
                    case 'C':
                        CancelAsyncBtnThree.PerformClick();
                        break;

                    default: 
                        break;
                }

            }

        }
    }
}
