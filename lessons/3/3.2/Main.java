import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        // List<String> names = new ArrayList<>();
        // names.add("Alice");
        // names.add("Bob");
        // names.add("Charlie");
        // names.add("Diana");
        // // Список теперь содержит ["Alice", "Bob", "Charlie", "Diana"]
        // // Получаем итератор для списка
        // Iterator<String> iterator = names.iterator();

        // // Перебираем элементы списка
        // while (iterator.hasNext()) {
        //     String name = iterator.next();
        //     System.out.println(name);
        // }

        SimpleCollection<String> myCollection = new SimpleCollection<>();

        myCollection.add("Apple");
        myCollection.add("Banana");
        myCollection.add("Cherry");

        for (String fruit : myCollection) {
            System.out.println(fruit);
        }      
    }
}
