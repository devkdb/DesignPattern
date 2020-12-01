using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 대상 클래스
// : 대상 인터페이스를 구현한 클래스
public class ConcreteSubject : MonoBehaviour
{
//    List<Observer> observers = new List<Observer>();  // 옵저버를 관리하는 List
    private int myNum;

	delegate void NotiHandler(int num);
	NotiHandler _notiHandler;

    // 관리할 옵저버를 등록
//    public void AddObserver(Observer observer)
//    {
//        observers.Add(observer);
//    }

    // 관리중인 옵저버를 삭제
//    public void RemoveObserver(Observer observer)
//    {
//        if (observers.IndexOf(observer) > 0) observers.Remove(observer);
//    }

    // 관리중인 옵저버에게 연락
    public void Notify()
    {
//		foreach (Observer o in observers)
//		{
//			o.OnNotify(myNum);
//		}
		_notiHandler(myNum);
    }

    void Start()
    {
        myNum = 10;

        Observer obj1 = new ConcreteObserver1(this.gameObject);
        Observer obj2 = new ConcreteObserver2(this.gameObject);

//        AddObserver(obj1);
//        AddObserver(obj2);

		_notiHandler += new NotiHandler(obj1.OnNotify);
		_notiHandler += new NotiHandler(obj2.OnNotify);
    }

    public int getNum()
    {
        return myNum;
    }
}
