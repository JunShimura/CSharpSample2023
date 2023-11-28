using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CSsample;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;

public class TriangleManager : MonoBehaviour
{
    [SerializeField]
    ScoreText scoreText;
    [SerializeField]
    private List<Transform> points = new List<Transform>();
    private List<LineRenderer> lineRenderers = new List<LineRenderer>();

    private float GetSurface()
    {
        if (points.Count == 0)
        {
            return 0;
        }
        /*
        var l0 = Vector3.Distance(
            points[0].position,
            points[1].position);
        var l1 = Vector3.Distance(
            points[1].position,
            points[2].position);
        var l2 = Vector3.Distance(
            points[2].position,
            points[0].position);
        */
        //Triangle triangle = new Triangle(l0, l1, l2);
        //return triangle.GetSurface();
        //return Triangle.GetSurface(l0, l1, l2);
        return Triangle3D.GetSurface(
            points[0].position,
            points[1].position, 
            points[2].position);
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.Score = GetSurface();
        lineRenderers.Add(points[0].gameObject.AddComponent<LineRenderer>());
        lineRenderers.Add(points[1].gameObject.AddComponent<LineRenderer>());
        lineRenderers.Add(points[2].gameObject.AddComponent<LineRenderer>());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.Score = GetSurface();
        Vector3[] v = new Vector3[2];
        for (int i = 0; i < points.Count; i++)
        {
            v[0] = points[i].position;
            v[1] = points[(i + 1) % points.Count].position;
            lineRenderers[i].SetPositions(v);
        }
    }
}
