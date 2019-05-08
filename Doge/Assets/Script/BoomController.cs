using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour {

    public Vector3 target;
    public float speed = 5;
    public float timedestroy = 1;
    //public GameObject gameController;
    public GameObject no;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, timedestroy);
        //gameController = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((target - transform.position) * speed * Time.deltaTime);
	}

    void OnDestroy()
    {
        GameObject temp = Instantiate(no, transform.position, Quaternion.identity);
        Destroy(temp, 0.1f);
        //gameController.GetComponent<GameController>().GetPoint();
    }
}
