using UnityEngine;
// 사운드 로그 : 데코레이터 패턴을 적용하여 사운드 재생에 대한 로그를 남김
public class SoundLog : ISound
{
    // 데코레이터 패턴 => 기능 확장 및 변경을 위해 원래 객체를 랩핑 => 기존 코드 변경 없이 새로운 기능을 수행하고 원래 객체의 기능도 수행
    // 실제 사운드 서비스를 감싸는 역할 
    // wrapped => ISound를 구현한 클래스 (SoundPlayer or SoundNull)
    // 먼저 로그를 출력한 후 사운드 서비스 본래 기능 수행
    ISound wrapped;
    public SoundLog(ISound wrapped) { this.wrapped = wrapped; }

    // 로그 기능 추가
    public void PlaySound(int soundID)
    {
        Log("[LoggedSound] 사운드 재생");
        wrapped.PlaySound(soundID);
    }
    public void StopSound(int soundID)
    {
        Log("[LoggedSound] 사운드 스탑");
        wrapped.StopSound(soundID);
    }
    public void StopAllSounds()
    {
        Log("[LoggedSound] 모든 사운드 스탑");
        wrapped.StopAllSounds();
    }

    // 로그 기능
    private void Log(string message) { Debug.LogError(message); }
}
