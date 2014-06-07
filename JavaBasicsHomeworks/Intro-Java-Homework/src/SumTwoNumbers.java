import java.util.Scanner;


public class SumTwoNumbers {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		System.out.print("Enter number a: ");
		int a = input.nextInt();
		System.out.print("Enter number b: ");
		int b = input.nextInt();
		System.out.print("The result a+b = ");
		System.out.println(a+b);

	}

}
