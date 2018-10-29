using UnityEngine;


public class MouseFollow : SelectItem
{

    public Camera myCam;

    private int xPos;
    private int zPos;

    public GameObject ItemOnMouse;


    public override void Start()
    {
        base.Start();
    }

    public override void Update()
    {
        base.Update();
        RaycastHit vHit = new RaycastHit();
        Ray vRay = myCam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(vRay, out vHit, 1000))
        {

            ItemOnMouse = GameObject.Find("ItemOnMouse");

            xPos = Mathf.RoundToInt(vHit.point.x);
            zPos = Mathf.RoundToInt(vHit.point.z);
            
            if(ItemOnMouse)
            {
              ItemOnMouse.transform.position = new Vector3(xPos, 0.5f, zPos);
            }
        }

        

    }

    public int GetMousePosX()
    {
        return xPos;
    }

    public int GetMousePosZ()
    {
        return zPos;
    }
}
