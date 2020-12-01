using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightUse : MonoBehaviour {

	void Start () {
        Marine p1 = UnitFactory.getPerson("홍길동");
        Marine p2 = UnitFactory.getPerson("전우치");
        Marine p3 = UnitFactory.getPerson("홍길동");

        Debug.Log(p1 == p2);
        Debug.Log(p1 == p3);

        Debug.Log("name : " + p1.getName());
    }

}
