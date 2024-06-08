using UnityEngine;

// 더티 플래그 패턴

// 0. 정의
// => 객체의 상태가 변경되었음을 체크하는 플래그를 사용하여 필요할 때만 해당 객체의 상태를 다시 계산

// 1. 구성
// => 더티 플래그 : 객체의 상태가 변경되었음을 체크하는 불변수
// => 상태 업데이트 함수 : 객체의 상태를 변경하고 더티 플래그 설정
// => 상태 계산 함수 : 더티 플래그가 설정된 경우 상태를 다시 계산하고 더티 플래그 해제

// 2. 장점
// => 성능 최적화 : 상태가 변경되었을 때 연산을 수행하여 불필요한 계산을 피함
// => 효율성 : 객체의 상태가 자주 변경되지 않는 경우 더티플래그를 사용하여 관리
// => 가독성 : 상태 변경과 상태 계산을 명확하게 구분함

// 3. 게임
// => 렌더링 최적화 : 씬 그래프에서 노드의 변환이나 메쉬 상태가 변경될 때만 다시 연산
// => 물리 계산 : 물리 엔진에서 객체의 상태가 변경될 때 충돌 처리
// => 애니메이션 : 객체의 상태가 변경될 때만 애니메이션 처리
public class DirtyFlagPattern : MonoBehaviour
{
    // 씬 그래프 루트노드
    GraphNode graphNode = new GraphNode(new MeshEX());

    // 부모의 월드변환
    TransformEX parentWorldTransform = new TransformEX();

    // 씬 그래프 자식 노드 초기화하고 초기 렌더링 수행
    private void Start()
    {
        for(int i = 0; i < graphNode.NumChildren; i++) graphNode.Children[i] = new GraphNode(new MeshEX());
        graphNode.Render(TransformEX.origin, true);
    }

    // 노드 변환 후 다시 렌더링 수행
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            TransformEX newLocalTransform = new TransformEX();
            newLocalTransform.Pos = new Vector3(2, 2, 2);
            graphNode.SetTransform(newLocalTransform);
            graphNode.Render(parentWorldTransform, true);
        }
    }
}
