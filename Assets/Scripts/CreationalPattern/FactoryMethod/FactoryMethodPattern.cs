using System.Collections.Generic;
using UnityEngine;

// 팩토리 메소드 패턴

// 0. 정의
// => 객체를 생성하는 멤버는 정의하지만, 객체의 구현은 서브클래스에서 결정하도록 함
// => 객체의 생성을 서브클래스로 분리하여 각 서브클래스에서 객체 생성 방법을 결정함

// 1. 구성
// => 생성 베이스 : 객체를 생성하기위한 멤버 정의
// => 생성 구현 : 생성 베이스를 상속받아 객체의 구체적인 생성 방법 구현
// => 제품 베이스 : 생성 할 객체의 공통 멤버 정의
// => 제품 구현 : 제품 베이스를 상속받아 실제로 생성 할 객체 정의

// 2. 장점
// => 객체 생성 방법을 서브클래스가 담당하도록 하여 객체 생성을 유연하게 할 수 있음
// => 클라는 코드에서 구체적인 객체 생성 로직을 알 필요 없이 사용하기 쉬운 인터페이스를 통해 객체를 생성 할 수 있음
// => 기존 코드를 수정할 필요 없이 새로운 객체를 추가하거나 기존 객체의 생성 방법을 변경 할 수 있음

// 3. 게임
// => 다양한 종류의 적, 아이템, 무기 생성
// => 각 적이나 아이템이 특정한 생성 방법을 필요로 할 때 이를 각 서브클래스에서 구현
public class FactoryMethodPattern : MonoBehaviour
{
    private void Start()
    {
        // 제품 생성자 생성
        List<CreatorBase> creatorList = new List<CreatorBase>();

        creatorList.Add(new CreatorImplementA());
        creatorList.Add(new CreatorImplementB());

        // 제품 생성자를 통한 제품 생성
        foreach(CreatorBase c in creatorList)
        {
            ProductBase product = c.FactoryMethod();
            Debug.Log(product.GetType().Name + "가 생성 되었습니다");
        }
    }
}
