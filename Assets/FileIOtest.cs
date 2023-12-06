using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileIOtest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //File.WriteAllText(@"test.txt", "Good morning!");
        StreamReader sr = new StreamReader(@"test.txt");
        //Read the first line of text
        var line = sr.ReadLine();
        string[] strings = line.Split(new char[] { });
        sr.Close();
        Vector3 v = new Vector3(
            float.Parse(strings[0]),
            float.Parse(strings[1]),
            float.Parse(strings[2]) );
        GameObject go=GameObject.Instantiate(this.gameObject, v, Quaternion.identity);
        Destroy( go.gameObject.GetComponent<FileIOtest>() );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
