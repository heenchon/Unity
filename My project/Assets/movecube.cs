using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecube : MonoBehaviour
{
    private bool inOn = true;

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(inOn)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
    }

    public void StopCube()
    {
        inOn = false;

        transform.position = startPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("WALL"))
        {
            Debug.Log("collision");
        }
    }
}
