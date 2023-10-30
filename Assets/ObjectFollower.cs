using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    [SerializeField] private GameObject objectToFollow;
    private Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        this.transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.objectToFollow == null)
            return;

        this.transform.position = this.objectToFollow.transform.position;
        this.transform.rotation = this.objectToFollow.transform.rotation;
        this.transform.localScale = this.objectToFollow.transform.localScale;
    }
}
