using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Ball.total_score++;
        // gameObject - это текущая фигура, та на которой лежит скрипт
        Destroy(gameObject);

    }
}
