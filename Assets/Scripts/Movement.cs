using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float rotationThrust = 100f;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] ParticleSystem boostParticle;
    [SerializeField] Button LeftControl;
    [SerializeField] Button RightControl;

    public static Movement instance;
 
    Rigidbody rb;
    AudioSource audiosource;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Debug.Log("Start called");
        rb = GetComponent<Rigidbody>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            moveUp();
        }
        else
        {
            boostParticle.Stop();
        }
       
    }

    public void moveUp()
    {
        Debug.Log("Move up");
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        boostParticle.Play();
        if (!audiosource.isPlaying)
            audiosource.PlayOneShot(mainEngine);
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(-rotationThrust);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            ApplyRotation(rotationThrust);
        }
    }

    public void ApplyRotation(float rotationThisFrame)
    {
        Debug.Log("Rotation Function Called");
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }


}
