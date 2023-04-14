using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ButtonFollowVisual : MonoBehaviour
{
    public Transform visualTarget;
    public Vector3 localAxis;
    public float resetSpeed = 5;
    public float followAngleThreshold = 45.0f;
    public GameObject painting;
    public GameObject fiveSenses;
    public GameObject bodyScan;
    public GameObject musicListening;
    public GameObject dancingShaking;

    public GameObject paintHandMenu;
    public GameObject sensesHandMenu;
    public GameObject bodyHandMenu;
    public GameObject musicHandMenu;
    public GameObject dancingHandMenu;

    public GameObject floor;

    private bool freeze = false;
    private Vector3 initialLocalPos;
    private Vector3 offset;
    private Transform pokeAttachTransform;
    private XRBaseInteractable interactable;
    private bool isFollowing = false; 

    // Start is called before the first frame update
    void Start()
    {
        initialLocalPos = visualTarget.localPosition;
        interactable = GetComponent<XRBaseInteractable>();
        interactable.hoverEntered.AddListener(Follow);
        interactable.hoverExited.AddListener(ResetHover);
        interactable.selectEntered.AddListener(Freeze);
    }

    public void Follow(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor)
        {
            XRPokeInteractor interactor = (XRPokeInteractor)hover.interactorObject;

            pokeAttachTransform = interactor.attachTransform;
            offset = visualTarget.position - pokeAttachTransform.position;

            float pokeAngle = Vector3.Angle(offset, visualTarget.TransformDirection(localAxis));

            if(pokeAngle < followAngleThreshold)
            {
                isFollowing = true;
                freeze = false;
            }
        }
    }

    public void ResetHover(BaseInteractionEventArgs hover)
    {
        if(hover.interactorObject is XRPokeInteractor)
        {
            isFollowing = false;
            freeze = false;
        }
    }

    public void Freeze(BaseInteractionEventArgs hover)
    {
        if (hover.interactorObject is XRPokeInteractor)
        {
            freeze = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (freeze)
        {
            if (transform.parent.gameObject.tag == "PaintingGameButton")
            {
                StartPaintingTask();
                return;
            }
            else if (transform.parent.gameObject.tag == "FiveSensesButton")
            {
                StartFiveSenses();
                return;
            }
            else if (transform.parent.gameObject.tag == "BodyScanButton")
            {
                StartBodyScan();
                return;
            }
            else if (transform.parent.gameObject.tag == "MusicButton")
            {
                StartMusicListening();
                return;
            }
            else if (transform.parent.gameObject.tag == "DancingButton")
            {
                StartDancing();
                return;
            }
        }

        if (isFollowing)
        {
            Vector3 localTargetPosition = visualTarget.InverseTransformPoint(pokeAttachTransform.position + offset);
            Vector3 contrainedLocalTargetPosition = Vector3.Project(localTargetPosition, localAxis);
            visualTarget.position = visualTarget.TransformPoint(contrainedLocalTargetPosition);
        }else
        {
            visualTarget.localPosition = Vector3.Lerp(visualTarget.localPosition, initialLocalPos, Time.deltaTime * resetSpeed);
        }
    }

    void StartPaintingTask()
    {
        paintHandMenu.SetActive(true);
        sensesHandMenu.SetActive(false);
        bodyHandMenu.SetActive(false);
        musicHandMenu.SetActive(false);
        dancingHandMenu.SetActive(false);

        floor.SetActive(true);
        painting.SetActive(true);
        fiveSenses.SetActive(false);
        bodyScan.SetActive(false);
        dancingShaking.SetActive(false);
        musicListening.SetActive(false);
    }
    void StartFiveSenses()
    {
        paintHandMenu.SetActive(false);
        sensesHandMenu.SetActive(true);
        bodyHandMenu.SetActive(false);
        musicHandMenu.SetActive(false);
        dancingHandMenu.SetActive(false);

        painting.SetActive(false);
        fiveSenses.SetActive(true);
        floor.SetActive(false);
        bodyScan.SetActive(false);
        dancingShaking.SetActive(false);
        musicListening.SetActive(false);
    }    
    void StartBodyScan()
    {
        paintHandMenu.SetActive(false);
        sensesHandMenu.SetActive(false);
        bodyHandMenu.SetActive(true);
        musicHandMenu.SetActive(false);
        dancingHandMenu.SetActive(false);

        floor.SetActive(true);
        painting.SetActive(false);
        fiveSenses.SetActive(false);
        bodyScan.SetActive(true);
        dancingShaking.SetActive(false);
        musicListening.SetActive(false);
    }    
    void StartDancing()
    {
        paintHandMenu.SetActive(false);
        sensesHandMenu.SetActive(false);
        bodyHandMenu.SetActive(false);
        musicHandMenu.SetActive(false);
        dancingHandMenu.SetActive(true);

        floor.SetActive(true);
        painting.SetActive(false);
        fiveSenses.SetActive(false);
        bodyScan.SetActive(false);
        dancingShaking.SetActive(true);
        musicListening.SetActive(false);
    }    
    void StartMusicListening()
    {
        paintHandMenu.SetActive(false);
        sensesHandMenu.SetActive(false);
        bodyHandMenu.SetActive(false);
        musicHandMenu.SetActive(true);
        dancingHandMenu.SetActive(false);

        floor.SetActive(true);
        painting.SetActive(false);
        fiveSenses.SetActive(false);
        bodyScan.SetActive(false);
        dancingShaking.SetActive(false);
        musicListening.SetActive(true);
    }
}
