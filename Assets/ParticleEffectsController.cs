using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectsController : MonoBehaviour
{
    public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
        //particleSystem.Play();

    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space))
        {
            particle.Play();
        }
     if(Input.GetKeyDown(KeyCode.Z))
        {
            particle.Stop();
        }
    }
   
}
