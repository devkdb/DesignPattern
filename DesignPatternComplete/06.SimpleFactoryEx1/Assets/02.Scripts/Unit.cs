using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
	public abstract void move ();
}

public class Marine : Unit {

    public Marine()
    {
        Debug.Log("Marine 생성 !!!");
    }

    public override void move ()
	{
		Debug.Log ("Marine 이동 !!!");
	}
}

public class Firebat : Unit {

    public Firebat()
    {
        Debug.Log("Firebat 생성 !!!");
    }

    public override void move ()
	{
		Debug.Log ("Firebat 이동 !!!");
	}
}

public class Medic : Unit {

    public Medic()
    {
        Debug.Log("Medic 생성 !!!");
    }

    public override void move()
    {
        Debug.Log("Medic 이동 !!!");
    }
}
