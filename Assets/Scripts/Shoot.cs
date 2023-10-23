using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float bulletSpeed = 100;
    public GameObject bullet;

    public float cooldown;


    public void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
            Debug.Log("Fire");
        }
    }

    void Fire()
    {
        bullet = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        bullet.name = bullet.name.Replace("(Clone)", "");
        bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (bulletSpeed, bulletSpeed, 0));
    }
}
