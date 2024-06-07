using UnityEngine;

// 데이터 지역성 패턴

// 0. 정의
// => 관련 데이터를 메모리 내에서 근접하게 배치

// 1. 구성
// => 컴포넌트 리스트(엔티티) : 각 타입의 컴포넌트 데이터가 연속된 메모리 위치에 배치하도록 하며 이를 통해 캐시 히트 향상
// => 컴포넌트 : 엔티티가 관리하는 데이터

// 2. 장점
// => 성능 향상 : 관련 데이터가 메모리 내 근접하게 배치되어 캐시 히트 향상
// => 간결성 : 컴포넌트별 리스트를 사용해 간결한 코드 및 관리 용이
// => 확장성 : 컴포넌트 추가 및 수정 용이

// 3. 게임
// => 성능 최적화 : 대량의 데이터를 처리할 때 관련된 데이터를 연속된 메모리에 배치하여 캐시 히트율을 높여 성능 향상
// => 업데이트 관리 : 게임 객체의 업데이트는 각 컴포넌트에서 이루어지는데, 관련된 컴포넌트들을 동일한 메모리 영역에 유지하여 효율적으로 업데이트
public class DataLocalityPattern : MonoBehaviour
{
    // 컴포넌트 초기화 후 사용
    GameX game;

    private void Start()
    {
        game = new GameX();
        game.Start();
    }

    private void Update() { if(game != null) game.Update(); }
}
