using UnityEngine;

public class RotateAround : MonoBehaviour
{

    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, 50 * Time.deltaTime);
    }
}
