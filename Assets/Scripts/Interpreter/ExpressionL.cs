using UnityEngine;

// 정규언어 해석
public class ExpressionL : ExpressionBase
{
    public override void Interpret(InterpreterContext context) { Debug.Log(context.Data + " 에서 L = {(dingdongdeng)^n | n >= 1} -> dingdongdeng을 무한히 가지는 언어"); }
}
