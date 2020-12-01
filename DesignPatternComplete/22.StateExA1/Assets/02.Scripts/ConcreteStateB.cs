using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteState2 클래스
public class ConcreteStateB : State
{
    public override void Handle()
    {
        Debug.Log("ConcreteStateB");
    }
}
