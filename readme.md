# DcConProject
1. Clone or Download 를 누른 후 Open in Desktop 을 눌러준다. (GitHub Desktop 이 이미 있다면 3번으로)
2. GitHub Desktop 을 다운받는다.

![Alt text](https://raw.githubusercontent.com/yyw10242/dcConRaon/master/howToUse/0downloadGitDesktop.PNG

3. C:\Users\사용자명\Documents\GitHub\dcConRaon 으로 이동한다.      //기본값
4.  images 폴더에서 사용할 이미지를 추가, 제거, 이름변경한다.
5. DCConListMaker폴더의 dcConMakerSettings.txt 를 열어준다
6.  첫번째줄은 images폴더의 경로로 지정해준다.

 ![Alt text](https://raw.githubusercontent.com/yyw10242/dcConRaon/master/howToUse/1pathsettingImages.gif)

7.  두번째 줄은 이 페이지 루트 파일중 하나에서 raw 버튼을 눌러 "/파일명" 을 제외한 값을 복사하여 붙여넣는다.

 ![Alt text](https://github.com/yyw10242/dcConRaon/blob/master/howToUse/2pathsettingsUrl.gif?raw=true)
 
8. DCConList_Maker.exe 를 실행한다.
9. 상위폴더(C:\Users\사용자명\Documents\GitHub\dcConRaon)에 dccon_list.js, dccon_list.json이 생성된다.
10. BridgeBBCC 를 사용중이라면 Bridgebbcc\lib config.js 에서
    dcConsURI: "여기" 값을 C:/Users/사용자명/Documents/GitHub/dcConRaon(dccon_list.js가 생성된 곳)으로 적어준다. 
      (**구분자는\, ￦이 아니고 /다)
11. GitHub Desktop 에서 commit 후 push 해준다.


 ![Alt text](https://raw.githubusercontent.com/yyw10242/dcConRaon/master/howToUse/4commit.gif)
 ![Alt text](https://raw.githubusercontent.com/yyw10242/dcConRaon/master/howToUse/5push%20origin.gif)
 
 
12. GitHub로 돌아가 json 링크를 복사한다.

 ![Alt text](https://raw.githubusercontent.com/yyw10242/dcConRaon/master/howToUse/6getJsonLink.gif)
 
13. https://rishubil.github.io/jsassist-open-dccon/#/list?dccon_list=

    https://lastorder.xyz/ChatAssistX-Client/selector.html?dccon_list=
    위 링크 우측에 붙여넣고 브라우저로 실행해본다.->되면 디시콘 안내 리스트 링크로 사용한다.










/////////////////////////////////legacy//////////////////////////////////////

### images

디시콘 이미지의 집합

### dccon_list.js
https://github.com/krynen/BridgeBBCC참조

## dccon_list Maker 사용법
디시콘 이미지를 모아둔 폴더의 파일을 읽어 BridgeBBCC에 호환되는 dccon_list.js를 작성해주는 프로그램

1. DCConList_Maker\bin\Release 폴더의 DCConList_Maker.exe를 실행한다

2. 디시콘 이미지를 모아둔 폴더 경로를 적어준다.

3. 디시콘 이미지 폴더에 있는 dccon_list.js를 사용한다.

* 자기자신도 읽으니 가급적 기존 파일을 이동하거나 지운 후 사용해 주세요.

### references
jsassist-open-dccon
https://github.com/rishubil/jsassist-open-
BridgeBBCC
https://github.com/krynen/BridgeBBCC
