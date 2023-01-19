using System.Collections;
using System.Threading;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerLife : MonoBehaviour
{
// how mush life the player has
  private float Life = 100f;
  //private float frame = 0f;

  [SerializeField] private Rigidbody2D rb;
  [SerializeField] private Transform pushbackCheker;
  [SerializeField] private LayerMask pushback;

    private void FixedUpdate()
    {
        if(pushbackplayer())
        {
          // if player gets hit remove 10 form player helth.
          Life = Life - 10;
          // how mush life is left for the player
          Debug.Log(Life);
          // if player hits 0 helth
          if (Life <= 0)
          {
            // Destroy object named player (there is a way to set it up so that is tags or layers that gets Destroy)
            Destroy(GameObject.Find("Player"));

            
          //  while(frame <= 3000000)
        //    {
            //  frame = frame + 1;
            //}
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          }
        }
    }
    private bool pushbackplayer()
    {
      // if player gets hit.
        return Physics2D.OverlapCircle(pushbackCheker.position, 0.2f, pushback);
    }
}
