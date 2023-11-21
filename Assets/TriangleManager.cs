using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSsample;
using Unity.VisualScripting;

public class TriangleManager : MonoBehaviour
{
    [SerializeField]
    ScoreText scoreText;
    [SerializeField]
    private List<Transform> triangles = new List<Transform>();
    private float GetSurface()
    {
        if (triangles.Count == 0)
        {
            return 0;
        }
        var l0 = Vector3.Distance(
            triangles[0].transform.localPosition,
            triangles[1].position);
        var l1 = Vector3.Distance(
            triangles[1].transform.localPosition,
            triangles[2].position);
        var l2 = Vector3.Distance(
            triangles[2].transform.localPosition,
            triangles[0].position);
        return Triangle.GetSurface(l0, l1, l2);

    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.Score=GetSurface();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.Score = GetSurface();
    }
}
