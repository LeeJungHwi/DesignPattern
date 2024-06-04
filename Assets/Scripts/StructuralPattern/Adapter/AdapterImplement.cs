// 어댑터 구현 : 어댑터 베이스를 상속받아 클라이언트와 호환되는 작업 구현
public class AdapterImplement : AdapterBase
{
    // 호환되지 않는 작업을 가지고 있음
    private Adaptee adaptee = new Adaptee();

    // 호환되지 않는 작업을 어댑터로 연결하여 호출
    public override void CompatibleRequest() { adaptee.IncompatibleRequest(); }
}
