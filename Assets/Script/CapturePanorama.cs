using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturePanorama : MonoBehaviour
{
    public RenderTexture rt;
    public RenderTexture equirect;
    void LateUpdate()
    {
        Camera Cam = GetComponent<Camera>();
        Cam.RenderToCubemap(rt);
        rt.ConvertToEquirect(equirect);
        Save(equirect);
    }

    public void Save(RenderTexture rt)
    {
        Texture2D tex = new Texture2D(rt.width, rt.height);

        RenderTexture.active = rt;
        tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        RenderTexture.active = null;

        byte[] bytes = tex.EncodeToJPG();

        string path = Application.dataPath + "/Panorama" + ".jpg";

        System.IO.File.WriteAllBytes(path, bytes);
    }
}
