using UnityEngine;

// 플라이웨이트 패턴

// 0. 정의
// => 유사한 객체들에 최대한 많은 데이터를 공유하여 메모리 최소화
// => 크기가 작은 대량의 객체를 효율적으로 지원

// 1. 구성
// => 플라이웨이트 팩토리 : 공유되는 플라이웨이트 객체를 생성하고 해쉬맵에 저장해두고 클라가 필요 시 플라이웨이트 객체를 반환
// => 플라이웨이트 베이스 : 플라이웨이트 객체 공통 기능 정의
// => 플라이웨이트 구현 : 공유되는 플라이웨이트 객체
// => 플라이웨이트 비공유 : 공유되지 않는 플라이웨이트 객체, 해쉬맵에 저장되지않고 필요시 독립적으로 생성

// 2. 장점
// => 메모리 최소화 : 대량의 객체를 공유하여 메모리 최소화
// => 성능 향상 : 메모리 사용량이 줄어들면 캐시 적중률이 높아져 성능 향상
// => 객체 생성 비용 감소 : 동일한 객체를 여러 곳에서 공유하여 생성 비용 낮춤

// 3. 게임
// => 타일 기반 게임 : 타일맵의 각 타일이 동일한 속성을 공유할 때 메모리 최소화
// => 파티클 시스템 : 동일한 파티클 효과를 여러 번 재사용 시 메모리 최소화
// => 텍스처 및 스프라이트 관리 : 동일한 텍스처나 스프라이트를 여러 객체에서 사용할 때 메모리 최소화
public class FlyweightPattern : MonoBehaviour
{
    private void Start()
    {
        // 외부 상태 초기화
        int externalState = 22;

        // 플라이웨이트 관리 => 공유되는 플라이웨이트 객체 관리
        FlyweightFactory factory = new FlyweightFactory();

        // 공유되는 플라이웨이트 객체 => 해쉬맵으로 관리
        FlyweightBase x = factory.GetFlyweight("X");
        x.Op(--externalState);
        FlyweightBase y = factory.GetFlyweight("Y");
        y.Op(--externalState);
        FlyweightBase z = factory.GetFlyweight("Z");
        z.Op(--externalState);

        // 공유되지 않는 플라이웨이트 객체 => 독립적으로 생성
        FlyweightImplementUnshared u = new FlyweightImplementUnshared();
        u.Op(--externalState);
    }
}
