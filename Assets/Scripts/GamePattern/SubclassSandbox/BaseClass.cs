using UnityEngine;
// 베이스 클래스 : 부모클래스로 여러 하위클래스의 공통 멤버를 정의하고 관리함
public abstract class BaseClass
{
    public abstract void Activate();

    protected void Move(float speed) { Debug.Log(speed + " 이동"); }
    protected void PlaySFX(string sound) { Debug.Log(sound + "사운드"); }
    protected void PlayFX(string particle) { Debug.Log(particle + "이펙트"); }
}
