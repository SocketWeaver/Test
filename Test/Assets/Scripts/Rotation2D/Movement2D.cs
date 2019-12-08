using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWNetwork;

public class Movement2D : MonoBehaviour
{
    public float rotateSpeed = 20f;
    NetworkID networkID;
    // Start is called before the first frame update
    void Start()
    {
        networkID = GetComponent<NetworkID>();
    }

    // Update is called once per frame
    void Update()
    {
        if(networkID.IsMine)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
            }
        }
    }
}
