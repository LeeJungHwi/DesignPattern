// 프록시 : 실제 주체를 참조하며, 필요 시 클라이언트와 실제 주체를 연결하는 대리자 역할 수행
public class Proxy : Subject
{
    private RealSubject realSubject;
    public override void Request()
    {
        if(realSubject == null) realSubject = new RealSubject();
        realSubject.Request();
    }
}
