using UnityEngine;

// 퍼사드 : 시스템들을 관리하며, 각 시스템들의 함수를 조합하는 함수 정의
public class Facade : MonoBehaviour
{
    // 시스템 초기화
    private SubSystemA a;
    private SubSystemB b;
    private SubSystemC c;
    private SubSystemD d;

    public Facade()
    {
        a = new SubSystemA();
        b = new SubSystemB();
        c = new SubSystemC();
        d = new SubSystemD();
    }

    // 함수 모음 A
    public void FuncCollectionA()
    {
        Debug.Log("함수 모음 A");
        a.FuncA();
        b.FuncB();
        d.FuncD();
    }

    // 함수 모음 B
    public void FuncCollectionB()
    {
        Debug.Log("함수 모음 B");
        b.FuncB();
        c.FuncC();
    }
}
