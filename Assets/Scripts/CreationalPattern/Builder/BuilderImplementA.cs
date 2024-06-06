// 빌더 구현 : 빌더 베이스를 상속받아 구현
public class BuilderImplementA : BuilderBase
{
    private Product product = new Product();
    public override void BuildPartA() { product.Add("PartA"); }

    public override void BuildPartB() { product.Add("PartB"); }

    public override Product GetResult() { return product; }
}
