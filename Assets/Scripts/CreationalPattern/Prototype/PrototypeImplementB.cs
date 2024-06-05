// 프로토타입 구현 : 프로토타입 베이스를 상속받아 구현
public class PrototypeImplementB : PrototypeBase
{
    public PrototypeImplementB(string id) : base(id) {}

    public override PrototypeBase Clone() { return (PrototypeBase)this.MemberwiseClone(); }
}
