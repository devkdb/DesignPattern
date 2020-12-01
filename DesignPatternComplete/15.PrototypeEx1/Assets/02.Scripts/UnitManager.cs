using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour {

	void Start () {
        Marine marine = new Marine();
        marine.Hp = 25;
        marine.AttackPower = 5;

        // clone Marine object with Clone method
        // If you will not set the new value for any field the it will take the default value
        // from original object
        Marine marineClone = (Marine)marine.Clone();
        marineClone.Hp = 30;
        marineClone.AttackPower = 6;

        Debug.Log("Marine Details");
        Debug.LogFormat("Age: {0} / AttackPower: {1}",marine.Hp, marine.AttackPower);

        Debug.Log("Cloned Marine Details");
        Debug.LogFormat("Age: {0} / AttackPower: {1}", marineClone.Hp, marineClone.AttackPower);

        Debug.Log("Marine Details");
        Debug.LogFormat("Age: {0} / AttackPower: {1}",marine.Hp, marine.AttackPower);

        // you can perform the same operation for Firebat
    }
}
