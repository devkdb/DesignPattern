using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UnitType
{
	Marine,
	Firebat,
	Medic
}

public class UnitFactory
{
	public static Unit createUnit(UnitType type)
	{
		Unit unit = null;

		switch (type) {
            case UnitType.Marine:
                unit = new Marine();
                break;
            case UnitType.Firebat:
                unit = new Firebat();
                break;
            case UnitType.Medic:
                unit = new Medic();
                break;
        }
        return unit;
	}
}
