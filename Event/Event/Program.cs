using System;

namespace Event
{
    class Event
    {
        public static int counter = 0;

        public delegate void EventDelegate(string msg);

        public EventDelegate eventPublisher;

        public int printNumber(string msg)
        {
            if (eventPublisher != null)
            {
                eventPublisher(msg);
            }

            return (++counter);
        }

    }
}
