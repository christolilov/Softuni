import java.io.FileReader;
import java.util.ArrayList;
import java.util.Scanner;

public class OrderOfProducts {
	public static void main(String[] args) throws Exception {
		ArrayList<Product> products = new ArrayList<Product>();
		try (Scanner input = new Scanner(new FileReader("Products.txt"))) {
			while (input.hasNextLine()) {
				products.add(new Product(input.next(), input.nextDouble()));
			}
		}
		double totalPrice = 0;
		try (Scanner input = new Scanner(new FileReader("Order.txt"))) {
			while (input.hasNextLine()) {
				String[] values = input.nextLine().split(" ");
				Double quantity = Double.parseDouble(values[0]);
				for (Product product : products) {
					if(values[1].equals(product.getName())){
						totalPrice+= quantity*product.getPrice();
					}
				}
			}
		}
		System.out.println(totalPrice);
	}

}
