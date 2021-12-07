using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float speed = 5f;

    private float upperLim = 10f;
    private float lowerLim = -10f;
    private float leftLim = -15f;
    private float rightLim = 15f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        //Destrucción de la bala en los diferentes ejes.
        if (transform.position.y > upperLim)
        {
            Destroy(gameObject);
        }


        if (transform.position.y < lowerLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < leftLim)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > rightLim)
        {
            Destroy(gameObject);
        }
    }
}