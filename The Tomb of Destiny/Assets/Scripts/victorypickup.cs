using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victorypickup : MonoBehaviour
{
    public int victoryreq { get; private set; }

    public GameManager gameManager;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameManager.CompleteLevel();
        }
    }
}
