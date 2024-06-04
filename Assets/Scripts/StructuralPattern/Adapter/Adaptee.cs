using UnityEngine;
// 어댑티 : 클라이언트와 호환되지 않은 별개의 작업을 정의하며, 어댑터를 통해 클라이언트와 호환되도록 연결됨
public class Adaptee : MonoBehaviour
{
    public void IncompatibleRequest() { Debug.Log("호환되지 않는 작업인데 호환 되도록 변환해서 호출 하고싶어"); }
}
