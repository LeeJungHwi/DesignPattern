using UnityEngine;
// 몬스터 : 몬스터 타입의 속성을 기반으로 실제 생성되는 몬스터
public class Monster : MonoBehaviour
{
    private int hp;
    private MonsterType type;
    private string atk;

    public Monster(MonsterType type)
    {
        hp = type.GetHP();
        this.type = type;
        atk = type.GetATK();
    }

    public string GetAtk() { return atk; }
    public void ShowAtk() { Debug.Log(atk); } 
}
