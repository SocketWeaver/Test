using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWNetwork;

public class TestSpawner : MonoBehaviour
{
    public void OnSpawnerReady(bool alreadySetup, SceneSpawner sceneSpawner)
    {
        Debug.Log("OnSpawnerReady " + alreadySetup);

        if (!alreadySetup)
        {
            if (NetworkClient.Instance.IsHost)
            {
                GameObject go = sceneSpawner.SpawnForPlayer(0, 0);

                Debug.Log("OnSpawnerReady created GameObject" + go.name);
            }
            else
            {
                GameObject go = sceneSpawner.SpawnForPlayer(0, 1);

                Debug.Log("OnSpawnerReady created GameObject" + go.name);
            }


            sceneSpawner.PlayerFinishedSceneSetup();
        }
    }
}
