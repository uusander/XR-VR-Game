using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit.Inputs;
using UnityEngine.InputSystem.XR;

public class NetworkPlayer : MonoBehaviour
{
    private PhotonView photonView;
    //private InputActionManager inputActionManager;
    [SerializeField] private GameObject localCharacter;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        //inputActionManager = GetComponentInChildren<InputActionManager>();

        if (!photonView.IsMine)
        {
            localCharacter.SetActive(false);
            //inputActionManager.DisableInput();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!photonView.IsMine)
        {
            //localCharacter.SetActive(false);
            //inputActionManager.DisableInput();
        }
    }
}
