using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public GameObject Player;
    public float speed = 2;
    public GameObject MainCamera;
    private Vector3 cameraOffset;
    // Start is called before the first frame update
       void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");

        cameraOffset = MainCamera.transform.position - Player.transform.position;
    }

    // Update is called once per frame
   void Update()
    {
        Vector3 targetPosition = Player.transform.position + cameraOffset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
    }
}
