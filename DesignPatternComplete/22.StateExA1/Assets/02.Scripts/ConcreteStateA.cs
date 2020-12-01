using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteState1 클래스
public class ConcreteStateA : State
{
    public override void Handle()
    {
        Debug.Log("ConcreteStateA");
    }
}
