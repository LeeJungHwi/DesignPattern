// 플레이어 컴포넌트 : 물리 처리
public class CompPlayerPhysics : ICompPhysics
{
    public void Update(RPG rpg) { rpg.pos += rpg.Velocity; }
}
