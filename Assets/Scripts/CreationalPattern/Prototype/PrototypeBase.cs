// 프로토타입 베이스 : 복제할 객체의 공통 멤버 정의
public abstract class PrototypeBase
{
    private string id;
    public string Id { get { return id; } }

    public PrototypeBase(string id) { this.id = id; }

    public abstract PrototypeBase Clone();
}
