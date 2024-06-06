// 생성 구현 : 생성 베이스를 상속받아 객체의 구체적인 생성 방법 구현
public class CreatorImplementA : CreatorBase
{
    public override ProductBase FactoryMethod() { return new ProductImplementA(); }
}
