using UnityEngine;
// 어댑터 베이스 : 클라이언트와 호환되는 작업 정의
public class AdapterBase
{
    public virtual void CompatibleRequest() { Debug.Log("호환되는 작업이 요청 되었습니다"); }
}
