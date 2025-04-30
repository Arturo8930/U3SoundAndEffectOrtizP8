using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
    private PlayerControllerIII playerControllerIIIScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerIIIScript = GameObject.Find("Road Rager (Player)").GetComponent<PlayerControllerIII>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerIIIScript.gameOver)
        {
            if (playerControllerIIIScript.doubleSpeed)
            {
                score += 2;
            }
            else
            {
                score++;
            }
            Debug.Log("Score: " + score);
        }
    }
}
