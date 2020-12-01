using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 대상
public class ConcreteSubject : MonoBehaviour {

	public GameObject sphere;
	public GameObject box1;
	public GameObject box2;
	public GameObject box3;

	List<Observer> observers = new List<Observer>();  // 옵저버를 관리하는 List
	float time;

	void Start()
	{
		Observer obj1 = box1.GetComponent<ConcreteObserver>();
		Observer obj2 = box2.GetComponent<ConcreteObserver>();
		Observer obj3 = box3.GetComponent<ConcreteObserver>();

		observers.Add (obj1);
		observers.Add (obj2);
		observers.Add (obj3);

		time = 2.0f;
	}

	public void MovePosition ()
	{
		// 업적 달성
		sphere.transform.position = new Vector3 (2, 0.5f, -3);

		foreach (Observer o in observers)
		{
			o.OnNotify (time);
			//o.SendMessage("OnNotify", time, SendMessageOptions.DontRequireReceiver);
		}

		StartCoroutine(ResetPosition(time));
	}

	IEnumerator ResetPosition (float time)
	{
		yield return new WaitForSeconds(time);
		sphere.transform.position = new Vector3 (0, 0.5f, -3);
	}
}
