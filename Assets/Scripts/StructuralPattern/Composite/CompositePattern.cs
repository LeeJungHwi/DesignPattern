using UnityEngine;

// 컴포지트 패턴

// 0. 정의
// => 객체들을 트리 구조로 구성하여 전체와 부분의 계층 구조를 나타냄
// => 클라이언트는 단일 객체와 복합 객체를 동일하게 취급 할 수 있음

// 1. 구성
// => 노드 베이스 : 트리 구조의 모든 객체들이 가져야 할 멤버 정의
// => 내부 노드 : 자식을 가질 수 있는 복합 객체로 자식들을 관리
// => 단말 노드 : 자식을 가질 수 없는 단일 객체

// 2. 장점
// => 단순화 : 클라이언트는 단일 객체와 복합 객체를 동일하게 취급하여 코드의 단순화
// => 유연성 : 새로운 타입의 객체를 추가하거나 기존 객체를 수정할 때 다른 객체에 영향을 주지 않음
// => 재귀적 : 복합 객체 자식으로 또 다른 복합 객체를 포함 할 수 있어 복잡한 트리 구조의 구현이 가능함

// 3. 게임
// => 게임 객체 관리 : 게임의 특정 씬 또는 레벨에서 객체들을 트리 구조로 관리하여 전체 객체와 부분 객체의 처리에 동일한 방식을 적용 할 수 있음
// => UI 구성 : UI 요소들을 트리 구조로 구성하여 복잡한 UI의 렌더링을 효율적으로 관리 할 수 있음
// => 엔티티 시스템 : 게임 내 캐릭터나 아이템 같은 엔티티를 계층 구조로 관리하여 엔티티 간 관계를 명확히 하고 상호작용을 동일한 방식으로 처리 할 수 있음
public class CompositePattern : MonoBehaviour
{
    private void Start()
    {
        // 단말 노드 두 개를 가지는 루트 노드
        NodeInternal rootNode = new NodeInternal("루트 노드");
        rootNode.AddChildNode(new NodeLeaf("단말 노드 RA"));
        rootNode.AddChildNode(new NodeLeaf("단말 노드 RB"));

        // 단말 노드 두 개를 가지는 내부 노드
        NodeInternal internalNode = new NodeInternal("비단말 노드");
        internalNode.AddChildNode(new NodeLeaf("단말 노드 IA"));
        internalNode.AddChildNode(new NodeLeaf("단말 노드 IB"));

        // 내부 노드를 루트 노드 자식으로 설정
        rootNode.AddChildNode(internalNode);

        // 루트 노드에 단말 노드 추가
        rootNode.AddChildNode(new NodeLeaf("단말 노드 RC"));

        // 루트 노드의 자식 노드 추가 및 자식 노드 제거 금지
        NodeLeaf leafNodeRD = new NodeLeaf("단말 노드 RD");
        NodeLeaf leafNodeDE = new NodeLeaf("단말 노드 DE");
        leafNodeRD.AddChildNode(leafNodeDE);
        leafNodeRD.RemoveChildNode(leafNodeDE);

        // 루트 노드에 단말 노드 추가 후 삭제
        rootNode.AddChildNode(leafNodeRD);
        rootNode.RemoveChildNode(leafNodeRD);

        // 루트 노드 부터 모든 자식 노드 출력
        rootNode.DisplayAllChildNode(1);
    }
}
