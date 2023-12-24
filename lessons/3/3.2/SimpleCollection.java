import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class SimpleCollection<T> implements Iterable<T> {
    private List<T> items;

    public SimpleCollection() {
        this.items = new ArrayList<>();
    }

    public void add(T item) {
        items.add(item);
    }

    @Override
    public Iterator<T> iterator() {
        return items.iterator();
    }
}