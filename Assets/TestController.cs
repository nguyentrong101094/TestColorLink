using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    [SerializeField] DamageFloatText dmgPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s")) Instantiate(dmgPrefab);
    }
}
