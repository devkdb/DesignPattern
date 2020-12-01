using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

	MyWeapon myweapon;

	void Start(){

		myweapon = new MyWeapon ();

		myweapon.setWeapon(new Bullet());
	}

	public void ChangeBullet() {
		myweapon.setWeapon(new Bullet());
	}

	public void ChangeMissile() {
		myweapon.setWeapon(new Missile());
	}

	public void ChangeArrow() {
		myweapon.setWeapon(new Arrow());
	}

	public void Fire() {
		myweapon.Shoot();
	}
}
