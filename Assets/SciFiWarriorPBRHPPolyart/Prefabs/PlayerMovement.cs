using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    //public int jumpForce;
    //Rigidbody rb;
   // public int health;
    //public Animator animator;
    public Transform bulletDirection;
    AudioClip audio;
    public AudioSource audioSource;
    void Start()
    {
       // animator = GetComponent<Animator>();
       
        audio = GetComponent<AudioClip>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal") * playerSpeed;
        float inputZ = Input.GetAxis("Vertical") * playerSpeed;
        transform.Translate(inputX, 0f, inputZ);
        if (Input.GetMouseButtonDown(0))
        {
            //animator.SetTrigger("IsFiring");
           // audioSource.Play();
            HitEnemy();
        }
 
    }
    private void HitEnemy()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(bulletDirection.position, bulletDirection.forward, out hitInfo, 1000f))
        {
            GameObject hitEnemy = hitInfo.collider.gameObject;
            if (hitEnemy.tag == "Enemy")
            {
                print("Enemy got hit");
              // hitEnemy.GetComponent<EnemyController>().EnemyDead();
                Destroy(hitEnemy,4f);
            }
        }
    }
   
  
}