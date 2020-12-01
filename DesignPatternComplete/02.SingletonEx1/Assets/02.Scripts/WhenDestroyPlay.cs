using UnityEngine;
using System.Collections;

public class WhenDestroyPlay : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		GetComponent<AudioSource>().Play();

		Destroy(this.gameObject);
	}

}
