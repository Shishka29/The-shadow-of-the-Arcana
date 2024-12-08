using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{


    [SerializeField] private portal toPortal;


    public static bool tpActive;

    // Start is called before the first frame update
    void Start()
    {
        tpActive = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

        if (tpActive)
        {
            tpActive=false;
            float magnitude = rb.velocity.magnitude;
            rb.velocity = Vector3.zero;
            Vector3 direction =toPortal.transform.TransformDirection(Vector3.right)-transform.TransformDirection(Vector3.left);
            other.transform.position=toPortal.transform.position;
            rb.AddForce(2*direction * magnitude , ForceMode2D.Impulse);
        }
        else tpActive = true;
    }
}
