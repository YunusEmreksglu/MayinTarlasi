namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        public void cl(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int n = 0;

            if (!(Math.Pow(t, 2) <= button.TabIndex + 1) && panel1.Controls[button.TabIndex + 1].Tag == "x")
            {
                n = n + 1;
            }
            if (!(Math.Pow(t, 2) <= button.TabIndex + (t - 1)) && panel1.Controls[button.TabIndex + (t - 1)].Tag == "x")
            {
                n = n + 1;
            }
            if (!(0 >= button.TabIndex - 1) && panel1.Controls[button.TabIndex - 1].Tag == "x")
            {
                n = n + 1;
            }
            if (!(0 >= button.TabIndex - (t - 1)) && panel1.Controls[button.TabIndex - (t - 1)].Tag == "x")
            {
                n = n + 1;
            }
            if (!(Math.Pow(t, 2) <= button.TabIndex + t) && panel1.Controls[button.TabIndex + t].Tag == "x")
            {
                n = n + 1;
            }
            if (!(Math.Pow(t, 2) <= button.TabIndex + (t + 1)) && panel1.Controls[button.TabIndex + (t + 1)].Tag == "x")
            {
                n = n + 1;
            }
            if (!(0 >= button.TabIndex - t) && panel1.Controls[button.TabIndex - t].Tag == "x")
            {
                n = n + 1;
            }
            if (!(0 >= button.TabIndex - (t + 1)) && panel1.Controls[button.TabIndex - (t + 1)].Tag == "x")
            {
                n = n + 1;
            }

            if (button.Tag == "x")
            {
                this.Close();
            }
            else
            {
                button.Text = n.ToString();
            }
        }

        int t = 0;


        public void buttonL(string c, int left, int top)
        {
            Button button = new Button();
            button.Size = new Size(30, 30);
            button.Location = new Point(5 + left, 5 + top);
            button.Tag = c;

            button.TabIndex = Convert.ToInt32((top / 30) + "" + (left / 30));

            button.Click += cl;

            panel1.Controls.Add(button);
        }

        public List<int> bv(int s)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < s; i++)
            {
                int nh = new Random().Next(0, 100);
                if (!(list.Contains(nh))) list.Add(nh);
                else i = i - 1;
            }

            return list;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Math.Pow(Convert.ToInt32(richTextBox1.Text),2); i = i + 1)
            {
                t= Convert.ToInt32(richTextBox1.Text);
                buttonL(bv(Convert.ToInt32(Math.Pow(Convert.ToInt32(richTextBox1.Text), 2)*0.3)).Contains(i) ? "x" : "o", 30 * (i % Convert.ToInt32(richTextBox1.Text)), 30 * (i / Convert.ToInt32(richTextBox1.Text)));
            }
        }
    }
}
