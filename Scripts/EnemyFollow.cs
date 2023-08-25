using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public CharacterController controller;
    public Transform target;

    public float distance =.03f;
    public float gravity = -9.81f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
        controller.transform.position = Vector3.MoveTowards(transform.position, target.position, distance);
    }
}
