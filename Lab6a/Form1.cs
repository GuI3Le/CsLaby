using System.Drawing.Text;

namespace Lab6a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime currentTime = DateTime.Now;
            currentDateLabel.Text = currentTime.ToString("dd.MM.yyyy");
            currentTimeLabel.Text = currentTime.ToLongTimeString();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            currentDateLabel.Text = currentTime.ToString("dd.MM.yyyy");
            currentTimeLabel.Text = currentTime.ToLongTimeString();
        }

    }
}
