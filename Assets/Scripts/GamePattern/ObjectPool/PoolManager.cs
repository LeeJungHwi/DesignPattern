using System.Collections.Generic;
using UnityEngine;

// 각 풀 객체 정보
[System.Serializable]
public class PoolInfo
{
    public string poolName;
    public GameObject poolPref;
    public int poolSize;
    public bool isFixedSize;
}

// 풀 매니저 : 모든 풀 관리
public class PoolManager : MonoBehaviour
{
    // 싱글톤
    private static PoolManager instance;
    public static PoolManager Instance
    {
        get
        {
            if(instance == null) instance = new PoolManager();
            return instance;
        }
    }

    // 생성자 private => 외부에서 생성 막음
    private PoolManager() { instance = this; }

    // 풀 이름, 풀 객체 맵핑
    private Dictionary<string, Pool> poolMap = new Dictionary<string, Pool>();
    public Dictionary<string, Pool> PoolMap
    {
        get { return poolMap; }
        set { poolMap = value; }
    }

    // 풀 관리
    public PoolInfo[] poolInfo;

    // 같은 풀 있는지 체크하고 없으면 풀 생성
    public void Init()
    {
        CheckForDuplicatePoolNames();
        CreatePools();
    }

    // 같은 풀 있는지 체크
    public void CheckForDuplicatePoolNames()
    {
        for(int i = 0; i < poolInfo.Length; i++)
        {
            string poolName = poolInfo[i].poolName;
            if(poolName.Length == 0) Debug.Log(string.Format("{0}, 풀은 이름 없음", i));

            for(int j = i + 1; j < poolInfo.Length; j++)
            {
                if(poolName.Equals(poolInfo[j].poolName)) Debug.LogError(string.Format("{0}, {1} 풀은 이름이 같으므로 다른 이름 사용해", i, j));
            }
        }
    }

    // 풀 생성
    private void CreatePools()
    {
        foreach(PoolInfo curPoolInfo in poolInfo)
        {
            Pool pool = new Pool(curPoolInfo.poolName, curPoolInfo.poolPref, curPoolInfo.poolSize, curPoolInfo.isFixedSize);
            Debug.Log(curPoolInfo.poolName + " 풀 생성 완료");
            poolMap[curPoolInfo.poolName] = pool;
        }
    }

    // 풀링
    public PoolObject GetObj(string poolName, Vector3 pos, Quaternion rot)
    {
        PoolObject result = null;

        if(poolMap.ContainsKey(poolName))
        {
            Pool pool = poolMap[poolName];
            result = pool.NextPoolObject(pos, rot);
            if(result == null) Debug.LogWarning(poolName + " 이용 가능한 오브젝트가 풀에 없어");
        }
        else Debug.LogError(poolName + "유효하지 않은 풀 이름이야");

        return result;
    }

    // 반환
    public void ReturnObj(PoolObject po)
    {
        if(po == null) Debug.Log(po.name + "반환 할 풀링 오브젝트가 아니야");
        else
        {
            if(poolMap.ContainsKey(po.PoolName))
            {
                Pool pool = poolMap[po.PoolName];
                pool.ReturnPool(po);
            }
            else Debug.LogWarning(po.PoolName + "유효하지 않은 풀 이름이야");
        }
    }
}
