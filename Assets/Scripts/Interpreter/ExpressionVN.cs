using UnityEngine;

// 논터미널 기호 해석
public class ExpressionVN : ExpressionBase
{
    public override void Interpret(InterpreterContext context) { Debug.Log(context.Data + " 에서 VN = {S, A}"); }
}
