using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitTestWinForm
{
    public partial class MainForm : Form
    {
        private static readonly PeopleRepositoryAsync Repository = new PeopleRepositoryAsync();
        private CancellationTokenSource _tokenSource;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = true;
            buttonTask.Enabled = false;
            ClearTextBox();
            textBoxMain.AppendText("Fetch data with Task. Start call. - " + Thread.CurrentThread.ManagedThreadId + Environment.NewLine);
                                 
            _tokenSource = new CancellationTokenSource();
            Task<List<string>> peopleTask = Repository.GetPeopleList(_tokenSource.Token);

            peopleTask.ContinueWith(t =>
            {
                if (t.Status == TaskStatus.Faulted)
                {
                    foreach (var exception in t.Exception.Flatten().InnerExceptions)
                        MessageBox.Show(exception.Message);
                }
                if (t.Status == TaskStatus.Canceled)
                {
                    MessageBox.Show("Operation Canceled", "Canceled");
                }
                if (t.Status == TaskStatus.RanToCompletion)
                {
                    List<string> people = peopleTask.Result;

                    textBoxMain.AppendText($"{Environment.NewLine}Person list:{Environment.NewLine}");
                    foreach (var person in people)
                    {
                        textBoxMain.AppendText($"- {person}{Environment.NewLine}");
                    } 
                    textBoxMain.AppendText("Fetch data with Task. End call. - " + Thread.CurrentThread.ManagedThreadId +
                                           Environment.NewLine);
                }
                buttonTask.Enabled = true;
                buttonCancel.Enabled = false;
            }, TaskScheduler.FromCurrentSynchronizationContext());                                                                        
        }

        private async void buttonAwait_Click(object sender, EventArgs e)
        {
            buttonAwait.Enabled = false;
            buttonCancel.Enabled = true;
            ClearTextBox();
            textBoxMain.AppendText("Fetch data with await. Start call. - " + Thread.CurrentThread.ManagedThreadId + Environment.NewLine);

            try
            {
                _tokenSource = new CancellationTokenSource();
                List<string> people = await Repository.GetPeopleList(_tokenSource.Token);
                
                textBoxMain.AppendText($"{Environment.NewLine}Person list:{Environment.NewLine}");
                foreach (var person in people)
                {
                    textBoxMain.AppendText($"- {person}{Environment.NewLine}");
                }  
                textBoxMain.AppendText("Fetch data with await. End call. - " + Thread.CurrentThread.ManagedThreadId +
                                       Environment.NewLine);
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show(ex.Message, "Canceled");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {   
                buttonAwait.Enabled = true;  
                buttonCancel.Enabled = false;
            }                              
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();       
            buttonCancel.Enabled = false;
        }

        private void buttonDeadlock_Click(object sender, EventArgs e)
        {
            Repository.DeadlockTestAsync().Wait();
        }

        private void ClearTextBox()
        {
            textBoxMain.Clear();
        }
    }
}
