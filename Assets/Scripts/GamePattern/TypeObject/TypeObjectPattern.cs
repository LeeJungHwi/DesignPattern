using UnityEngine;
// 타입 객체 패턴

// 0. 정의
// => 객체 타입 클래스에서 객체의 속성을 결정 지음

// 1. 구성
// => 몬스터 타입 : 속성을 각 종류의 몬스터에 맞게 정의하고 생성 할 수 있게함
// => 몬스터 : 몬스터 타입의 속성을 기반으로 실제 생성되는 몬스터

// 2. 장점
// => 객체 생성에 있어 상속보다는 구성을 선호하고 유연한 객체 생성을 가능하게함

// 3. 게임
// => 적, 아이템, 스킬 등 다양한 종류의 객체를 생성할 때

public class TypeObjectPattern : MonoBehaviour
{
    private void Start()
    {
        // 몬스터 종류
        MonsterType troll = new MonsterType(null, 25, "트롤 공격");
        MonsterType trollArcher = new MonsterType(troll, 0, "궁수 트롤 공격");
        MonsterType trollWizard = new MonsterType(troll, 0, "마법사 트롤 공격");

        // 몬스터 종류에 따라 몬스터 생성
        Monster trollMonster = troll.NewMonster();
        trollMonster.ShowAtk();

        Monster trollArcherMonster = trollArcher.NewMonster();
        trollArcherMonster.ShowAtk();

        Monster trollWizardMonster = trollWizard.NewMonster();
        trollWizardMonster.ShowAtk();
    }
}
