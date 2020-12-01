using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon {

	// 접근점
	private IWeapon weapon;

	// 무기 교환 가능하게...
	public void setWeapon (IWeapon weapon) {
		this.weapon = weapon;
	}

	public void Shoot() {
		// Function Delegage
		weapon.Shoot();
	}
}
