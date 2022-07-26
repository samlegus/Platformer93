using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TarodevController;

public class Player : MonoBehaviour
{
    public ScriptableStats stats;
    public float originalSpeed;

    void Start()
    {
        originalSpeed = stats.MaxSpeed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            stats.MaxSpeed = originalSpeed * 1.2f;
        else
            stats.MaxSpeed = originalSpeed;
    }
}
