using System.Collections;
using UnityEngine;
using System.Threading.Tasks;

public class CameraEffects : MonoBehaviour
{

  private static Vector3 RandomCameraPosition()
  {
    int randomX = Random.Range(-2, 2);
    int randomY = Random.Range(-2, 2);
    return new Vector3(randomX, randomY, -10);
  }

  public static async void ShakeCamera(Camera camera, float duration, Vector3 initialCameraPos)
  {
    Quaternion initialCameraRotation = camera.transform.rotation;

    float end = Time.time + duration;

    while (Time.time < end)
    {
      Vector3 cameraPos = RandomCameraPosition();
      Quaternion cameraRotation = new Quaternion();
      camera.transform.SetPositionAndRotation(cameraPos, cameraRotation);
      await Task.Yield();
    }

    // reset camera to its original position
    camera.transform.SetPositionAndRotation(initialCameraPos, initialCameraRotation);
  }

}
