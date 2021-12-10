# ProgrammingLanguage

Prof. Kim Myeong Ho's ProgrammingLanguage Class Subject Repo

과제 3번 실행방법
이미 디렉토리에 아래 과정들을 거쳐 DLL파일들이 만들어져 있다

- 실제 실행의 경우 아래 상관없이 Root디렉토리(/calculator)에서
- Dotnet을 설치하고(Dotnet 6.0 환경에서 작성함)
- mono ExtCalculator.exe 를 실행하면 된다

========기본 계산기 실행 방법=======

1. /calculator/Calculator 폴더로 진입하고 다음 명령어를 실행한다
2. csc /t:library /out:Number.dll Number.cs
3. csc /reference:Number.dll /t:library /out:Float.dll Float.cs
4. Calculator.cs 파일에서 Main부분 주석을 해제한다
5. mcs Calculator.cs /reference:Float.dll /reference:Number.dll
6. mono Calculator.exe

========확장 계산기 실행 방법=======

1. Calculator.cs 파일에서 Main부분 주석을 활성화 한다
2. csc /reference:Number.dll /reference:Float.dll /t:library /out:Calculator.dll Calculator.cs
3. /calculator 디렉토리로 이동한다
4. csc /reference:Number.dll /reference:Float.dll /t:library /out:Rational.dll Rational.cs
5. csc /reference:Number.dll /reference:Float.dll /reference:Rational.dll /t:library /out:Complex.dll Complex.cs
6. mcs ExtCalculator.cs /reference:Number.dll /reference:Float.dll /reference:Rational.dll /reference:Complex.dll /reference:Calculator.dll
7. mono ExtCalculator.exe

하지만 과제 3번의 경우 점수는 그럭저럭 받았지만 Anti-Pattern을 사용해서 객체지향 계산기를 구현했음
추후 개선 필요(쓸데없이 너무 많은 코드를 작성하고 있다)
