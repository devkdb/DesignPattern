using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

	void Start () {
        // Setup context in a state
        Context c = new Context(new ConcreteStateA());
        c.Request();

        // Issue requests, which toggles state
        c.setState(new ConcreteStateB());
        c.Request();

        c.setState(new ConcreteStateA());
        c.Request();
    }
}
