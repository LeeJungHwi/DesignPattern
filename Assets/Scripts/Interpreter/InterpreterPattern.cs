using System.Collections.Generic;
using UnityEngine;

// 인터프리터 패턴

// 0. 정의
// => 문법이나 규칙에 기반하여 언어를 해석

// 1. 구성
// => 표현 컨텍스트 : 해석 할 표현 및 언어 관리
// => 표현 베이스 : 표현의 해석 할 부분 정의
// => 표현 구현 : 표현에서 VT, VN, L 해석

// 2. 장점
// => 새로운 문법 및 규칙을 추가하기 쉬움
// => 각 표현의 처리를 독립적으로 관리

// 3. 게임
// => 게임 내부 스크립트 언어를 해석하여 게임 로직 실행
// => 사용자 입력을 해석하여 캐릭터의 행동 결정
// => 게임의 특정 부분에서 발생하는 상황을 해석하여 적절한 조치

public class InterpreterPattern : MonoBehaviour
{
    private void Start()
    {
        // 해석 할 표현
        InterpreterContext context = new InterpreterContext("S -> dingdongA, A -> dengS | deng");

        // 표현의 해석 할 부분
        List<ExpressionBase> expressionBaseList = new List<ExpressionBase>() { new ExpressionVT(), new ExpressionVN(), new ExpressionL() };

        // 표현 해석
        foreach(ExpressionBase exp in expressionBaseList) exp.Interpret(context);
    }
}
