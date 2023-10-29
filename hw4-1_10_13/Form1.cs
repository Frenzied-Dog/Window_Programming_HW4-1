namespace hw4_1_10_13 {
    public partial class Form1 : Form {
        int password, guess;

        void UpdateGuess() {
            guess = Btn0.ImageIndex * 1000 + Btn1.ImageIndex * 100 + Btn2.ImageIndex * 10 + Btn3.ImageIndex;
        }

        public Form1() {
            InitializeComponent();
            Random random = new();
            password = random.Next(0, 10000);
        }

        private void UnlockBtn_Click(object sender, EventArgs e) {
            if (password == guess) {
                Label0.Text = "對"; Label1.Text = "對";
                Label2.Text = "對"; Label3.Text = "對";
                MessageBox.Show("解鎖成功!", "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else {
                int tmp_p = password;
                int tmp_g = guess;
                int n = 0;

                Label3.Text = (tmp_p % 10 == tmp_g % 10) ? "對" : "錯";
                n += (tmp_p % 10 == tmp_g % 10) ? 1 : 0;
                tmp_p /= 10; tmp_g /= 10;

                Label2.Text = (tmp_p % 10 == tmp_g % 10) ? "對" : "錯";
                n += (tmp_p % 10 == tmp_g % 10) ? 1 : 0;
                tmp_p /= 10; tmp_g /= 10;

                Label1.Text = (tmp_p % 10 == tmp_g % 10) ? "對" : "錯";
                n += (tmp_p % 10 == tmp_g % 10) ? 1 : 0;
                tmp_p /= 10; tmp_g /= 10;

                Label0.Text = (tmp_p % 10 == tmp_g % 10) ? "對" : "錯";
                n += (tmp_p % 10 == tmp_g % 10) ? 1 : 0;

                DialogResult r = MessageBox.Show($"猜對{n}個位置", "失敗", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (r == DialogResult.Cancel)
                    MessageBox.Show($"答案是{password}", "", MessageBoxButtons.OK);
            }
        }

        private void Btn0_Click(object sender, EventArgs e) {
            Btn0.ImageIndex = Btn0.ImageIndex == 9 ? 0 : Btn0.ImageIndex + 1;
            UpdateGuess();
        }

        private void Btn1_Click(object sender, EventArgs e) {
            Btn1.ImageIndex = Btn1.ImageIndex == 9 ? 0 : Btn1.ImageIndex + 1;
            UpdateGuess();
        }

        private void Btn2_Click(object sender, EventArgs e) {
            Btn2.ImageIndex = Btn2.ImageIndex == 9 ? 0 : Btn2.ImageIndex + 1;
            UpdateGuess();
        }

        private void Btn3_Click(object sender, EventArgs e) {
            Btn3.ImageIndex = Btn3.ImageIndex == 9 ? 0 : Btn3.ImageIndex + 1;
            UpdateGuess();
        }
    }
}