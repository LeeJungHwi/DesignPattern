// 추상팩토리 구현 : 추상팩토리 베이스를 상속받아 구현하여 관련된 다양한 객체 생성
public class AbstractFactoryImplement1 : AbstractFactoryBase
{
    public override ProductBaseA CreateProductA() { return new ProductImplementA1(); }
    public override ProductBaseB CreateProductB() { return new ProductImplementB1(); }
}
