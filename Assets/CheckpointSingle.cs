using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSingle : MonoBehaviour
{
    public TrackCheckpoints trackCheckpoints; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Agent") {
            trackCheckpoints.PlayerThroughCheckpoint(this, other.transform);
        }
    }

    public void SetTrackCheckpoint(TrackCheckpoints trackCheckpoints)
    {
        this.trackCheckpoints = trackCheckpoints; 
    }
}
