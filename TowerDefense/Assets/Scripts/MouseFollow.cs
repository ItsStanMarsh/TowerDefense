using UnityEngine;


public class MouseFollow : MonoBehaviour
{

    public Camera myCam;

    private float xPos;
    private float zPos;

    public Transform item1;

    void Update()
    {
        RaycastHit vHit = new RaycastHit();
        Ray vRay = myCam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(vRay, out vHit, 1000))
        {
            xPos = Mathf.Round(vHit.point.x);
            zPos = Mathf.Round(vHit.point.z);

            item1.transform.position = new Vector3(xPos, 0.5f, zPos);
        }

        

    }
}
