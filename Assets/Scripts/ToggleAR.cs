using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ToggleAR : MonoBehaviour
{
    public ARPlaneManager planeManager;
    public ARPointCloudManager pointCloudManager;

    void VisualizePlanes(bool active)
    {
        planeManager.enabled = active;
        foreach (ARPlane plane in planeManager.trackables)
        {
            plane.gameObject.SetActive(active);
        }
    }
    void VisualizeClouds(bool active)
    {
        pointCloudManager.enabled = active;
        foreach (ARPointCloud cloud in pointCloudManager.trackables)
        {
            cloud.gameObject.SetActive(active);
        }
    }

    public void OnValueChange(bool isOn)
    {
        VisualizePlanes(isOn);
        VisualizeClouds(isOn);
    }
}
