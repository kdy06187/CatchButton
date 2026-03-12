namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarget_MouseEnter(object sender, EventArgs e)
        {
            // 난수 생성기
            Random rd = new Random();
            // 영역 계산
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            // 랜덤 좌표
            int randX = rd.Next(0, maxX);
            int randY = rd.Next(0, maxY);

            // 위치 이동
            btnTarget.Location = new Point(randX, randY);
            //제목 텍스트 변경
            this.Text = $"버튼 위치: ({randX}, {randY})";

        }
    }
}
