using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Unit {

    string getName();
}

public class Marine : Unit
{
    string name;
    int hp;

    public Marine(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }
}
