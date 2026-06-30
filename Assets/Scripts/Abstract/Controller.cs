using UnityEngine;
using UnityEngine.Events;
using YG;

public abstract class Controller : MonoBehaviour
{
    public UnityEvent onConsume;
    public UnityEvent onProduce;

    public abstract int Amount();

    public abstract void Produce(int amount);

    public abstract void Consume(int amount);
}
