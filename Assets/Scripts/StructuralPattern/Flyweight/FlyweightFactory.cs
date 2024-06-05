using System.Collections;

// 플라이웨이트 팩토리 : 공유되는 플라이웨이트 객체를 생성하고 해쉬맵에 저장해두고 클라가 필요 시 플라이웨이트 객체를 반환
public class FlyweightFactory
{
    private Hashtable flyweightMap = new Hashtable();

    public FlyweightFactory()
    {
        flyweightMap.Add("X", new FlyweightImplement());
        flyweightMap.Add("Y", new FlyweightImplement());
        flyweightMap.Add("Z", new FlyweightImplement());
    }

    public FlyweightBase GetFlyweight(string key) { return (FlyweightBase)flyweightMap[key]; }
}
