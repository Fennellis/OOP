import java.util.Arrays;
import java.util.List;
import java.util.function.Consumer;
import java.util.function.Predicate;

public class Main {
    public static void main(String[] args) {
        MathOperation addition = (a, b) -> a + b;
        MathOperation multiplication = (a, b) -> a * b;

        System.out.println("Addition: " + addition.operate(5, 3));
        System.out.println("Multiplication: " + multiplication.operate(5, 3));

        // --------------------------------------------------

        // ConditionChecker isEven = n -> n % 2 == 0;
        // ConditionChecker isPositive = n -> n > 0;

        // System.out.println("Is 4 even? " + isEven.check(4));
        // System.out.println("Is -3 positive? " + isPositive.check(-3));

        // --------------------------------------------------

        Consumer<String> printConsumer = System.out::println;
        List<String> names = Arrays.asList("Alice", "Bob", "Charlie");

        names.forEach(printConsumer);

        // --------------------------------------------------

        Predicate<Integer> isPositive = x -> x > 0;

        System.out.println("Is 5 positive? " + isPositive.test(5));
        System.out.println("Is -5 positive? " + isPositive.test(-5));
    }
}