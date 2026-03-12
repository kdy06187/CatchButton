namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;
        int randX = 0;
        int randY = 0;
        private void btnTarget_MouseEnter(object sender, EventArgs e)
        {
            //효과음 추가
            System.Media.SystemSounds.Asterisk.Play();

            // 난수 생성기
            Random rd = new Random();
            // 영역 계산
            int maxX = this.ClientSize.Width - btnTarget.Width;
            int maxY = this.ClientSize.Height - btnTarget.Height;

            // 랜덤 좌표
            randX = rd.Next(0, maxX);
            randY = rd.Next(0, maxY);

            // 위치 이동
            btnTarget.Location = new Point(randX, randY);

            // 점수 계산 및 제목 업데이트 => 10점 감점
            if(score >= 10) score -= 10;

            //제목 텍스트 변경
            updateTitle();
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            //효과음 추가
            System.Media.SystemSounds.Beep.Play();
            //점수 계산 및 제목 업데이트 => 100점 추가
            score += 100;
            updateTitle();
            //난이도 조절 => 사이즈 10%씩 축소
            btnTarget.Size = new Size(
                (int)(btnTarget.Size.Width * 0.9), (int)(btnTarget.Size.Height * 0.9));
            //메시지 박스
            MessageBox.Show("축하합니다~!");

        }
        // 제목 텍스트 업데이트
        private void updateTitle()
        {
            this.Text = $"버튼 위치: ({randX}, {randY}) 점수 : {score}";
        }

    }
}
