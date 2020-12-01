using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour 
{
    int nMyPoint = 0;

	static AudioManager _instance = null;
	public static AudioManager Instance()
	{
		return _instance;
	}
	
	void Start () 
	{
		if (_instance == null)
			_instance = this;
	}
	
	public void Play(AudioClip clip)
	{
		GetComponent<AudioSource>().PlayOneShot(clip);
    }

    public int GetPoint()
    {
        nMyPoint = nMyPoint + 1;
        return nMyPoint;
    }
}
