import java.util.Scanner;

import com.sun.org.apache.bcel.internal.generic.GOTO;


public class FormattingNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		double b = input.nextDouble();
		double c = input.nextDouble();
        System.out.printf("|%-10X|%010d|%10.2f|%-10.3f|%n", a, Integer.parseInt(Integer.toBinaryString(a)), b, c);
    }
}
