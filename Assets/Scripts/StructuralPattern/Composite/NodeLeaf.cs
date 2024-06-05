using System;
using UnityEngine;
// 단말 노드 : 단말이므로 자식 노드 추가 및 제거가 금지됨, 노드베이스를 상속받아 구현
public class NodeLeaf : NodeBase
{
    public NodeLeaf(string name) : base(name) {}

    public override void AddChildNode(NodeBase node) { Debug.Log("단말 노드 자식 추가 금지"); }
    public override void RemoveChildNode(NodeBase node) { Debug.Log("단말 노드 자식 없어서 삭제 금지"); }
    public override void DisplayAllChildNode(int depth) { Debug.Log(new String('-', depth) + name); }
}
