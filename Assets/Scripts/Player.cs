using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controller;

    private Vector3 movedir = Vector3.zero;
    // Playerの移動値を入れる変数
    public float speedZ;
    public float acceleratorZ;



    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movedir.z = Mathf.Clamp(movedir.z + (acceleratorZ * Time.deltaTime), 0, speedZ);
        Vector3 globaldir = transform.TransformDirection(movedir);
        controller.Move(globaldir * Time.deltaTime);

    }
}
