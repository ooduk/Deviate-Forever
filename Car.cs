using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    
    public int direction;
    public float limit;

    public float speed = 2;

    private void Update()
    {

        transform.position += Vector3.right * direction * speed * Time.deltaTime;

        if (direction >= -5 && transform.position.x > limit)
        {
            Destroy(this.gameObject);

        }
    }
}
