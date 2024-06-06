using System.Collections.Generic;
using UnityEngine;

// 하위클래스 샌드박스 패턴

// 0. 정의
// => 여러 하위클래스에 객체의 독립적인 동작으로 분리하여 정의하고 부모클래스에서 하위클래스를 순회하며 동작 실행
// => 부모클래스 코드의 변경없이 유사한 동작을 수행하는 객체의 다양한 변형을 쉽게 만들 수 있음

// 1. 구성
// => 베이스 클래스 : 부모클래스로 여러 하위클래스의 공통 멤버를 정의하고 관리함
// => 서브 클래스 : 하위클래스로 각각의 독립적인 동작 구현

// 2. 장점
// => 유사한 동작을 수행하는 객체의 다양한 변형을 쉽게 만들 수 있음
// => 부모클래스의 코드를 변경하지 않고 새로운 동작을 쉽게 구현 할 수 있음

// 3. 게임
// => 캐릭터나 스킬과 같이 다양한 동작을 갖는 객체를 다룸 : 여러 종류의 스킬을 각각의 하위클래스에서 구현하고 부모클래스에서 스킬들을 관리하여 특정 조건에 따라 시전 
public class SubclassSandboxPattern : MonoBehaviour
{
    // 스킬 관리
    private List<BaseClass> skillList = new List<BaseClass>();

    private float elapsedTime = 0f;

    // 스킬 초기화
    private void Start()
    {
        skillList.Add(new SubClassC());
        skillList.Add(new SubClassB());
        skillList.Add(new SubClassA());
        elapsedTime = Time.realtimeSinceStartup;
    }

    // 스킬 시전
    private void Update()
    {
        if(Time.realtimeSinceStartup - elapsedTime > 1f)
        {
            for(int i = 0; i < skillList.Count; i++) skillList[i].Activate();
            elapsedTime = Time.realtimeSinceStartup;
        }
    }
}
