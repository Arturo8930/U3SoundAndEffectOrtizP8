using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float score;
    private PlayerControllerIII playerControllerIIIScript;
    public Transform startingPoint;
    public float lerpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerIIIScript = GameObject.Find("Road Rager (Player)").GetComponent<PlayerControllerIII>();
        score = 0;

        playerControllerIIIScript.gameOver = true;
        StartCoroutine(PlayIntro());
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerControllerIIIScript.gameOver)
        {
            if(playerControllerIIIScript.doubleSpeed)
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

    IEnumerator PlayIntro()
    {
        Vector3 startPos = playerControllerIIIScript.transform.position;
        Vector3 endPos = startingPoint.position;
        float journeyLength = Vector3.Distance(startPos, endPos);
        float startTime = Time.time;

        float distanceCovered = (Time.time - startTime) * lerpSpeed;
        float fractionOfJourney = distanceCovered / journeyLength;

        playerControllerIIIScript.GetComponent<Animator>().SetFloat("Speed_Multiplier", 0.5f);
    }
}
