// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;

public class translateCube : MonoBehaviour
{
    [SerializeField] private float distance;

    [SerializeField] private float XSpeed;


    // Update() is called once *per frame*. It is called *after* the Start()
    // method, which is only called once when the component is enabled for the
    // first time. You'll find that the execution order of these lifecycle
    // methods matters, and this can be fairly nuanced when components reference
    // each other, and/or if you are enabling and disabling components at
    // runtime.
    //
    // Recommended reading:
    // - https://docs.unity3d.com/Manual/ExecutionOrder.html
    private void Update()
    {
        var PongPos = Mathf.PingPong(Time.time, distance);


        this.transform.localPosition = new Vector3(PongPos, 0.0f, 0.0f);
    }
}
