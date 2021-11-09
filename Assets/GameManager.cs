using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Field _field = new Field(10, 10);

    public Field Field => _field;
}
