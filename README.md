# ARMiniTankProject

# AR 마스트 중간 발표 미니 프로젝트. (유니티)<br>
코딩 규칙 가이드 라인.<br>
*1. 명명 규칙. <br>
	*변수명을 동일한 규칙을 사용 한다.<br>
	*대소문자를 혼용 해서 사용 하다.<br>
	*명명 규칙은 .Net FrameWork C# 명명 규칙을 따른다.<br>
	*메서드(함수) 이름은 동사 또는 동사구(동사 + 명사) 를 사용한다.<br>
	<br>
2. 명명 유형.<br>
	2.1 Pascal Case<br>
		모든단어의 첫 번쨰 글자르 대문자로 쓴다.<br>
		<ex> BackColor<br>
		2.1.1 Pascal Case 표기법 사용.<br>
			클래스<br>
			열거형(enum),열거형 값.<br>
			이벤트(event)<br>
			읽기 전용 정적 필드.<br>
			인터페이스.<br>
			네임 스페이스.<br>
			속성.(Properti)<br>
		<br>
	2.2 Camel Case<br>
		맨 첫번째 글자는 소문자로 나머지 각 단어의 첫번째 글자는 대문자로.<br>
		<ex> backColor<br>
		2.2.1 Camel Case 사용.<br>
			매개변수. (parameter)<br>
			인스턴스 필드.(Instance field) -멤버 변수.<br>
	2.3 Uppercase<br>
		모든 글자르 대문자로.<br>
		<ex> BACKCOLOR , System.IO;<br>
		2.3.1 Uppercase 사용.<br>
			두글자 정도의 단어.<br>
			상수.<br>
			<br>
3. 명명 규칙.<br>
	3.1 인터페이스(Interface) 이름은 대문자 I 접두사로 시작 한다.<br>
	3.2 멤버변수.(인스턴스 필드) 는 접수가 _ (_width) 바를 사용한다. - <br>
	3.3 이벤트 처리기(deleget) 이름에는 EventHandler 접미사를 사용한다.<br>
		<ex> delegate void MouseEventHandler();<br>
	3.4 중괄호는 단독으로 사용한다.<br>
		if(...) //for // while<br>
		{<br>
		}<br>
	3.5 파일명은 가능하면 클래스 명을 사용한다.<br>
	3.6 bool 변수, 속성 함수에는 Is 또는 유사한 접두어(has,can,should) 를 붙인 이름을 사용한다.<br>
	3.7 객체 이름이 암시되어 있으면 메소드 이름에 반복 사용하지 않는다.<br>
		Line line; line.GetLength(); O //line.GetLindLength(); X<br>
		<br>
	3.8 #region , #endregion 을 활용하여 관련 있는 코드는 묶어 두어라.<br>
	3.9 UI 구성 요소는 아래 접두어를 사용한다.	<br>
		Control.		접두사.<br>
		Label			lbl<br>
		TextBox			txt<br>
		DataGrid		dtg<br>
		Button			btn<br>
		ImageButton		imb<br>
		Hyperlink		hlk<br>
		DropDownList	ddl<br>
		ListBox			lst<br>
		DataList		dtl<br>
		Repeater		rep<br>
		Checkbox		chk<br>
		CheckBoxList	cbl<br>
		RadioButton		rdo<br>
		RadioButtonList	rbl<br>
		Image			img<br>
		Panel			pnl<br>
		PlaceHolder		phd<br>
		Table			tbl<br>
		Validators		val<br>
		DataSet , DataTable ,DataRow	ds, dt, dr<br>
		<br>
	자세한 내용을 구글 드라이브에 01. win iot 43기 C# 개발 가이드 라인_.gdoc 참고.<br>
	<br>
<br>
깃허브 Commit 가이드 라인.<br>
협업규칙		<br>
1. 커밋 단위		<br>
	커밋 하나는 하나의 의도와 이미만을 가져야 합니다. <br>
	한번에 여러 파일을 수정하더라고 그 의도는 단 하나여야함, <br>
	버그 수정이던 새로운 기능 추가던 적용		<br>
2. 커밋 메시지 작성 규칙		<br>
	[category]-[simple message]		<br>
	[detailed description]		<br>
	2.1 [Category] 작성규칙 예시.		<br>
		[fix] 잘못된 부분 수정		<br>
		[add] 기능 추가		<br>
		[mod] 코드 수정		<br>
		[rm] 기능삭제		<br>
1. 가이드 라인.		<br>
	왜 커밋했는지 설명.		<br>
	버그 수정의 경우 원래 어떤 문제가 있었는지 설명		<br>
	사용중인 이슈 트래커가 있다면 해당 이슈의 하이퍼링크 포함			<br>
C,C++ 개발 표준 가이드.		<br>
출처:http://blog.daum.net/naline1213/7592240<br>
<br>
