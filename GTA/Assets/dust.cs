using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dust : MonoBehaviour
{


    public ParticleSystem Dust;





    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            CreateDust();
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            CreateDust();
            transform.position += new Vector3(1, 0, 0);
        }


    }
        // Update is called once per frame
    void CreateDust()
    {
            Dust.Play();
    }

    
}
