using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector2 farePos;
    Vector2 gecisPos;
    public float hassasiyet = 5.0f;
    public float yumusaklik = 2.0f;
    GameObject oyuncu;

    void Start()
    {
        oyuncu = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(hassasiyet * yumusaklik, hassasiyet * yumusaklik));
        gecisPos.x = Mathf.Lerp(gecisPos.x, md.x, 1f / yumusaklik);
        gecisPos.y = Mathf.Lerp(gecisPos.y, md.y, 1f / yumusaklik);
        farePos += gecisPos;
        transform.localRotation = Quaternion.AngleAxis(-farePos.y, Vector3.right);
        oyuncu.transform.localRotation = Quaternion.AngleAxis(farePos.x, oyuncu.transform.up);
    }
}
