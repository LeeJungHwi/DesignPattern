using UnityEngine;

// 터미널 기호 해석
public class ExpressionVT : ExpressionBase
{
    public override void Interpret(InterpreterContext context) { Debug.Log(context.Data + " 에서 VT = (dingdong, deng)"); }
}
