// 호출자 => 명령 설정 및 호출, 수행 할 명령 참조, 명령 히스토리 기록
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private CommandBase command; // 수행 할 명령
    private Stack<CommandBase> commandHistory = new Stack<CommandBase>(); // 명령 히스토리
    private int maxCommandCnt = 2; // 최대 명령 수행 수
    public void SetCommand(CommandBase command) { this.command = command; } // 명령 설정
    public void ExecuteCommand() // 명령 수행
    {
        if(commandHistory.Count >= maxCommandCnt)
        {
            Debug.Log("최대 명령 수행 수를 넘겼습니다.");
            return;
        }

        command.Execute();
        commandHistory.Push(command);
    }
    public void CancelCommand() // 명령 취소
    {
        if(commandHistory.Count > 0)
        {
            CommandBase cancelCommand = commandHistory.Pop();
            cancelCommand.Cancel();
            return;
        }

        Debug.Log("취소 할 명령이 없습니다.");
    }
}
