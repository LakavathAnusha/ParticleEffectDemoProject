using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
      //  particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject);
            GameObject temp = Instantiate(particle, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(temp, 0.2f);
            Destroy(gameObject, 1f);
        }
    }
}
