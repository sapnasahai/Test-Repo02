using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustEffect : MonoBehaviour
{
    public ParticleSystem dust;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Createdust();
            transform.position += new Vector3(-1, 0, 0); 
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Createdust();
            transform.position += new Vector3(1, 0, 0);
        }
    }



    void Createdust()
    {
        dust.Play();
    }
}
