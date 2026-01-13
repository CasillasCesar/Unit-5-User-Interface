using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody targetRb;
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        // Add an upward force multiplied by a randomized speed
        targetRb.AddForce(Vector3.up * Random.Range(12,16), ForceMode.Impulse);
        // Add a torque with randomized xyz values
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        // Set the position with a randomized X value
        transform.position = new Vector3(Random.Range(-4,4), -6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
