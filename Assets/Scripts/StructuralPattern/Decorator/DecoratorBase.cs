// 데코레이터 베이스 : 추가적인 기능 정의
public class DecoratorBase : ComponentBase
{
    private ComponentBase component;

    public void SetComponent(ComponentBase component) { this.component = component; }
    public override void Op() { if(component != null) component.Op(); }
}
