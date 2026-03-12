namespace CatchButton
{
    public partial class Form1 : Form
    {
        int score = 0;
        int randX = 0;
        int randY = 0;
        int count = 0;
        Size initsize;
        public Form1()
        {
            InitializeComponent();
            initsize = btnTarget.Size;
        }
        private void initiateGame()
        {
            //버튼 활성화
            if(!btnTarget.Enabled) btnTarget.Enabled = true;
            // 버튼 크기 초기화
            btnTarget.Size = initsize;
            // 점수 및 카운트 초기화
            score = 0;
            count = 0;
            // 제목 업데이트
            updateTitle();

        }

        private void btnTarget_MouseEnter(object sender, EventArgs e)
        {
            // 점수 계산  => 10점 감점
            if (score >= 10) score -= 10;
            //놓친 카운트 증가
            count++;
            //제목 텍스트 변경
            updateTitle();
         

            // 20번 놓치면 게임 종료
            if (count >= 20)
            {
                btnTarget.Enabled = false;
                DialogResult result = MessageBox.Show("GameOver!\n다시 시작하시겠습니까?","게임 종료",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes) {
                    initiateGame();
                }
                return;
            }

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
            MessageBox.Show("축하합니다~!","성공",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        // 제목 텍스트 업데이트
        private void updateTitle()
        {
            this.Text = $"버튼 위치: ({randX}, {randY}) 점수: {score} 놓친 횟수: {count}/20";
        }

    }
}
