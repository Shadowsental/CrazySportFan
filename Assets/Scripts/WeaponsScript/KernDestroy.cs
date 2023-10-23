using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KernDestroy : MonoBehaviour
{
    public float destroyTime = 2f;
    public GameObject popcorn;

    public int amount = 5;

    public float direction;
    

    private void Update()
    {
        direction = Random.Range(0,360);

        destroyTime -= Time.deltaTime;
        if (destroyTime < 0 )
        {
                popcorn = Instantiate(popcorn, transform.position, Quaternion.Euler(new Vector3(0, direction, 0)));
                popcorn.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(600, 0, 0));
            Destroy(gameObject);

        }
    }
}
