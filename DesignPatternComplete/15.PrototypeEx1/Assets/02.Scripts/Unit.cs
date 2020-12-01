using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 'IPrototype' interface
public interface IUnit
{
    // Method for cloning
    IUnit Clone();
}

// 'ConcretePrototype1' class implements IPrototype interface
public class Marine : IUnit
{
    public int Hp { get; set; }
    public int AttackPower { get; set; }

    // Implement shallow cloning method
    public IUnit Clone()
    {
        // Shallow Copy
        return this.MemberwiseClone() as IUnit;

        // Deep Copy
        // Implement Memberwise clone method for every reference type object 
        // return ..
    }
}

public class Firebat : IUnit
{
    public int Age { get; set; }
    public int AttackPower { get; set; }

    // Implement shallow cloning method
    public IUnit Clone()
    {
        // Shallow Copy 
        return this.MemberwiseClone() as IUnit;
    }
}
