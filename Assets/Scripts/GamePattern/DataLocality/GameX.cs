using System.Collections.Generic;
using UnityEngine;

public class GameX
{
    // 컴포넌트 최대 수
    const int MAX_ENTITIES = 10000;

    // 컴포넌트 수
    int numEntities;

    // 컴포넌트 리스트(엔티티) => 같은 컴포넌트 연속된 메모리 배치
    List<AIComponent> aiList = new List<AIComponent>();
    List<PhysicsComponent> physicsList = new List<PhysicsComponent>();
    List<RendererComponent> renderList = new List<RendererComponent>();

    // 초기화
    public void Start()
    {
        numEntities = 10;
        for(int i = 0 ; i < numEntities; i++)
        {
            aiList.Add(new AIComponent());
            physicsList.Add(new PhysicsComponent());
            renderList.Add(new RendererComponent());
        }
    }

    // 컴포넌트 사용
    public void Update()
    {
        for(int i = 0; i < numEntities; i++) if(aiList != null && aiList.Count > i && aiList[i] != null) aiList[i].Update();
        for(int i = 0; i < numEntities; i++) if(physicsList != null && physicsList.Count > i && physicsList[i] != null) physicsList[i].Update();
        for(int i = 0; i < numEntities; i++) if(renderList != null && renderList.Count > i && renderList[i] != null) renderList[i].Update();
    }

    // 컴포넌트 인터페이스 => 컴포넌트 공통 인터페이스 정의
    public interface IComponent { void Update(); }

    // 각 컴포넌트 구현
    public class AIComponent : IComponent { public void Update() { Debug.Log("AIComponent.Update()"); } }
    public class PhysicsComponent : IComponent { public void Update() { Debug.Log("PhysicsComponent.Update()"); } }
    public class RendererComponent : IComponent
    {
        public void Update() { Debug.Log("RendererComponent.Update()"); }
        public void Render() { Debug.Log("RendererComponent.Render()"); }
    }
}
