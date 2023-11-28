using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SampleTest();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SampleTest()
    {
        Vector3[] vector3s = { new Vector3(1, 0, 1), Vector3.up, };
        foreach (Vector3 v in vector3s)
        {
            UnityEngine.Debug.Log(v);
        }
        Component[] components = GetComponents<Component>();
        /*
        = {
            GetComponent<Rigidbody>(),
            GetComponent<AudioSource>()
        };
        */
        foreach (Component comp in components)
        {
            Debug.Log(comp.ToString());
        }
        MonoBehaviour[] monoBehaviours = {this,new TriangleManager(),GetComponent<Turn>()};
    }
}
