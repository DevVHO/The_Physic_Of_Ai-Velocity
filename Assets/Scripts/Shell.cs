using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Shell : MonoBehaviour
{
    public GameObject explosion;
    public float speed = 3f;
    private float Force = 1000f;
    private float Mass = 10f;
    private float Acceleration;

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

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Acceleration = Force / Mass;
        speed += Acceleration * Time.deltaTime;
        this.transform.Translate(0,0,speed*Time.deltaTime);
    }
}
