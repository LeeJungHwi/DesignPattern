using System.Collections;
using UnityEngine;

// 커맨드 패턴

// 0. 정의
// => 작업을 수행하는 객체와 작업을 요청하는 객체를 분리하여 상호작용
// => 작업 요청을 객체르 캡슐화하여 여러 요청을 처리하거나 취소 할 수 있음

// 1. 구성
// => 커맨드 베이스 : 작업을 수행하는 객체가 구현 해야 할 인터페이스 정의
// => 커맨드 구현 : 커맨드 베이스를 상속 받아 수행 할 작업 내용을 구현
// => 호출자 : 수행 할 작업 내용을 가진 커맨드 베이스의 명령을 실행하는 함수를 호출하고 명령의 히스토리를 추적
// => 수신자 : 호출자가 명령을 실행하는 함수를 호출하면 실제 작업을 수행하거나 취소하는 객체

// 2. 장점
// => 명령의 수행과 취소를 유연하게 관리하며 객체들 간 결합도를 낮추고 확장성 향상

// 3. 게임
// => 플레이어의 행동 : 이동, 공격, 아이템 사용 등 명령 객체로 캡슐화하고 명령의 수행 취소를 구현 및 추적

public class CommandPattern : MonoBehaviour
{
    private void Start()
    {
        // 초기화
        CommandReceiver receiver = new CommandReceiver();
        CommandBase command = new CommandImplement(receiver);
        CommandInvoker invoker = new CommandInvoker();

        // 명령 설정
        invoker.SetCommand(command);

        // 명령 수행
        invoker.ExecuteCommand();
        invoker.ExecuteCommand();
        invoker.ExecuteCommand(); // 명렁 추가 X

        // 명령 취소
        invoker.CancelCommand();
        invoker.CancelCommand();
        invoker.CancelCommand(); // 명령 취소 X
    }
}
