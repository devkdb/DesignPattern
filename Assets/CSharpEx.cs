using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract, virtual 그리고 override 키워드에 대한 설명
// https://slaner.tistory.com/160 참고.

/*
    abstract 키워드로 표시한 속성이나 메서드는 
    본문 정의할 수 없다.
    접근 한정자는 public, internal 또는 protected 중에 하나여야 한다.
    이 키워드를 사용하려면 해당 클래스도 반드시 abstract 클래스여야 함.

    abstract 키워드의 강점은 따로 있습니다.

    abstract 키워드로 표시한 속성이나 메서드는 파생 클래스에서 반드시 구현해야 한다.
    일반 클래스의 virtual 속성/메서드를 abstract 로 재정의가 가능하다.
    abstract 키워드로 표시된 클래스는 파생 클래스의 생성자를 통해서만 사용해서만 개체(Instance) 생성이 가능하다.
    abstract 키워드를 속성 또는 메서드에 사용하려는 경우, 해당 클래스가 반드시 abstract 로 표시되어 있는 클래스여야 한다.
*/

abstract class SuperA // 추상클래스. 자기자신의 instance 생성 불가. 반드시 자식생성자를 통해서만.
{
    public abstract void Execute(); 
}

/*
    override (우선시하다 / 치환하다), 재정의.
    이 키워드는 abstract 또는 virtual 키워드로 표시된 속성이나 메서드에만 사용 가능.
    그렇기 때문에 이 키워드는 어떤 클래스를 상속하는 하위 클래스에서만 사용이 가능.
*/
class SubA : SuperA
{
    public override void Execute() // 오버라이딩
    {
        Debug.Log("A");
    }
}
class SuperB
{
    public void Execute1()
    {
        Debug.Log("B-1");
    }
    public virtual void Execute2() // 가상 함수
    {
        Debug.Log("B-2");
    }
}

class SubB : SuperB
{
    public void Execute1()
    {
        Debug.Log("C-1");
    }
    public override void Execute2()
    {
        Debug.Log("C-2");        
    }
    public void Execute3()
    {
        base.Execute1();
        Debug.Log("C-3");
    }
}



public class CSharpEx : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SuperA super1 = new SubA(); // 추상 클래스는 자식클래스의 생성자를
        super1.Execute();           //  통해서만 생성 가능.
        // A

        SuperB super2 = new SuperB();   // 일반 클래스.
        super2.Execute1();
        super2.Execute2();  // 가상함수.
        // B-1
        // B-2

        // 파생 클래스에서 재정의한 멤버 함수를 기본 클래스의 포인터로 호출하면
        // 일반적으로 재정의 전의 멤버 함수가 호출된다. 자신의 설계도를 보고 자신을 찾아 온다.
        // 재정의한 후의 멤버 함수가 호출되도록 하기 위해서는
        // 기본 클래스에서 그 함수를 가상 함수로 해둔다.

        SuperB super3 = new SubB();
        super3.Execute1();
        super3.Execute2();  // override 를 이용해서 재정의.
        // B-1
        // C-2

        SubB sub1 = new SubB();
        sub1.Execute1();
        Debug.Log("Execute1 end");
        sub1.Execute2();
        Debug.Log("Execute2 end");
        sub1.Execute3();
        Debug.Log("Execute3 end");
        // C-1
        // Execute1 end
        // C-2
        // Execute2 end
        // B-1
        // C-3
        // Execute3 end

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
