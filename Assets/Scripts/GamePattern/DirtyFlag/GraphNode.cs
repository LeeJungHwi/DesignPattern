using UnityEngine;

// 그래프 노드 : 씬 그래프 노드로 더티 플래그를 사용하여 씬 렌더링 수행
public class GraphNode
{
    // 더티 플래그
    private bool isDirty;
    
    // 노드에 할당된 메쉬
    private MeshEX mesh;

    // 노드의 로컬변환
    private TransformEX local;

    // 노드의 월드변환
    private TransformEX world = new TransformEX();

    // 자식 노드 최대 수
    const int MAX_CHILDREN = 100;

    // 자식 노드 관리
    private GraphNode[] children = new GraphNode[MAX_CHILDREN];
    public GraphNode[] Children
    {
        get { return children; }
        set { children = value; }
    }

    // 자식 노드 수 관리
    private int numChildren = 88;
    public int NumChildren
    {
        get { return numChildren; }
        set { numChildren = value; }
    }

    // 생성자 => 로컬변환을 원점으로 초기화하고 더티 플래그 설정
    public GraphNode(MeshEX mesh)
    {
        this.mesh = mesh;
        local = TransformEX.origin;
        isDirty = true;
    }

    // 상태 업데이트 함수 => 로컬변환을 수행하고 더티 플래그 설정
    public void SetTransform(TransformEX local)
    {
        this.local = local;
        isDirty = true;
    }

    // 상태 계산 함수 => 더티 플래그가 설정된 경우 상태를 다시 계산하고 더티 플래그 해제
    public void Render(TransformEX parentWorld, bool dirty)
    {
        // 부모 체인에서 이 노드 위 어떤 객체가 더티 플래그가 설정되어 있으면 더티 플래그 활성화
        isDirty |= dirty;

        // 노드가 변경되지 않은 경우(dirty == false) 결합 과정을 건너뛰지만
        // 이 체인이 더티인 경우 결합 수행
        if(dirty)
        {
            Debug.Log("이 체인이 더티이므로 결합");
            world = local.Combine(parentWorld);
            isDirty = false;
        }

        // 메쉬 렌더링 수행
        if(mesh != null) RenderMesh(mesh, world);

        // 자식 노드 렌더링 수행
        for(int i = 0; i < numChildren; i++)
        {
            if(children[i] != null) children[i].Render(world, dirty);
        }
    }

    // 메쉬 렌더링 수행
    private void RenderMesh(MeshEX mesh, TransformEX world) { Debug.Log("메쉬 렌더링"); }
}
