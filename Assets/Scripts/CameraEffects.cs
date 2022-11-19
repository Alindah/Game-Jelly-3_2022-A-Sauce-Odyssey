using System.Collections;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{

  public static Vector3 RandomCameraPosition()
  {
    int randomX = Random.Range(-2, 2);
    int randomY = Random.Range(-2, 2);
    return new Vector3(randomX, randomY, -10);
  }

  public static IEnumerator ShakeCamera(Camera camera, int duration)
  {
    Vector3 initialCameraPos = new Vector3(
        camera.transform.position.x,
        camera.transform.position.y,
        camera.transform.position.z
    );
    Quaternion initialCameraRotation = camera.transform.rotation;
    WaitForSeconds wait = new WaitForSeconds(0.5f);
    int loopCount = 0;


    while (true)
    {
      if (loopCount >= duration)
      {
        break;
      }

      Vector3 cameraPos = RandomCameraPosition();
      Quaternion cameraRotation = new Quaternion();
      camera.transform.SetPositionAndRotation(cameraPos, cameraRotation);

      loopCount++;
      yield return wait;
    }

    Debug.Log(initialCameraPos);

    // reset camera
    camera.transform.SetPositionAndRotation(initialCameraPos, initialCameraRotation);
  }
}
