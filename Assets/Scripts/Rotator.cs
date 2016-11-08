using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
    public int rotateSpeed = 3;
	
	void Update () {
        // deltaTime; time since game started ~ frames / second
        // in this way we aren't dependent on the processor speed
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime * rotateSpeed);
	}
}
