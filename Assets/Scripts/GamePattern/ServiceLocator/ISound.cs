// 사운드 인터페이스 : 사운드 서비스를 위한 인터페이스 정의
public interface ISound
{
    void PlaySound(int soundID);
    void StopSound(int soundID);
    void StopAllSounds();
}
