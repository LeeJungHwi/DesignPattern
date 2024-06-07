using System.Collections.Generic;
using UnityEngine;
// => RPG : 플레이어 컴포넌트를 관리하며 처리
public class RPG
{
    // 플레이어 속도
    private int velocity;
    public int Velocity
    {
        get { return velocity; }
        set
        {
            velocity = value;
            Debug.Log("게임 속도 : " + value);
        }
    }

    // 플레이어 렌더링
    private Sprite curSprite;
    public Sprite CurSprite
    {
        get { return curSprite; }
        set
        {
            if(curSprite == value) return;

            curSprite = value;
            Debug.Log("현재 스프라이트 : " + value);
        }
    }

    // 플레이어 위치
    public int pos = 0;

    // 컴포넌트 초기화
    private ICompInput input;
    private ICompPhysics physics;
    private ICompRender renderer;

    public List<ICompBase> compList = new List<ICompBase>();

    public void Start()
    {
        input = new CompPlayerInput();
        physics = new CompPlayerPhysics();
        renderer = new CompPlayerRender();

        compList.Add(input);
        compList.Add(physics);
        compList.Add(renderer);
    }

    // 컴포넌트 처리
    public void Update()
    {
        if(compList == null) return;
        for(int i = 0; i < compList.Count; i++) compList[i].Update(this);
    }
}
