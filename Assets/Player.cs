using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rd;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("kaishile");

        rd = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

        rd.AddForce(Vector3.right);
    }


    void Awake()
    { 
    //InvokeRepeating("",)
    }


    void OnEnable()
    {



    }

}
