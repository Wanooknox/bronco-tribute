using UnityEngine;

public class Push : MonoBehaviour {

    public Vector3 angle;
    public float thrust;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Invoke("DoPush", 2);
    }

    private void DoPush() {
        rb.AddForce(angle * thrust);
    }

    private void Update() {
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
            
    }

}
