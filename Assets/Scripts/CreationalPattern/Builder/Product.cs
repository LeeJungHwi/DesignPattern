using System.Collections.Generic;
using UnityEngine;
// 제품 : 최종적으로 생성되는 복합 객체
public class Product
{
    private List<string> partList = new List<string>();

    public void Add(string part) { partList.Add(part); }
    public void Show() { foreach(string p in partList) Debug.Log(p); }
}
