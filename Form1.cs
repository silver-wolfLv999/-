namespace 顏色魔術
{
    public partial class Form1 : Form
    {
        static Random R = new Random();
        static Random G = new Random();
        static Random B = new Random();
        Random ans = new Random();
        int r = R.Next(0, 255);
        int g = G.Next(0, 255);
        int b = B.Next(0, 255);
        int c = 50;
        int m = 0;
        int n = 2;
        Button[] buttons = new Button[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 500;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    buttons[i * n + j] = new Button();
                    buttons[i * n + j].Name = "button" + (i * n + j);
                    buttons[i * n + j].Text = "";
                    buttons[i * n + j].Size = new Size(400 / n, 400 / n);
                    buttons[i * n + j].BackColor = Color.FromArgb(r, g, b);
                    buttons[i * n + j].Location = new Point(100 + j * 400 / n, i * 400 / n);
                    buttons[i * n + j].Click += new EventHandler(btn_Click);
                }
            }
            this.Controls.AddRange(buttons);
        }

        private void start_Click(object sender, EventArgs e)
        {
            m = ans.Next(0, n * n);
            if ((b + c) > 255)
                buttons[m].BackColor = Color.FromArgb(r, g, b - c);
            else
                buttons[m].BackColor = Color.FromArgb(r, g, b + c);
            buttons[m].Click += new EventHandler(btn_TClick);
        }
        void btn_TClick(object sender, EventArgs e)
        {
            createBtn();
            m = ans.Next(0, n * n);
            if ((b + c) > 255)
                buttons[m].BackColor = Color.FromArgb(r, g, b - c);
            else
                buttons[m].BackColor = Color.FromArgb(r, g, b + c);
            buttons[m].Click += new EventHandler(btn_TClick);
        }
        void createBtn()
        {
            r = R.Next(0, 255);
            g = G.Next(0, 255);
            b = B.Next(0, 255);
            if (n < 9)
            {   
                for (int i = 0; i < n * n; i++)
                {
                    this.Controls.Remove(buttons[i]);
                }
                n++;
                buttons = new Button[n * n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        buttons[i * n + j] = new Button();
                        buttons[i * n + j].Name = "button" + (i * n + j);
                        buttons[i * n + j].Text = "";
                        buttons[i * n + j].Size = new Size(400 / n, 400 / n);
                        buttons[i * n + j].BackColor = Color.FromArgb(r, g, b);
                        buttons[i * n + j].Location = new Point(100 + j * 400 / n, i * 400 / n);
                        buttons[i * n + j].Click += new EventHandler(btn_Click);
                    }
                }
                this.Controls.AddRange(buttons);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        buttons[i * n + j].BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
        void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
