using UnityEngine;

// 전략 패턴

// 0. 정의
// => 각 알고리즘을 정의하고 캡슐화하여 상호 교환 할 수 있도록 함
// => 클라이언트 코드의 변경없이 전략을 변경하여 다양한 알고리즘을 통한 다양한 동작을 수행 할 수 있음

// 1. 구성
// => 전략 컨텍스트 : 전략을 참조하며, 수행 할 전략 알고리즘을 설정하고 실행
// => 전략 베이스 : 모드 추상 함수
// => 전략 구현 : 전략 베이스를 상속받아 각 모드 알고리즘 구현

// 2. 장점
// => 유연성 : 각 알고리즘을 독립적으로 변경 할 수 있음
// => 재사용성 : 다양한 알고리즘의 추가 및 재사용이 쉬움
// => 확장성 : 새로운 알고리즘을 추가 할 때 기존 코드를 변경 할 필요 없음

// 3. 게임
// => 플레이어 이동 방식 : 플레이어 캐릭터의 이동방식을 전략 패턴으로 구현하여 걷기, 뛰기, 점프 모드를 다양한 상황에 따라 변경 할 수 있음
public class StrategyPattern : MonoBehaviour
{
    // 현재 수행 할 전략 알고리즘
    private StrategyContext context;

    // 걷기 모드로 초기화
    private void Start() { context = new StrategyContext(new StrategyImplementA()); }

    private void Update()
    {
        // 1 : 걷기 모드 2 : 뛰기 모드 3 : 점프 모드
        if(Input.GetKeyDown(KeyCode.Alpha1)) context.SetMode(new StrategyImplementA());
        else if(Input.GetKeyDown(KeyCode.Alpha2)) context.SetMode(new StrategyImplementB());
        else if(Input.GetKeyDown(KeyCode.Alpha3)) context.SetMode(new StrategyImplementC());

        // 현재 모드로 이동
        context.ExcuteMode(transform);
    }
}
