using UnityEngine;
using System.Collections;

public class CameraFocus : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;
    public Camera cam;
    public GameObject WinSquare;
    Vector3 cameraOffset, obj1Offset, obj2Offset;
    int playerWin;

	// Use this for initialization
	void Start ()
    {
        playerWin = 0;
        cameraOffset = cam.transform.position;
        obj1Offset = obj1.transform.position;
        obj2Offset = obj2.transform.position;
	}

    void OnTriggerEnter(Collider cd)
    {

    }
    
    
    // Update is called once per frame
	void Update ()
    {
        if (playerWin == 0)
        {
            transform.position = Vector3.Lerp(obj1.transform.position, obj2.transform.position, 0.5f);
            cam.transform.position = transform.position + cameraOffset;
        }
        else //playerWin == 2 or 1
        {
            //WinSquare.
            obj1.transform.position = obj1Offset;
            obj2.transform.position = obj2Offset;
            cam.transform.position = cameraOffset;
        }

        if (transform.position.y < 0)
        {
            if (obj1.transform.position.y < obj2.transform.position.y)
            {
                playerWin = 2;
                //PLAYER TWO WINS
            }
            else
            {
                playerWin = 1;
                //PLAYER ONE WINS
            }
        }
    }
}
