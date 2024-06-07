using UnityEngine;
// 플레이어 컴포넌트 : 입력 처리
public class CompPlayerInput : ICompInput
{
    private int walkAcc = 1;

    public void Update(RPG rpg)
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)) rpg.Velocity -= walkAcc;
        if(Input.GetKeyDown(KeyCode.RightArrow)) rpg.Velocity += walkAcc;
    }
}
