using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class spaceBetween : MonoBehaviour
{
    ARTrackedImageManager m_TrackedImageManager;
    Animator m_Animator;
    private List<Vector3> allPos;
    private List<GameObject> objects;

    void spaceCalculator(){
        if( m_TrackedImageManager.trackables.count >+ 0){
            foreach(var trackedImage in m_TrackedImageManager.trackables) {
                allPos.Add(trackedImage.transform.position);
                objects.Add(trackedImage.GetComponentInChildren<GameObject>());    
            }
            if( (allPos[0].x - allPos[1].x) <= 0.15 || (allPos[0].y - allPos[1].y) <= 0.15 ) {
                foreach( var obj in objects) {
                   obj.GetComponent<Animator>().enabled = true;
                }
            } else{
                foreach( var obj in objects) {
                    obj.GetComponent<Animator>().enabled = false;
                }
            }
        }
    }
}
