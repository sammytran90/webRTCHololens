using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class MoveScript : MonoBehaviour, IManipulationHandler, IInputClickHandler
{
    public Material material;
    private LineRenderer lineRenderer;
    private int counter = 0;
    private float dist;
    public float lineDrawSpeed = 6f;

    [SerializeField]
    float DragSpeed = 5f;

    [SerializeField]
    float DragScale = 5f;

    [SerializeField]
    float MaxDragDistance = 50f;

    Vector3 lastPosition;

    [SerializeField]
    bool draggingEnabled = true;
    public void SetDragging(bool enabled)
    {
        draggingEnabled = enabled;
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        InputManager.Instance.PushModalInputHandler(gameObject);
        lastPosition = transform.position;
        //Debug.Log("X " + lastPosition.x + " Y " + lastPosition.y + " Z " + lastPosition.z + " X1 " + lastPosition.x + " Y1" + lastPosition.y + " Z1 " + lastPosition.z);

    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        if (draggingEnabled)
        {
            Drag(eventData.CumulativeDelta);

            //sharing & messaging
            //SharingMessages.Instance.SendDragging(Id, eventData.CumulativeDelta);
        }
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        InputManager.Instance.PopModalInputHandler();

    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        InputManager.Instance.PopModalInputHandler();
    }

    void Drag(Vector3 positon)
    {
        var targetPosition = lastPosition + positon * DragScale;
        if (Vector3.Distance(lastPosition, targetPosition) <= MaxDragDistance)
        {


            transform.position = Vector3.Lerp(transform.position, targetPosition, DragSpeed);

            //GameObject MyObject = Resources.Load("Line") as GameObject;
            //GameObject go = Instantiate(MyObject) as GameObject;
            //go.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //go.transform.localScale = new Vector3(0.07f, 0.07f, 0.07f);

             //Debug.Log("X "+ targetPosition.x+" Y "+targetPosition.y+ " Z "+ targetPosition.z +" X1 "+ targetPosition.x+" Y1"+ targetPosition.y+" Z1 "+ targetPosition.z);

        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        transform.position = lastPosition;
    }

}
