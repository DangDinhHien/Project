using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour {

    // public GameObject target;
    Vector3 MousePos;
    public float speedSheep = 20;
    public float miny = -3, maxy = 3, minx = -5.4f, maxx = 5.4f;
    public GameObject gameController;

	// Use this for initialization
	void Start () {
        MousePos = transform.position;  // transform la toa do con cuu luc dau tien
        gameController = GameObject.FindGameObjectWithTag("GameController");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) 
        {
            MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Gan toa do con chuot
            // Gan lai toa do chuot trong Range, va cho z = 0
             MousePos = new Vector3(Mathf.Clamp(MousePos.x, minx, maxx), Mathf.Clamp(MousePos.y, miny, maxy), 0);
        }

        transform.position = Vector3.Lerp(transform.position, MousePos, speedSheep * Time.deltaTime);
	}

    void OnTriggerEnter2D(Collider2D orther)
    {
        
        Destroy(orther.gameObject);
        gameController.GetComponent<GameController>().EndGame();
    }
}
