using UnityEngine;

// 빌더 패턴

// 0. 정의
// => 복잡한 객체의 생성 과정을 분리하여 캡슐화하고 절차적으로 생성해 다양한 종류의 객체를 생성

// 1. 구성
// => 디렉터 : 최종 제품 생성 관리
// => 빌더 베이스 : 부분 제품 생성 멤버 정의
// => 빌더 구현 : 빌더 베이스를 상속받아 구현
// => 제품 : 최종적으로 생성되는 복합 객체

// 2. 장점
// => 객체의 생성을 분리하여 다양한 종류의 제품을 생성 할 수 있음

// 3. 게임
// => 캐릭터, 무기, 아이템 등 복잡한 객체 생성 : 각 캐릭터의 외형, 무기, 스킬 등을 셋하여 다양한 종류의 캐릭터 생성
public class BuilderPattern : MonoBehaviour
{
    private void Start()
    {
        Director director = new Director();

        BuilderBase bA = new BuilderImplementA();
        BuilderBase bB = new BuilderImplementB();

        // A 제품 절차적 생성
        director.BuildProduct(bA);
        Product pA = bA.GetResult();
        pA.Show();

        // B 제품 절차적 생성
        director.BuildProduct(bB);
        Product pB = bB.GetResult();
        pB.Show();
    }
}
