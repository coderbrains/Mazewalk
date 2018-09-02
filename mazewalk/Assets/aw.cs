using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class aw : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public float speed = 7;

    void Update()
    {
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
    }
    public void OnTriggerEnter(Collider collide)
    {
        if(collide.gameObject.CompareTag("Trophytag"))
        {
            SceneManager.LoadScene("endscene");
        }
    }
}
