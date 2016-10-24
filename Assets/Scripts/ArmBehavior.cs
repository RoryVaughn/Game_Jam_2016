using UnityEngine;
using System.Collections;

public class ArmBehavior : MonoBehaviour {

    private float Radius = 2;
    public Vector3 Displacement;
    float speed = 40.0f;
    bool wkey = false;
    bool skey = false;
    bool qkey = false;
    float h;
    float v;
    float c;
    bool ekey = false;
    bool dkey = false;
    bool akey = false;
    public GameObject PlayerBody;
	// Use this for initialization
	void Start () {
        Debug.Log(transform.parent.parent.parent.parent.parent.parent.gameObject.name);
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 1")
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            c = Input.GetAxis("UP");
        }
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 2")
        {
            h = Input.GetAxis("Horizontal2");
            v = Input.GetAxis("Vertical2");
            c = Input.GetAxis("UP2");
        }
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 3")
        {
            h = Input.GetAxis("Horizontal3");
            v = Input.GetAxis("Vertical3");
            c = Input.GetAxis("UP3");
        }
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 4")
        {
            h = Input.GetAxis("Horizontal4");
            v = Input.GetAxis("Vertical4");
            c = Input.GetAxis("UP4");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Displacement = (gameObject.transform.position - PlayerBody.transform.position);
        wkey = false;
        skey = false;
        qkey = false;
        ekey = false;
        dkey = false;
        akey = false;



        Vector3 direction = Vector3.zero;
        Quaternion rotation = new Quaternion(0,0,0,0);
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 1")
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            c = Input.GetAxis("UP");
        }
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 2")
        {
            h = Input.GetAxis("Horizontal2");
            v = Input.GetAxis("Vertical2");
            c = Input.GetAxis("UP2");
        }
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 3")
        {
            h = Input.GetAxis("Horizontal3");
            v = Input.GetAxis("Vertical3");
            c = Input.GetAxis("UP3");
        }
        if (transform.parent.parent.parent.parent.parent.parent.gameObject.name == "GladiatorV004 4")
        {
            h = Input.GetAxis("Horizontal4");
            v = Input.GetAxis("Vertical4");
            c = Input.GetAxis("UP4");
        }
        if (v > 0 && transform.position.z < Radius + PlayerBody.transform.position.z+2)
        {
            wkey = true;
        }

        if (v < 0 && transform.position.z > -Radius + PlayerBody.transform.position.z-2 )
        {
            skey = true;
        }
        if (c > 0 && transform.position.y < Radius + PlayerBody.transform.position.y)
        {
            qkey = true;
        }
        if (c < 0 && transform.position.y > -Radius + PlayerBody.transform.position.y)
        {
            ekey = true;
        }

        if (h > 0 && transform.position.x < Radius + PlayerBody.transform.position.x-5)
        {
            dkey = true;
        }

        if (h < 0 && transform.position.x > -Radius + PlayerBody.transform.position.x-10)
        {
            akey = true;
        }

        if (wkey == true || skey == true)
        {
            direction += Vector3.forward * (v* speed) * Time.deltaTime;
        }
        if (qkey == true || ekey == true)
        {
            direction += Vector3.up * ((c * -speed) * Time.deltaTime);
        }

        if (dkey == true || akey == true)
        {
            direction += Vector3.right * (h * speed) * Time.deltaTime;
        }
        transform.position += direction * speed * Time.deltaTime;
        
        //if (Displacement.x >= Radius )
        //{
        //    gameObject.transform.position = new Vector3(PlayerBody.transform.position.x + Displacement.x, PlayerBody.transform.position.y, PlayerBody.transform.position.z);
        //}
        //if (Displacement.y >= Radius)
        //{
        //    gameObject.transform.position = new Vector3(PlayerBody.transform.position.x, PlayerBody.transform.position.y + Displacement.y, PlayerBody.transform.position.z);
        //}
        //if (Displacement.z >= Radius)
        //{
        //    gameObject.transform.position = new Vector3(PlayerBody.transform.position.x, PlayerBody.transform.position.y, PlayerBody.transform.position.z + Displacement.z);
        //}

    }
}
