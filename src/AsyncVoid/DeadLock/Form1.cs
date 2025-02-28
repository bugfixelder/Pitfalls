namespace DeadLock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var task = DoSomethingAsync();

            // this synchronous method will block the synchronization context (UI Thread) until the task (DoSomethingAsync) complete
            // it will not allow the UI Thread do anything else, just freeze the UI.
            task.Wait();

            // this statement will be run under UI thread
            textBox1.Text = "button1_Click";
        }

        private async Task DoSomethingAsync()
        {
            // the await keyword here mean the application give the control back to the context of the caller the synchronization Context UI Thread
            await Task.Delay(1000);

            // as soon as the asynchronous task is completed, the application try to get the synchronization context back to run code from here
            // but the synchronization context UI Thread is blocked for waiting this method complete.
            // The deadlock occurs.
            textBox1.Text = "DoSomethingAsync";
        }
    }
}
