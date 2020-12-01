using UnityEngine;
using System.Collections;

public class MyAudioPlay : MonoBehaviour {

	public AudioClip clip;

	void OnCollisionEnter(Collision collision)
	{
		AudioManager.Instance().Play(clip);

		Destroy(this.gameObject);
	}

}
