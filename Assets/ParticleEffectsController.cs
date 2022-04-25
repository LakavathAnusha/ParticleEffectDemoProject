using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectsController : MonoBehaviour
{
    ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        //particleSystem.Play();

    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space))
        {
            particleSystem.Play();
        }
     if(Input.GetKeyDown(KeyCode.Z))
        {
            particleSystem.Stop();
        }
    }
   
}
