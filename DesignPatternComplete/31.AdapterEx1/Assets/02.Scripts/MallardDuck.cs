using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 청둥오리
public class MallardDuck : Duck
{
    public void quack()
    {
        Debug.Log("오리 : 울기(꽥꽥)");
    }

    public void fly()
    {
        Debug.Log("오리 : 날기");
    }
}
