using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public int band;
    public float startScale;
    public float scaleMultiplier;

    public Material mat;

    // Use this for initialization
    void Start () {
        mat = GetComponentInChildren<MeshRenderer>().materials[0];
    }
	
	// Update is called once per frame
	void Update () {

        float y = startScale + (audioScript.freqBand[band] * scaleMultiplier);
        float x = transform.localScale.x;
        float z = transform.localScale.z;
        transform.localScale = new Vector3(x, y, z);

        // Changes color of frequency bins
        float r = audioScript.audioBands[band];
        float g = 0;
        float b = audioScript.audioBands[band];

        Color col = new Color(r, g, b);
        mat.shader = Shader.Find("Specular");
        mat.SetColor("_SpecColor", col);

    }
}
