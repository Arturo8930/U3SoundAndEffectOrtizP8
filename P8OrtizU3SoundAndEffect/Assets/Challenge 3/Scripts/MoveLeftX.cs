using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerXScript;
    private float leftBound = -50;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerXScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
        if (playerControllerXScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
    
        if (transform.position.x < leftBound && gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }

    }
}
