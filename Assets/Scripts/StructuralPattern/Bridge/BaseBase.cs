using UnityEngine;
// 기능 베이스 : 구현을 참조하여 기능과 구현의 브릿지 역할을 수행
public class BaseBase : MonoBehaviour
{
    protected ImplementBase implement;
    public ImplementBase Implement { set { implement = value; } }

    public virtual void Op() { implement.Op(); }
    public virtual void AdditionalOp() { implement.AdditionalOp(); }
}
