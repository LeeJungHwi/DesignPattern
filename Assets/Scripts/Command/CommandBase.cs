// 커맨드 베이스 => 실제 커맨드에 상속, 커맨드 캡슐화, 수신자 참조
public abstract class CommandBase
{
    protected CommandReceiver receiver;
    protected CommandBase(CommandReceiver receiver) { this.receiver = receiver; }
    public abstract void Execute();
    public abstract void Cancel();
}
