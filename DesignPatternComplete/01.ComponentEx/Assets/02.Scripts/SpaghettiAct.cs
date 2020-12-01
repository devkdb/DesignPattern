using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MOVE
{
    MOVE_RIGHT,
    MOVE_LEFT
}

public class SpaghettiAct : MonoBehaviour {

    GameObject player1;
    GameObject player2;
    MOVE move = MOVE.MOVE_RIGHT;

    void Start () {
        player1 = GameObject.Find("Player1") as GameObject;
        player2 = GameObject.Find("Player2") as GameObject;

        StartCoroutine("MixedAct"); // MixedAct 호출
    }

    // 0.5초마다 객체들을 회전하면서 (글로벌 방향으로) 이동시키기
    IEnumerator MixedAct() // 즉, 2개의 동작을 처리. <-- 여러 동작이 있다 가정했을때,  수정해야 한다면?
    {
        while (true)
        {
            // 회전
            player1.transform.Rotate(90.0f * Vector3.up);
            player2.transform.Rotate(90.0f * Vector3.up);

            if (player1.transform.position.x < -4)
            {
                move = MOVE.MOVE_RIGHT;
            }
            else if (player1.transform.position.x > 4)
            {
                move = MOVE.MOVE_LEFT;
            }

            // 왼쪽으로 갔다, 오른쪽으로 갔다 하고 있다.
            if (move == MOVE.MOVE_RIGHT)
            {
                player1.transform.Translate(1.0f * Vector3.right, Space.World);
                player2.transform.Translate(-1.0f * Vector3.right, Space.World);
            }
            else
            {
                player1.transform.Translate(-1.0f * Vector3.right, Space.World);
                player2.transform.Translate(1.0f * Vector3.right, Space.World);
            }

            yield return new WaitForSeconds(0.5f); // 0.5초 씩 기다리면서 계속 반복문을 돌린다.
        }
    }
}
