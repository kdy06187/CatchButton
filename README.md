 # 버튼잡기게임(C# 코딩)
 
 ## 개요
 - C# 프로그래밍 학습
 - 핵심 기능 : ```Button, MouseEnter, MouseClick, Random, MessageBox```

       1. 버튼 컨트롤 영역 안으로 마우스가 들어가면 버튼을 폼 밖으로 벗어나지 않도록 랜덤 위치로 이동
   
       2. 버튼 이동 시 점수를 감점하고 종료 카운트 증가,버튼의 현재 좌표와 점수 및 카운트를 제목으로 표시
   
       3. 버튼 클릭 시 성공 메시지 출력과 점수 증가, 버튼 사이즈 축소, 제목 업데이트
   
       4. 게임 오버 시 메시지 출력하고 모든 버튼 비활성화 처리, 다시 시작 호출 시 모든 정보 초기화
- 화면 구성 : ```btnTarget```
<img width="1199" height="695" alt="image" src="https://github.com/user-attachments/assets/1fc821c9-c034-4150-b966-e2c78859a22b" />

## 실행 화면
- ```1단계 코드의 실행 스크린샷```

<img width="1826" height="1071" alt="image" src="https://github.com/user-attachments/assets/9c3b66c5-3922-4a55-b066-2c906fb97f89" />

- ```2단계 코드의 실행 스크린샷 : 버튼 클릭 성공 시 점수 100 증가와 축하 메시지 출력```

<img width="1176" height="685" alt="image" src="https://github.com/user-attachments/assets/aafb6ada-cbc4-43ee-877f-006c45432b9c" />

- ```3단계 코드의 실행 스크린샷 : 계속 클릭 성공 시 버튼 크기 감소```

<img width="499" height="346" alt="image" src="https://github.com/user-attachments/assets/9d1b615a-ac80-4da5-a2e6-ef43c8fd7998" />

- ```4단계 코드의 실행 스크린샷 : 20번 놓치면 게임 오버 메시지 표시 및 다시시작 버튼```
  
<img width="1395" height="875" alt="image" src="https://github.com/user-attachments/assets/33f85bc1-deab-4914-87b0-48ab2baeef85" />

## 구현 시 어려웠던 점
- 컨트롤의 좌표를 계산하는 것이 어려웠지만 winForm의 좌표의 원리를 파악해서 구현할 수 있었다.
- 시스템 사운드 설정하는 것을 몰라 코파일럿의 도움을 받았다.
- 다시시작 버튼을 form에 추가할지 메시지 버튼으로 처리할지에 대한 고민이 있었지만 적절히 처리했다.
