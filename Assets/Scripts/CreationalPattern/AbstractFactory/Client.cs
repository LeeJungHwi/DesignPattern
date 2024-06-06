// 클라이언트 : 셋된 팩토리의 객체들을 생성하고 참조하여 사용
public class Client
{
    // 넘어온 팩토리의 객체 참조
    private ProductBaseA a;
    private ProductBaseB b;

    // 넘어온 팩토리의 객체 생성
    public Client(AbstractFactoryBase factory)
    {
        b = factory.CreateProductB();
        a = factory.CreateProductA();
    }

    // 사용
    public void Run() { b.Interact(a); }
}
