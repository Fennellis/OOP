// Задача: Создание класса "Товар"

// Создайте класс Product для представления товара в интернет-магазине. Каждый товар должен иметь следующие характеристики:

// Название товара (name).
// Цена товара (price).
// Количество товара в наличии (quantity).
// Класс Product должен обеспечивать следующую функциональность:

// Конструктор, который принимает название, цену и количество товара и инициализирует соответствующие поля класса.
// Методы get и set для каждой из характеристик товара (название, цена, количество).
// Метод calculateTotalPrice, который будет вычислять общую стоимость товара на основе цены и количества.
// Метод displayProductInfo, который будет выводить информацию о товаре (название, цена, количество) на экран.
// Создайте несколько объектов класса Product и продемонстрируйте работу методов.

public class main {
    public static void main(String[] args) {
        Product product = new Product("Груша", 30.5, 7);

        product.displayProductInfo();
        System.out.println(calculateTotalPrice(product));
    }

    public static double calculateTotalPrice(Product product){
        return product.getPrice() * product.getQuantity();
    }
}
