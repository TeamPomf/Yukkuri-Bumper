using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;
    public Camera cam;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Vector3 interp;
        //interp = Vector3.Lerp(obj1.transform.position, obj2.transform.position, 0.5f) - transform.position;
        //transform.Translate(interp);
        transform.position = Vector3.Lerp(obj1.transform.position, obj2.transform.position, 0.5f);
        Vector3 camOffset = new Vector3(0f, 12f, -14f);
        cam.transform.position = transform.position + camOffset;

        //float tx = Mathf.Lerp(obj1.transform.position.x, obj2.transform.position.x, 0.5f) - transform.position.x;
        //float ty = Mathf.Lerp(obj1.transform.position.y, obj2.transform.position.y, 0.5f) - transform.position.y;
        //float tz = Mathf.Lerp(obj1.transform.position.z, obj2.transform.position.z, 0.5f) - transform.position.z;
        //transform.Translate(tx, ty, tz);
        //tx = transform.position.x - cam.transform.position.x;
        //ty = transform.position.y - cam.transform.position.y + 12;
        //tz = transform.position.z - cam.transform.position.z + -14;
        //cam.transform.Translate(tx,ty,tz);
    }
}
