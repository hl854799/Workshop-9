using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 1.0f; // Default speed sensitivity
    public GameObject projectilePrefab;
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate<GameObject>(projectilePrefab);
            projectile.transform.position = this.gameObject.transform.position;
        }
    }
}
