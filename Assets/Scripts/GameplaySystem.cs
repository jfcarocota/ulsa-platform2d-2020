namespace Platform2DUtils.GameplaySystem
{
    using UnityEngine;

    public class GameplaySystem
    {
        ///<summary>
        /// Returns a Vector2 with Horizontal and Vertical axes.
        ///</summary>
        public static Vector2 Axis
        {
            get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }

        public static void TMovement(Transform t, float moveSpeed)
        {
            t.Translate(Vector2.right * moveSpeed);
        }

        public static void TMovementDelta(Transform t, float moveSpeed)
        {
            t.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }
}