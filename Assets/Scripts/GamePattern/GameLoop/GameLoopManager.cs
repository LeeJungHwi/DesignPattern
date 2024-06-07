using UnityEngine;
// 게임 루프 매니저 : 게임 루프의 주요 로직을 구현
public class GameLoopManager
{
    // 업데이트 주기
    public const float MS_PER_UPDATE = 0.06F;

    // 별도의 게임 루프 로직
    public void DoGameLoop()
    {
        double pre = Time.realtimeSinceStartup;
        double lag = 0.0;
        if(Time.realtimeSinceStartup == 0f) return;

        while(true)
        {
            double cur = Time.realtimeSinceStartup;
            double elapsed = cur - pre;
            pre = cur;
            lag += elapsed;
            ProcessInput();

            while(lag >= MS_PER_UPDATE)
            {
                Update();
                lag -= MS_PER_UPDATE;
            }

            Render();
        }
    }

    // 사용자 입력 처리
    private void ProcessInput() { if(Input.GetKeyDown(KeyCode.Alpha1)) Debug.Log("게임 루프 매니저 사용됨!"); }
    
    // 게임 상태 업데이트
    private void Update() {}

    // 게임 화면 렌더링
    private void Render() {}
}
