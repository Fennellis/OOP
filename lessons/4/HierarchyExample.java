import java.util.ArrayList;
import java.util.List;

class A {}
class B extends A {}
class C extends B {}
class D extends C {}
class E extends D {}

class F extends E {}

class G extends F {}

class H extends G {}

class I extends H {}

class J extends I {}
public class HierarchyExample {
    // Метод, демонстрирующий использование extends
    public static <T extends B> void processExtends(List<T> list) {
        // Тут можно читать из списка, но добавление ограничено типом T и его подклассами
        for (T item : list) {
            System.out.println("Обработка: " + item.getClass().getSimpleName());
        }
    }

    // Метод, демонстрирующий использование super
    public static <T super C> void processSuper(List<? super C> list, C newItem) {
        // Тут можно добавлять элементы в список
        list.add(newItem);
        System.out.println("Добавлен элемент: " + newItem.getClass().getSimpleName());
    }

    public static void main(String[] args) {
        List<C> listExtends = new ArrayList<>();
        listExtends.add(new C());
        listExtends.add(new D()); // D наследуется от C
        processExtends(listExtends);

        List<A> listSuper = new ArrayList<>();
        processSuper(listSuper, new C());
    }
}

