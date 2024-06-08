using UnityEngine;
// 트랜스폼 : 씬 내 트랜스폼
public class TransformEX
{
    // 원점 위치 전역 설정 => 초기화 용이
    public static TransformEX origin = new TransformEX();

    // 트랜스폼 저장
    private Vector3 pos = new Vector3(1, 1, 1);
    public Vector3 Pos
    {
        get { return pos; }
        set { pos = value; }
    }

    // 트랜스폼 결합
    public TransformEX Combine(TransformEX other)
    {
        TransformEX trans = new TransformEX();
        if(other != null) trans.Pos = Pos + other.Pos;
        return trans;
    }
}
