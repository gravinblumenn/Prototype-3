using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerControll playerControllScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllScript = GameObject.Find("Player").GetComponent<PlayerControll>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllScript.gameOver == false)
        {
        transform.Translate (Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
