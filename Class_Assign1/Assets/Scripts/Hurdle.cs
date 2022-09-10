using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurdle : MonoBehaviour
{
    public Material mat;
    public MeshRenderer mesh;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Sphere"))
        {
            mesh.material = mat;
        }
    }
}