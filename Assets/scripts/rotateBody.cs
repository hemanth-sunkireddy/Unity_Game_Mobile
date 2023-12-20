using UnityEngine;

public class rotateBody : MonoBehaviour
{
    void Start(){

    }
    void Update(){
        transform.Rotate(new Vector3(0,0,90));
        Debug.Log("Rotated");
    }
}