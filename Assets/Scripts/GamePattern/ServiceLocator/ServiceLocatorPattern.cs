using UnityEngine;

// 서비스 로케이터 패턴

// 0. 정의
// => 전역 접근을 통해 다양한 서비스를 검색하고 사용

// 1. 구성
// => 서비스 로케이터 : 서비스 등록 및 검색
// => 사운드 인터페이스 : 사운드 서비스를 위한 인터페이스 정의
// => 사운드 플레이어 : 실제로 사운드를 재생
// => 사운드 널 : 사운드 서비스가 없을 때의 동작 정의
// => 사운드 로그 : 데코레이터 패턴을 적용하여 사운드 재생에 대한 로그를 남김

// 2. 장점
// => 유연성 : 서비스 구현 코드를 쉽게 변경 할 수 있음
// => 재사용성 : 다양한 서비스를 전역적으로 관리
// => 확장성 : 새로운 서비스 확장에 용이
// => 디커플링 : 의존성을 낮춰 객체 간 결합도 낮춤

// 3. 게임
// => 사운드, 입력처리, 네트워크 관리 등 여러 시스템을 관리

public class ServiceLocatorPattern : MonoBehaviour
{
    // 사운드 서비스 등록
    private void Start()
    {
        SoundPlayer sound = new SoundPlayer();
        ServiceLocator.RegisterService(sound);
    }

    private void Update()
    {
        // 사운드 재생
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            var sound = ServiceLocator.GetSoundService();

            if(sound != null) sound.PlaySound(1);
        }

        // 사운드 스탑
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            var sound = ServiceLocator.GetSoundService();

            if(sound != null) sound.StopSound(1);
        }

        // 모든 사운드 스탑
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            var sound = ServiceLocator.GetSoundService();

            if(sound != null) sound.StopAllSounds();
        }

        // 로그 기능이 추가된 사운드 서비스 등록
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            ServiceLocator.EnableSoundLogging();
        }
    }
}
