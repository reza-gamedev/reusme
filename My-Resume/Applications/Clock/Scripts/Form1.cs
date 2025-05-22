namespace Clock
{
    public partial class Form1 : Form
    {
        IClock clock;
        System.Windows.Forms.Timer timer;
        public Form1()
        {
            clock = new MyClock();
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            TimeShow();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeShow();
        }

        private void TimeShow()
        {
            HourLbl.Text = clock.Hour();
            MinuteLbl.Text = clock.Minute();
            SecondLbl.Text = clock.second();
        }
    }
}
