leap
====


Would like to build a gesture library for the leap with the following API:

```
static void Main(string[] args)
{
    GestureListener listener = new GestureListener(1500);
    listener.onGesture += listener_onGesture;
    Controller controller = new Controller(listener);

    Console.ReadLine();
    Console.WriteLine("finished?"); // just making sure
    Console.ReadLine();

    controller.RemoveListener(listener);
    controller.Dispose();
}
```






## Supported Gestures


### Finger Swipe (4,3,2,1 Fingers)

### Photo Frame

- start
- stop
- scale



### Grab and Move

- capture moving into a fist, then capture moving around


### Handle Bars

- tow fists / move and rotate


### Gun

- gun and gun shoot


### Flat hand + Rotation

  - tilt right, left, up, down, rotate, etc


### Spreading of Hand













