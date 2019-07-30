# DcConProject
개발자의 말이 일반인과 달라 내 이를 어엿삐 여겨 파일 이름만으로 필요한 파일을 만들어주는 프로그램을 만들었으니...

### 이런방식으로 동작하게 구성해두었습니다!
#### DCConProject 설정
* 파일이름 수정 
  - DcConListMaker.txt 수정(최초 1회)
* 프로그램 실행
  * BridgeBBCC 자동설정됨
* 깃허브 등록
* 타 디시콘 리스트 플랫폼에 Json 파일 링크 입력(최초 1회)

이후 파일을 추가, 제거, 수정 후 위 DCConProject 설정만 수정하면 되도록 만들었습니다.

### 사용법

#### 1. GitHub 가입 및 GitHub Desktop 설치
현재 오신 이 사이트에 가입을 하시고, GitHub Desktop 을 설치해주세요.
#### 2. 이 프로젝트 복제
그 후 GitHub Desktop 에서 이 레포지터리를 Clone 하시고 숨긴 파일을 볼수 있게 설정한 후 .git 폴더를 지워주세요.
그리고 원하는 폴더 이름으로 바꾸시고 C:\Users\사용자명\Documents\GitHub 이하에 바꾼 폴더이름으로 GitHub Desktop 에서 레포를 만들어주세요.
그리고 아무 내용이나 적고 아래의 commit 버튼을 눌러 Commit 하고 오른쪽의 첫번째 파란버튼을 눌러 온라인상으로 올려주세요.
#### 3. dcConMakerSettings.txt 설정
첫번째 줄에는 온라인상으로 옮겨진 페이지의 raw주소를 받아야 합니다. 깃허브에 들어가보시면 아까 만드신 레포가 올라와 있을 거에요.
그 레포의 메인페이지에 있는 아무 파일이나 누르시고 raw 버튼을 누르시고 주소창에서 마지막 /누르신파일.md 을 제외한 모든 주소를 복사하여 
첫번째 줄에 복사해주세요.
두번째 줄에는 본인 채널 주소에서 https://www.twitch.tv/(여기) <- 있는 값을 복사하여 붙여넣어주세요.
그후 저장하시면 됩니다.
#### 4. 프로그램 실행
그 후 DcConSetter.exe 파일을 누르시면 js파일과 json 파일이 생성되었다는 말이 뜹니다.
아까의 GitHub Desktop 에서 다시 Commit, Push 해주세요.
#### 5. OBS 설정
OBS 에서 브라우저를 추가하신 후 더블클릭 하시고 
위쪽 로컬 파일에 체크 후 
C:\Users\사용자명\Documents\GitHub\BridgeBBCC-master\client.html 을 추가해주세요.(BridgeBBCC-master 폴더의 client.html 을 추가해주세요.)
#### 6. 디시콘 안내 리스트 페이지 설정
GitHub 온라인 레포지터리 페이지로 가신 후 dccon_List.json 파일을 누르시고 raw 를 눌러 주소를 먼저 복사해 어딘가에 적어두세요.
https://rishubil.github.io/jsassist-open-dccon/#/list?dccon_list=
위 주소의 뒤에 아까 복사한 주소를 붙여 넣으시면 디시콘 리스트 링크 완성입니다.
Nightbot 의 커스텀 명령어 기능에 링크를 추가하거나 배너에 추가해 시청자분들께서 확인가능하게 합시다.

### 이미지파일 추가, 제거, 수정방법
images/ 아래에 모든 이미지 파일을 두시면 됩니다.
이름 형식은 다음과 같습니다.
하나의 키워드일 때
`키워드.jpg`
둘 이상의 키워드일 때
`키워드1,키워드2.png`
태그도 있을 때
`키워드1,키워드2_태그1,태그2.gif`

다시말해 
`_` 를 기준으로 왼쪽은 키워드, 오른쪽은 태그이고
`,` 를 기준으로 각각의 키워드, 태그를 구분합니다.

이렇게 이미지 파일을 추가, 제거, 수정하신 후
github deskctop 을 실행하시고
commit, push 해주시면 적용됩니다.

사실 이말도 어렵다는거 알아요.. 영상을 찍어야하나.

### Reference
https://github.com/rishubil/jsassist-open-dccon
https://github.com/krynen/BridgeBBCC
https://github.com/Lastorder-DC/ChatAssistX-Client
