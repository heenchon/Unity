using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown (0))
        //{
        //    Shoot (new Vector3 (0,0,-500));
        //}
    }
    public void Shoot (Vector3 dir)
    {
        GetComponent<Rigidbody> ().AddForce (dir);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "ENEMY")
        {
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreManager>().IncScore();
            Destroy (gameObject, 0.01f);
        }
        if(collision.collider.tag == "WALL")
        {
            Destroy (gameObject, 0.01f);
        }
    }
}
