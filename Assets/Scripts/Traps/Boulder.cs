using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NavMeshAgent))]
public class Boulder : MonoBehaviour {

    public enum Direction { UNDEFINED, NORTH, EAST, SOUTH, WEST }

    public float minSpeed = 3.5f;
    public float acceleration = 0.1f;

    private NavMeshAgent agent;
    private Player player;

    private Vector3 oldPos = new Vector3(0f, 0f, 0f);
    private Direction direction = Direction.UNDEFINED;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
        agent = GetComponent<NavMeshAgent>();        
        agent.speed = minSpeed;
        //oldYRot = transform.rotation.y;
    }
	
	// Update is called once per frame
	void Update () {
        agent.destination = player.transform.position;
        agent.speed += acceleration;
        if (DirectionChanged())
            ResetSpeed();
    }

    bool DirectionChanged() {
        Vector3 currPos = transform.position;
        Vector2 resultVector = new Vector2(currPos.x - oldPos.x, currPos.z - oldPos.z);

        float rotation = (float)(Mathf.Atan2(resultVector.x, resultVector.y) / (2 * Mathf.PI));
        oldPos = currPos;
        float errorMargin = 0.125f;
        if        (direction != Direction.NORTH && (rotation > (0.5f - errorMargin) || rotation < (-0.5 + errorMargin))) {
            direction = Direction.NORTH;
        } else if (direction != Direction.EAST && rotation > (-0.25 - errorMargin) && rotation < (-0.25 + errorMargin)) {
            direction = Direction.EAST;
        } else if (direction != Direction.SOUTH && rotation > (0 - errorMargin) && rotation < (0 + errorMargin)) {
            direction = Direction.SOUTH;
        } else if (direction != Direction.WEST && rotation > (0.25 - errorMargin) && rotation < (0.25 + errorMargin)) {
            direction = Direction.WEST;
        } else {
            //Debug.Log(rotation);
            return false;
        }
        //Debug.Log(rotation);
        //Debug.Log(direction);
        return true;
    }

    void ResetSpeed() {
        agent.speed = minSpeed;
    }
}
