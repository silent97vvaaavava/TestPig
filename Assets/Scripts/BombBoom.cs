using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBoom : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            DataGame._instantion.DecreaseEnemy();
            Destroy(other.transform.parent.gameObject);
        }
    }

    void DestroyBomb()
    {
        Destroy(gameObject, 0.5f);
    }
}
