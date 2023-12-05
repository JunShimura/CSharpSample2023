using System.Collections;
using System.Collections.Generic;
//using System.ComponentModel;
using UnityEngine;

public class ComponentTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Component[] components_0 = GetComponents<Component>();
        foreach (var component in components_0)
        {
            Debug.Log(component);
        }
        Transform tr = GetComponent<Transform>();
        Rigidbody rb = GetComponent<Rigidbody>();
        Transform[] transforms = new Transform[2];
        transforms[0] = tr;
        //transforms[1] = rb;  //エラーになる
        Component[] components_1 = new Component[2];
        components_1[0] = tr;
        components_1[1] = rb;

        int a = 0;
        float b = 2.5f;
        //a = b; //エラーになる
    }
}
