using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Shell : MonoBehaviour
{
    public GameObject explosion;
    float speed = 0;
    float Force = 1;
    float Mass = 10;
    float yspeed = 0f;
    float drag = 1;
    float gravity = 9.8f;
    float gAccel;
    float Acceleration;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Acceleration = Force / Mass;
        speed += Acceleration * 1;
        gAccel = gravity / Mass; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        speed *= (1 - Time.deltaTime * drag);
        speed += Acceleration * Time.deltaTime;
        this.transform.Translate(0,yspeed,speed);
    }
}
