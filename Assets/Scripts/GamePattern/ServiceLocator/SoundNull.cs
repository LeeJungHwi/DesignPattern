// 사운드 널 : 사운드 서비스가 없을 때의 동작 정의
public class SoundNull : ISound
{
    // 몸체 정의 X
    public void PlaySound(int soundID) {}
    public void StopSound(int soundID) {}
    public void StopAllSounds() {}
}
