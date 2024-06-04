using UnityEngine;

// 옵저버 패턴

// 0. 정의
// => 관찰 대상자의 상태 변화를 관찰하는 옵저버 유지
// => 관찰 대상자의 상태 변화가 있을 때 관찰 대상자를 관리하는 모든 옵저버에게 통지하여 일대다 관계 모델링

// 1. 구성
// => 관찰 대상자 베이스 : 자신을 관리해주는 모든 옵저버들을 관리하며 자신의 상태가 변경되면 자신을 관리해주는 모든 옵저버에게 통지
// => 관찰 대상자 구현 : 관찰 대상자의 상태를 유지
// => 옵저버 베이스 : 관찰 대상자의 상태 변화에 반응하는 업데이트 추상 함수
// => 옵저버 구현 : 실제로 관찰 대상자의 상태를 업데이트

// 2. 장점
// 관찰 대상자와 옵저버가 느슨하게 결합되어 상태 변화에 유연한 대응
// 관찰 대상자와 옵저버 간 인터페이스를 통해 상호 재사용
// 새로운 옵저버를 쉽게 추가 할 수 있고 관찰 대상자의 상태 변경 로직을 수정하지 않아도 되어 확장성

// 3. 게임
// 게임 내 UI 요소들이 플레이어의 상태 변화를 실시간으로 반영 : 체력, 점수, 아이템
// 게임 이벤트에 반응해 여러 시스템 업데이트 : 적 등장, 아이템 획득, 퀘스트 완료 시 사운드, 애니메이션, 점수 업데이트
// 멀티 게임에서 한 플레이어의 행동이 다른 플레이어에게 실시간으로 반영

public class ObserverPattern : MonoBehaviour
{
    private void Start()
    {
        // 초기화
        SubjectImplement s = new SubjectImplement();

        // 옵저버 추가
        s.Attach(new ObserverImplement(s, "X"));
        s.Attach(new ObserverImplement(s, "Y"));
        s.Attach(new ObserverImplement(s, "Z"));

        // 관찰 대상자 상태 변경 후 알림
        s.SubjectState = "ABC";
        s.Notify();
        s.SubjectState = "666";
        s.Notify();
    }
}
