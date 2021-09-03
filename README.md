# [C#]Winform을 사용한 Hex convert, IMG convert Tool

1. Hex value input 
   → Delimeter(default ':')로 구분된 hex값의 배열을 checksum 해줍니다.
   → 우측상단 : Delimeter를 제거하고 보여줍니다.
   → 우측하단 : Ascii값으로 변환하여 보여줍니다.

2. ASCII value input 
   → String값의 배열을 Space로 구분하여 delimeter로 구분된 ASCII값(hex)으로 컨버팅해줍니다.

3. KSC5601 value input
   → 한글 데이터의 배열을 1 | 2 byte (radio 버튼 선택에 따라) ksc5601 포맷으로 변경하여 컨버팅해줍니다.

4. Drop box 안의 해당하는 프로토콜 표시 기능

5. code Table test 버튼
   → Radio 버튼 하단 drop box 선택 후 클릭 시 해당하는 ksc5601 앞자리에 맞춘 포맷 전부 선택 가능

6. Notify 버튼
   → ksc5601 우측 text box의 값을 체크섬까지 한번에 하여 클립보드로 복사

7. png2bmp tab
   → 240 x 120 이하 사이즈 png 파일을 rgb565 bmp hex source convert

   

대상 프레임워크 .NET Framework 4.6.1