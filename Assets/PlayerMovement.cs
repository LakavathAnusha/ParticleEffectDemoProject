using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    public GameObject bullet;
    public Vector3 offset;
    //ParticleSystem particle;
    private float time;
    public GameObject bulletExplosion;
    public Vector3 anusha;

    //public int jumpForce;
    //Rigidbody rb;
    // public int health;
    //public Animator animator;
    // public Transform bulletDirection;
    //AudioClip audio;
    //public AudioSource audioSource;
    void Start()
    {
        //particle = GetComponent<ParticleSystem>();
        // animator = GetComponent<Animator>();

        //audio = GetComponent<AudioClip>();
        //audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        transform.Translate(inputX*playerSpeed*Time.deltaTime, 0f, inputZ * playerSpeed*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position+offset, Quaternion.identity);
            GameObject temp = Instantiate(bulletExplosion, bullet.transform.position+anusha, Quaternion.identity);
           Destroy(temp, 0.3f);
          
        }
    }
}