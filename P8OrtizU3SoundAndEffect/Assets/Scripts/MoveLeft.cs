using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerControllerIII playerControllerIIIScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerIIIScript = GameObject.Find("Road Rager (Player)").GetComponent<PlayerControllerIII>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerIIIScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
            
}


