using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TrackCheckpoints : MonoBehaviour
{
    public event EventHandler<CarCheckpointEventArgs> OnCarCorrectCheckpoint;
    public event EventHandler<CarCheckpointEventArgs> OnCarWrongCheckpoint;

    [SerializeField] public List<Transform> carTransformList ;

    private List<int> nextCheckpointSingleIndexList; 
    private List<CheckpointSingle> checkpointSinglesList ;



    public class CarCheckpointEventArgs : EventArgs
    {
        public Transform carTransform; 
    }


    private void Awake()
    {
        checkpointSinglesList= new List<CheckpointSingle>() ;
        Transform checkpointsTransform = transform.Find("CheckPoints");

        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointSingleTransform.GetComponent<CheckpointSingle>();
            checkpointSingle.SetTrackCheckpoint(this);
  
            checkpointSinglesList.Add(checkpointSingle);
   
        }
        nextCheckpointSingleIndexList = new List<int>() ; 
        foreach ( Transform carTransform in carTransformList)
        {
            nextCheckpointSingleIndexList.Add(0); 
        }

    }

    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle, Transform carTransform )
    {
        int nextCheckpointSingleIndex = nextCheckpointSingleIndexList[carTransformList.IndexOf(carTransform)];
        if (checkpointSinglesList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex)
        {
            nextCheckpointSingleIndexList[carTransformList.IndexOf(carTransform)] =  (nextCheckpointSingleIndex + 1) % checkpointSinglesList.Count ;
            OnCarCorrectCheckpoint?.Invoke(this, new CarCheckpointEventArgs { carTransform = carTransform } );
        }
        else
        {
            OnCarWrongCheckpoint?.Invoke(this, new CarCheckpointEventArgs { carTransform = carTransform });

        }
    }

    public void ResetCheckpoint(Transform carTransform)
    {
        nextCheckpointSingleIndexList[carTransformList.IndexOf(carTransform)] = 0 ; 
    }

    public CheckpointSingle GetNextCheckpoint(Transform carTransform)
    {

        return checkpointSinglesList[nextCheckpointSingleIndexList[carTransformList.IndexOf(carTransform)]];
        //return carTransformList[carTransformList.IndexOf(carTransform)] ; 
    }

}
