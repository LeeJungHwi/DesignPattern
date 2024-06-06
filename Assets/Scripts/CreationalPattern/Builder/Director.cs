// 디렉터 : 최종 제품 생성 관리
public class Director
{
    public void BuildProduct(BuilderBase builder)
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}
