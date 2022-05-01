using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameEnd = false;

    public float restartDelay;

    public GameObject endlevelUI;
    public GameObject deadlevelUI;
    // Start is called before the first frame update
    public void CompleteLevel()
    {
        endlevelUI.SetActive(true);
    }

    // Update is called once per frame
   

    public void Death()
    {
        deadlevelUI.SetActive(true);
    }
}
