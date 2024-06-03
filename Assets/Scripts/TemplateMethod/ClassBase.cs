// 클래스 베이스 : 하위 클래스에서 구현 할 연산 추상 함수와 연산을 실행하는 함수
public abstract class ClassBase
{
    // 각 하위 클래스에서 구현 할 연산
    public abstract void Op1();
    public abstract void Op2();

    // 공통 부분
    public void ExecuteOp()
    {
        Op1();
        Op2();
    }
}
