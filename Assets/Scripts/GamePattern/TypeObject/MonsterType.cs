using UnityEngine;
// 몬스터 타입 : 속성을 각 종류의 몬스터에 맞게 정의하고 생성 할 수 있게함
public class MonsterType : MonoBehaviour
{
    private int hp;
    private MonsterType type;
    private string atk;

    public MonsterType(MonsterType type, int hp, string atk)
    {
        this.hp = hp;
        this.atk = atk;
        this.type = null;

        if(this.type != null)
        {
            this.type = type;

            if(hp == 0) this.hp = type.GetHP();
            if(atk == null) this.atk = type.GetATK();
        }
    }

    public Monster NewMonster() { return new Monster(this); }
    public int GetHP() { return hp; }
    public string GetATK() { return atk; }
}
