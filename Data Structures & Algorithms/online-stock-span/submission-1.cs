public class StockSpanner {
    Stack<(int span, int price)> stack;
    public StockSpanner() {
        stack = new Stack<(int span, int price)>();
    }
    
    public int Next(int price) {
        int res = 1;
        while(stack.Count > 0 && stack.Peek().price <= price)
            res += stack.Pop().span;
        stack.Push((res, price));
        return res;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */