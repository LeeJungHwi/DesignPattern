// 실제 커맨드 => 수신자가 작업을 수행하도록 명령
public class CommandImplement : CommandBase
{
    public CommandImplement(CommandReceiver receiver) : base(receiver) {}
    public override void Execute() { receiver.Do(); }
    public override void Cancel() { receiver.Undo(); }
}
