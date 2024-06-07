using UnityEngine;
// 서비스 로케이터 : 서비스 등록 및 검색
public class ServiceLocator : MonoBehaviour
{
    static ISound soundService; // 사운드 서비스
    static SoundNull nullSoundService; // 사운드 서비스 없음

    // 서비스 반환
    public static ISound GetSoundService() { return soundService; }

    // 서비스 등록
    public static void RegisterService(ISound service)
    {
        if(service == null) soundService = nullSoundService;
        else soundService = service;

        Debug.Log("[ServiceLocator] : 사운드 서비스 등록 완료");
    } 

    // 로그 기능이 추가된 사운드 서비스 재등록
    public static void EnableSoundLogging()
    {
        ISound service = new SoundLog(ServiceLocator.GetSoundService());
        RegisterService(service);
    }
}
