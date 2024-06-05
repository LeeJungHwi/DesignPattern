using System;
using System.Collections.Generic;
using UnityEngine;
// 내부 노드 : 자식 노드들을 참조하여 관리하며, 노드 베이스를 상속받아 구현
public class NodeInternal : NodeBase
{
    // 자식 노드들 관리
    private List<NodeBase> childList = new List<NodeBase>();

    public NodeInternal(string name) : base(name) {}

    public override void AddChildNode(NodeBase node) { childList.Add(node); }
    public override void RemoveChildNode(NodeBase node) { childList.Remove(node); }
    public override void DisplayAllChildNode(int depth)
    {
        Debug.Log(new String('-', depth) + name);

        foreach(NodeBase child in childList) child.DisplayAllChildNode(depth + 2);
    }
}
