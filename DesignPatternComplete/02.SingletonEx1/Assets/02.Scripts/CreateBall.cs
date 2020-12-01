using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBall : MonoBehaviour {

    public GameObject ball;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 pos = new Vector3(0.0f, 4.0f, 0.0f);
            Instantiate(ball, pos, Quaternion.identity);
        }
    }

}
