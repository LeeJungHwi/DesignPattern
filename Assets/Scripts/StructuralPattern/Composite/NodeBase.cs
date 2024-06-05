// 노드 베이스 : 노드 이름, 자식 노드 추가, 자식 노드 제거, 자식 노드 출력 정의
public abstract class NodeBase
{
    protected string name;

    public NodeBase(string name) { this.name = name; }

    public abstract void AddChildNode(NodeBase node);
    public abstract void RemoveChildNode(NodeBase node);
    public abstract void DisplayAllChildNode(int depth);
}
