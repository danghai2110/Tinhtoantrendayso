namespace Tinhtoantrendayso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            double sbd = Convert.ToDouble(txtsbd.Text);
            double skt = Convert.ToDouble(txtskt.Text);

            double tongcs = 0, tichcs = 1, tongcsc = 0, tongcsl = 0;
            for (double i = sbd; i <= skt; i++)
            {
                tongcs += i;
                tichcs += i;
                if (i % 2 == 0)
                {
                    tongcsc += i;

                }
                else
                {
                    tongcsl += i;
                }

            }
                tongcstxt.Text = tongcs.ToString();
                tichcstxt.Text = tichcs.ToString();
                tongcsctxt.Text = tongcsc.ToString();
                tongcsltxt. Text = tongcsl.ToString();
            
        }
    }
}
