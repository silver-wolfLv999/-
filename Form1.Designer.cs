namespace 顏色魔術
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            start = new Button();
            set = new Button();
            reset = new Button();
            MaxButton = new Label();
            MaxColorDifference = new Label();
            MinColorDifference = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            score = new Label();
            time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(1, 87);
            start.Name = "start";
            start.Size = new Size(94, 29);
            start.TabIndex = 0;
            start.Text = "開始";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // set
            // 
            set.Location = new Point(1, 122);
            set.Name = "set";
            set.Size = new Size(94, 29);
            set.TabIndex = 1;
            set.Text = "set";
            set.UseVisualStyleBackColor = true;
            set.Click += set_Click;
            // 
            // reset
            // 
            reset.Location = new Point(1, 157);
            reset.Name = "reset";
            reset.Size = new Size(94, 29);
            reset.TabIndex = 2;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // MaxButton
            // 
            MaxButton.AutoSize = true;
            MaxButton.Location = new Point(1, 189);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(84, 19);
            MaxButton.TabIndex = 3;
            MaxButton.Text = "MaxButton";
            // 
            // MaxColorDifference
            // 
            MaxColorDifference.AutoSize = true;
            MaxColorDifference.Location = new Point(1, 256);
            MaxColorDifference.Name = "MaxColorDifference";
            MaxColorDifference.Size = new Size(147, 19);
            MaxColorDifference.TabIndex = 4;
            MaxColorDifference.Text = "MaxColorDifference";
            // 
            // MinColorDifference
            // 
            MinColorDifference.AutoSize = true;
            MinColorDifference.Location = new Point(3, 320);
            MinColorDifference.Name = "MinColorDifference";
            MinColorDifference.Size = new Size(145, 19);
            MinColorDifference.TabIndex = 5;
            MinColorDifference.Text = "MinColorDifference";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "9";
            textBox1.Click += textBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 27);
            textBox2.TabIndex = 7;
            textBox2.Text = "90";
            textBox2.Click += textBox2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1, 342);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "50";
            textBox3.Click += textBox3_Click;
            // 
            // score
            // 
            score.AutoSize = true;
            score.Location = new Point(1, 27);
            score.Name = "score";
            score.Size = new Size(46, 19);
            score.TabIndex = 9;
            score.Text = "score";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(1, 55);
            time.Name = "time";
            time.Size = new Size(40, 19);
            time.TabIndex = 10;
            time.Text = "time";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 384);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 12;
            label2.Text = "history";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(time);
            Controls.Add(score);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(MinColorDifference);
            Controls.Add(MaxColorDifference);
            Controls.Add(MaxButton);
            Controls.Add(reset);
            Controls.Add(set);
            Controls.Add(start);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Button set;
        private Button reset;
        private Label MaxButton;
        private Label MaxColorDifference;
        private Label MinColorDifference;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label score;
        private Label time;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}
