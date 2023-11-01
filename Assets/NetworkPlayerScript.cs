using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayerScript : MonoBehaviour
{
    private Camera playerCamera;

    private void Awake()
    {
        
        this.playerCamera = GetComponentInChildren<Camera>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
