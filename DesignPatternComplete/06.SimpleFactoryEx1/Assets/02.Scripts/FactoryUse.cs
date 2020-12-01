using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryUse : MonoBehaviour {

	void Start () {

		Unit unit1 = UnitFactory.createUnit(UnitType.Marine);
        Unit unit2 = UnitFactory.createUnit(UnitType.Firebat);
        Unit unit3 = UnitFactory.createUnit(UnitType.Medic);

        unit1.move();
        unit2.move();
        unit3.move();
    }
}
