using UnityEngine;
using System.Collections;

public class TestMouseRay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1")) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 1000f, Color.green, 1f, false);

            RaycastHit info;
            if (Physics.Raycast(ray, out info))
            {
                if (info.collider.CompareTag("Vulnerable"))
                {
                    Debug.Log("Damage");
                }
                else
                {
                    Debug.Log("Hit");
                }
            }
        }
	}
}
