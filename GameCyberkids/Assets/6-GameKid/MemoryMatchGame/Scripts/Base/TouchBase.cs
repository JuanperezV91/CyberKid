using UnityEngine;
using System.Collections;

///<summary>
/// Abstract class to handle user input
///</summary>
public abstract class InputBase : MonoBehaviour
{
    [HideInInspector]
    //can proceed an ection
    public int canDo;

	///<summary>
	/// Set input state to false
	///</summary>
    public abstract void SetFalse();
	
	///<summary>
	/// Handle left mouse or touch
	///</summary>
    public abstract void OnMouseUp();
}
