using UnityEngine;
// 클래스 구현 : 각 연산 오버라이딩 구현
public class ClassImplementB : ClassBase
{
    public override void Op1() { Debug.Log("B.Op1()"); }

    public override void Op2() { Debug.Log("B.Op2()"); }
}
