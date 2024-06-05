using UnityEngine;

// 프록시 패턴

// 0. 정의
// => 실제 주체에 대한 접근 인터페이스를 대리자인 프록시가 수행

// 1. 구성
// => 주체 베이스 : 실제 주체와 프록시의 공통 기능 정의
// => 실제 주체 : 실제 작업을 수행하는 주체
// => 프록시 : 실제 주체를 참조하며, 필요 시 클라이언트와 실제 주체를 연결하는 대리자 역할 수행

// 2. 장점
// => 보안 향상 : 클라가 직접 실제 주체에 접근하지 않고 프록시를 통해 접근함
// => 리소스 관리 : 실제 주체에 대한 접근을 제어하여 리소스 사용량 최적화
// => 지연된 로딩 : 실제 주체가 필요한 시점만 생성 및 초기화 되므로 지연된 로딩 구현이 가능함

// 3. 게임
// => 리소스 로딩 : 프록시를 사용해 플레이어가 특정 리소스에 접근할 때만 해당 리소스를 로드 할 수 있음
// => 네트워크 통신 : 게임에서 서버와의 통신이 필요한 경우 프록시를 사용해 네트워크 요청을 캐싱하거나 필요한 경우에만 서버와 통신이 가능함
// => 복잡한 객체 생성 : 대규모 복잡한 객체를 사용해야 할 때 프록시를 사용해 필요한 객체를 지연 생성 할 수 있음
public class ProxyPattern : MonoBehaviour
{
    private void Start()
    {
        Proxy proxy = new Proxy();
        proxy.Request();
    }
}
