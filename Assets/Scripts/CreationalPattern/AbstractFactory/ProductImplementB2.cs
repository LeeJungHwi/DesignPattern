using UnityEngine;
// 제품 구현 : 제품 베이스를 상속받아 구체적인 객체 구현
public class ProductImplementB2 : ProductBaseB
{
    public override void Interact(ProductBaseA a) { Debug.Log(this.GetType().Name + " 이 " + a.GetType().Name + "과 상호작용"); }
}
