using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragDropable : MonoBehaviour
{
    //you can embed InputAction (and InputActionMap) directly in your MonoBehaviour scripts
    [SerializeField] private InputAction press, screenPos;

    private Vector3 curScreenPos;

    Camera camera;

    private bool isDragging;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;

        //you must manually enable and disable your embedded InputAction
        screenPos.Enable();
        press.Enable();

        //whenever screenPos is performed (aka mouse position changed), we get callback context
        //from that event and set curScreenPos to the mouse position from InputAction
        screenPos.performed += context => { curScreenPos = context.ReadValue<Vector2>(); };
        press.performed += _ => { if (isClickedOn) StartCoroutine(Drag()); };
        press.canceled += _ => { isDragging = false; };
    }

    private bool isClickedOn
    {
        //'get' is a property that allows you to expose data from a type that looks
        //like a field when you access it, but acts like a pair of functions such 
        //that 'get' is used whenever isClickedOn is read from, and 'set' is used
        //whenever you assign something to isClickedOn
        get
        {
            Ray ray = camera.ScreenPointToRay(curScreenPos);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            if (hit.collider != null)
            {
                return hit.transform == transform;
            }
            return false;
        }
    }

    private Vector3 WorldPos
    {
        get
        {
            //get depth that is object is from camera
            float z = camera.WorldToScreenPoint(transform.position).z;
            //get world space of object
            return camera.ScreenToWorldPoint(curScreenPos + new Vector3(0, 0, z));
        }
    }

    private IEnumerator Drag()
    {
        isDragging = true;
        Vector3 offset = transform.position - WorldPos;
        //grab
        while (isDragging)
        {
            //dragging
            transform.position = WorldPos + offset; //to prevent object from snapping to mouse
            yield return null;
        }
        //drop
    }

    // Update is called once per frame
    void Update()
    {

    }
}
