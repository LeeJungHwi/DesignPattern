using System.Collections.Generic;
using UnityEngine;

// 오브젝트 풀 패턴

// 0. 정의
// => 오브젝트를 미리 생성하여 풀에 저장하고 필요할 때마다 재활용

// 1. 구성
// => 풀 매니저 : 모든 풀을 관리하며, 각 풀의 생성 및 반환
// => 풀 : 각 풀 객체로 자신의 풀 내부 오브젝트를 관리하며, 필요한 경우 오브젝트를 생성 및 반환
// => 풀 오브젝트 : 풀링 할 오브젝트 프리팹에 할당
// => 풀 정보 : 각 풀에 대한 정보 저장

// 2. 장점
// => 메모리 최적화 : 미리 생성된 오브젝트를 재활용하여 메모리 할당 및 해제 오버헤드 줄임
// => 성능 향상 : 오브젝트를 재활용하여 동적으로 생성 및 제거하는 과정이 없음
// => 구현 용이 : 풀링 기능을 모듈화 하여 다양한 종류의 오브젝트를 일관된 방식으로 풀링 할 수 있음

// 3. 게임
// => 총알, 폭탄, 파티클 등 오브젝트를 풀링하여 동시에 많은 양의 오브젝트를 처리
public class ObjectPoolPattern : MonoBehaviour
{
    // 풀 이름
    public string poolName;

    // 풀링된 오브젝트 관리
    public List<PoolObject> instantList = new List<PoolObject>();

    // 풀 초기화하고 풀링
    public void Start()
    {
        PoolManager.Instance.Init();
        GetPool();
    }

    // 풀링
    public void GetPool()
    {
        if(instantList == null) return;

        Vector3 pos = new Vector3();
        pos.x = Random.Range(-5, 6);
        pos.y = 0f;
        pos.z = Random.Range(-5, 6);

        PoolObject po = PoolManager.Instance.GetObj(poolName, pos, Quaternion.identity);
        if(po) instantList.Add(po);
    }

    // 하나 반환
    public void ReturnPool()
    {
        if(instantList == null || instantList.Count <= 0) return;

        PoolManager.Instance.ReturnObj(instantList[0]);
        instantList.Remove(instantList[0]);
    }

    // 모두 반환
    public void ReturnAllPool()
    {
        if(instantList == null) return;
        
        foreach(PoolObject po in instantList) PoolManager.Instance.ReturnObj(po);
        instantList.Clear();
    }
}
