using UnityEngine;

// 게임 루프 패턴

// 0. 정의
// => 게임 상태를 계산하고 업데이트하며, 사용자 입력을 처리하고 결과를 렌더링하는 데 사용

// 1. 구성
// => 게임 루프 패턴 : 유니티의 내장된 Update()를 사용하지 않고 게임 루프 매니저를 통한 별도의 게임 루프 로직을 호출함
// => 게임 루프 매니저 : 게임 루프의 주요 로직을 구현

// 2. 장점
// => 게임 엔진의 동작을 세밀하고 제어함
// => 별도의 게임 루프 로직을 통해 게임의 성능을 최적화하고, 입력 및 렌더링 작업을 더 효율적으로 처리함

// 3. 게임
// => 사용자 입력이나 게임 객체의 업데이트 및 렌더링을 처리하는 작업 로직을 구현

public class GameLoopPattern : MonoBehaviour
{
    private GameLoopManager gameLoopManager = new GameLoopManager();

    // 게임 루프 매니저의 게임 루프 로직 사용
    private void Start() { Debug.Log("유니티에는 이미 내장된 게임 루프 모드인 Update가 있어 프로그램이 멈추는 문제가 발생하므로 여기서는 호출 X"); }
    private void Update() {}
    private void DoGameLoop()
    {
        if(gameLoopManager == null) gameLoopManager = new GameLoopManager();
        gameLoopManager.DoGameLoop();
    }
}
