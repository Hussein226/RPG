using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newRoom : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 cameraChange;
    public Vector3 playerChange;
    private CameraMovement cam;

    float playerPosX, playerPosY;


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();

        playerPosX = playerChange.x;
        playerPosY = playerChange.y;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            other.transform.position = new Vector3(playerPosX, playerPosY);
            
        }
        else
        {
            Debug.Log("Its not player");
        }



    }
}
