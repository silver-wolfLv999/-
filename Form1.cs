namespace 顏色魔術
{
    public partial class Form1 : Form
    {
        static Random R = new Random();
        static Random G = new Random();
        static Random B = new Random();
        static Random Max = new Random();
        static Random C = new Random();
        Random ans = new Random();

        int r = R.Next(0, 255);
        int g = G.Next(0, 255);
        int b = B.Next(0, 255);

        int c_min = 50;
        int c_max = 90;
        int c = 0;

        int m = 0;
        int n = 2;
        int n_next;
        int Score = 0;
        int MaxB = 9;

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
                    buttons[i * n + j].Location = new Point(150 + j * 400 / n, i * 400 / n);
                    buttons[i * n + j].Click += new EventHandler(btn_Click);
                }
            }
            this.Controls.AddRange(buttons);
        }

        private void start_Click(object sender, EventArgs e)
        {
            score.Text = $"score   {Score}";
                            
            m = ans.Next(0, n * n);
            c = C.Next(c_min, c_max + 1);
            if ((b + c) > 255)
                buttons[m].BackColor = Color.FromArgb(r, g, b - c);
            else
                buttons[m].BackColor = Color.FromArgb(r, g, b + c);

            buttons[m].Click += new EventHandler(btn_TClick);
        }
        void btn_TClick(object sender, EventArgs e)
        {
            Score++;
            score.Text = $"score   {Score}";
            
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

            c = C.Next(c_min, c_max + 1);
            n_next = Max.Next(2, MaxB + 1);

            if (n != n_next)
            {
                for (int i = 0; i < n * n; i++)
                {
                    this.Controls.Remove(buttons[i]);
                }
                n = n_next;
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
                        buttons[i * n + j].Location = new Point(150 + j * 400 / n, i * 400 / n);
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

        private void set_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out MaxB))
                MaxB = int.Parse(textBox1.Text);
            else
                MaxB = 9;

            if (int.TryParse(textBox2.Text, out c_max))
                c_max = int.Parse(textBox2.Text);
            else
                c_max = 90;

            if (int.TryParse(textBox3.Text, out c_min))
                c_min = int.Parse(textBox3.Text);
            else
                c_min = 50;

            if (c_min >c_max)
            {
                int t = c_min;
                c_min = c_max;
                c_max = t;

                textBox2.Text = c_max.ToString();
                textBox3.Text = c_min.ToString();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            MaxB = 9;
            textBox1.Text = MaxB.ToString();

            c_max = 90;
            textBox2.Text = c_max.ToString();

            c_min = 50;
            textBox3.Text = c_min.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Focus();
        }
    }
}
