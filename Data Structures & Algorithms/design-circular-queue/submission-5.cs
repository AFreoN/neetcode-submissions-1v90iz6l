public class MyCircularQueue {
        int capacity, size, head, tail;
        int[] queue;
        public MyCircularQueue(int k)
        {
            capacity = k;
            size = 0;
            queue = new int[capacity];
        }

        public bool EnQueue(int value)
        {
            if (size >= capacity) return false;
            queue[tail] = value;
            tail = (tail + 1) % capacity;
            size++;
            return true;
        }

        public bool DeQueue()
        {
            if(size <= 0) return false;
            head = (head + 1) % capacity;
            size--;
            return true;
        }

        public int Front()
        {
            if (size == 0) return -1;
            return queue[head];
        }

        public int Rear()
        {
            if (size == 0) return -1;
            return queue[(tail - 1 + capacity) % capacity];
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return size == capacity;
        }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */