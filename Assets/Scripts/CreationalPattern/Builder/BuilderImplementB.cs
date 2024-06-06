// 빌더 구현 : 빌더 베이스를 상속받아 구현
public class BuilderImplementB : BuilderBase
{
    private Product product = new Product();
    public override void BuildPartA() { product.Add("PartC"); }

    public override void BuildPartB() { product.Add("PartD"); }

    public override Product GetResult() { return product; }
}
