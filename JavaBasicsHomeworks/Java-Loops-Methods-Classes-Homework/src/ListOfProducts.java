import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
 
public class ListOfProducts {
 
        public static void main(String[] args) throws Exception {
                ArrayList<Product> products = new ArrayList<Product>();
                try (Scanner input = new Scanner(new FileReader("Products.txt"))) {                      
                        while (input.hasNextLine()) {
                                products.add(new Product(input.next(), input.nextDouble()));
                        }                              
                }
                Collections.sort(products);
                try (BufferedWriter output = new BufferedWriter(new FileWriter("Output.txt"))) {
                        for (Product product : products) {
                                output.write(String.format("%.2f %s", product.getPrice(), product.getName()));
                                output.newLine();
                        }
                }
        }
}