using UnityEngine;

// 싱글톤 패턴

// 0. 정의
// => 객체를 하나만 생성되도록 제어하고 객체에 쉽게 접근 할 수 있도록함

// 1. 구성
// => 싱글톤 : 생성자를 protected로 선언하여 외부에서 new 키워드를 사용한 생성을 막고 한 번만 생성되도록 리턴

// 2. 장점
// => 전역 접근 : 전역에서 싱글톤 객체에 쉽게 접근 할 수 있음
// => 객체 관리 용이 : 객체가 하나만 존재하므로 메모리 관리가 용이함
// => 상태 공유 : 프로그램 전체에서 공통된 상태를 공유 할 수 있음

// 3. 게임
// => 게임 설정 : 설정값을 저장하는 싱글톤 클래스를 사용해 게임 전역에서 접근
// => 게임 매니저 : 게임의 상태, 점수, 레벨을 관리
// => 사운드 매니저 : 게임 내 BGM 및 SFX를 관리
public class SingletonPattern : MonoBehaviour
{
    private void Start()
    {
        // s1과 s2는 프로그램 내 하나만 존재하는 같은 싱글톤 객체를 가리킴
        Singleton s1 = Singleton.Instance();
        Singleton s2 = Singleton.Instance();
        if(s1 == s2) Debug.Log("같은 객체");
    }
}
