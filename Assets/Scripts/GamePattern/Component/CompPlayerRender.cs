using UnityEngine;
// 플레이어 컴포넌트 : 렌더링 처리
public class CompPlayerRender : ICompRender
{
    private Sprite stand, walkLeft, walkRight;

    public void Update(RPG rpg)
    {
        if(rpg == null) return;

        if(rpg.Velocity < 0) rpg.CurSprite = walkLeft;
        else if(rpg.Velocity > 0) rpg.CurSprite = walkRight;
        else rpg.CurSprite = stand;
    }
}
