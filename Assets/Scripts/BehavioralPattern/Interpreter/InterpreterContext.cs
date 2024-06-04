// 해석 할 표현 컨텍스트 : 해석 할 표현 저장
public class InterpreterContext
{
    private string data;
    public string Data
    {
        get { return data; }
        set { data = value; }
    }
    public InterpreterContext(string data) { this.data = data; }
}
