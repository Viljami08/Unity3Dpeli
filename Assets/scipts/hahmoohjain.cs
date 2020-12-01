using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hahmoohjain : MonoBehaviour
{
    public float juoksunopeus = 3f;
    public float hiirenNopeus = 3f;

    public CharacterController controller;

    private  float vertikaalinenPyörintä = 0f;

    private float horisontaalinenPyörintä = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horisontaalinenPyörintä += Input.GetAxis("Mouse X") * hiirenNopeus;
         vertikaalinenPyörintä += Input.GetAxis("Mouse Y") * hiirenNopeus;

        Camera.main.transform.localRotation = Quaternion.Euler(vertikaalinenPyörintä,horisontaalinenPyörintä,0);

        float nopeusEteen = Input.GetAxis("Vertical");
        float nopeusSivulle = Input.GetAxis("Horizontal");
        Vector3 nopeus = new Vector3(nopeusSivulle,0,nopeusEteen);
        nopeus = transform.rotation * nopeus;
        controller.SimpleMove(nopeus);
        
    }
}
