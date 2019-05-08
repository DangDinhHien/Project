using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour {

    public GameObject Boom;
    public float mintime = 2, maxtime = 4;
    private float lastboomtime = 0, boomtime = 0;
    private GameObject Sheep;
    private Animator ani;
    private float t = 0.5f;
    private GameObject gameController;
	// Use this for initialization
	void Start () {
        UpdateBoomTime();
        Sheep = GameObject.FindGameObjectWithTag("Player");
        ani = gameObject.GetComponent<Animator>();
        ani.SetBool("nam", false);
        gameController = GameObject.FindGameObjectWithTag("GameController");
	}

    private void UpdateBoomTime()
    {
        lastboomtime = Time.time; // Gan = 0 khi moi zo game
        boomtime = Random.Range(mintime, maxtime + 1); // thoi gian no boom cua moi con
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= lastboomtime + boomtime - t)
        {
            ani.SetBool("nam", true);
        }
        if (Time.time >= lastboomtime + boomtime)
        {
            ThrowBoom();
        }


	}

    // Tao ngau nhien boom
    void ThrowBoom()
    {
        // Tao qua boom va luu toa do no lai
        GameObject bom = Instantiate(Boom, transform.position, Quaternion.identity);
        bom.GetComponent<BoomController>().target = Sheep.transform.position;
        UpdateBoomTime();
        ani.SetBool("nam", false);
        gameController.GetComponent<GameController>().GetPoint();

       
    }
}
