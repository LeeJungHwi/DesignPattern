using UnityEngine;
// 사운드 플레이어 : 실제로 사운드를 재생
public class SoundPlayer : ISound
{
    public void PlaySound(int soundID) { Debug.Log(soundID.ToString() + " 사운드 재생"); }
    public void StopSound(int soundID) { Debug.Log(soundID.ToString() + " 사운드 스탑"); }
    public void StopAllSounds() { Debug.Log("모든 사운드 스탑"); }
}
