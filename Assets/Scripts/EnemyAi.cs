using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float speed = 20.0f;
    public float minDiist = 1f;
    public Transform player;

    public Rigidbody rb;

    private void Update()
    {

        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        if (player == null)
        {
            if(GameObject.FindWithTag("Player") != null) 
            {
                FollowerPlayer();
                Debug.Log("Found him!");
            }

            Debug.Log("I lost him...");
        }
    }

    void FollowerPlayer()
    {
        Debug.Log("There he is!");
        Vector3 position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        rb.MovePosition(position);
        transform.LookAt(player);
    }





}
