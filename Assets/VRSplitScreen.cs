using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRSplitScreen : MonoBehaviour
{
    public Camera leftCamera;
    public Camera rightCamera;
    public float IPD = 0.064f; // distancia interpupilar promedio en metros

    void Start()
    {
        leftCamera.rect = new Rect(0, 0, 0.5f, 1);
        rightCamera.rect = new Rect(0.5f, 0, 0.5f, 1);

        float distanceFromCenter = IPD / 2;
        Vector3 leftPos = leftCamera.transform.position;
        Vector3 rightPos = rightCamera.transform.position;
        leftPos.x -= distanceFromCenter;
        rightPos.x += distanceFromCenter;
        leftCamera.transform.position = leftPos;
        rightCamera.transform.position = rightPos;
    }
}
