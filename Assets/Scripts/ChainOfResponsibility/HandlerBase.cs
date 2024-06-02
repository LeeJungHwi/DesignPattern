using UnityEngine;

// 핸들러 베이스 : 다음 핸들러 참조, 요청 처리 및 다음 핸들러로 요청을 넘기는 가상 함수, 핸들러 구현에 상속해 실제 요청 처리
public class HandlerBase
{
    protected HandlerBase handler; // 다음 핸들러
    public int lhs, rhs; // 요청 처리 범위
    public void SetHandler(HandlerBase handler, int lhs, int rhs) { this.handler = handler; this.lhs = lhs; this.rhs = rhs; } // 초기화
    public virtual void HandleRequest(int request) // 요청 처리 및 자신의 범위가 아닌 요청을 다음 핸들러로 넘김
    {
        if(request >= lhs && request < rhs) Debug.Log(this.GetType().Name + "이 요청 " + request + "을 처리했습니다.");
        else if(handler != null) handler.HandleRequest(request);
    }
}
