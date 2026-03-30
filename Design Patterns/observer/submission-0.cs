public interface IObserver {
    void notify(string itemName);
}

public class Customer : IObserver {
    private string name;
    private int notifications;

    public Customer(string name) {
        this.name = name;
        this.notifications = 0;
    }

    public string getName() {
        return this.name;
    }

    public void notify(string itemName) {
        this.notifications += 1;
    }

    public int countNotifications() {
        return this.notifications;
    }
}

public class OnlineStoreItem {
    private string itemName;
    private int stock;
    HashSet<IObserver> customers;

    public OnlineStoreItem(string itemName, int stock) {
        this.itemName = itemName;
        this.stock = stock;
        customers = new HashSet<IObserver>();
    }

    public void subscribe(IObserver observer) {
        customers.Add(observer);
    }

    public void unsubscribe(IObserver observer) {
        if(customers.Contains(observer))
            customers.Remove(observer);
    }

    public void updateStock(int newStock) {
        if(stock == 0)
        {
            foreach (var v in customers)
                v.notify(this.itemName);
        }

        stock = newStock;
    }
}
