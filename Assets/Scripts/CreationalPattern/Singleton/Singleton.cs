// 싱글톤 : 생성자를 protected로 선언하여 외부에서 new 키워드를 사용한 생성을 막고 한 번만 생성되도록 리턴
public class Singleton
{
    private static Singleton instance;

    // 외부에서 new 키워드를 사용한 생성 막음
    protected Singleton() {}

    // 싱글톤 객체 반환 => 없으면 만들어서 있으면 그냥 리턴
    public static Singleton Instance()
    {
        if(instance == null) instance = new Singleton();
        return instance;
    }
}
