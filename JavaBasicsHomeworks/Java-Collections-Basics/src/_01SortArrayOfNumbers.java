import java.util.Arrays;
import java.util.Scanner;

/*Write a program to enter a number n and n integer numbers and sort and print them. 
Keep the numbers in array of integers: int[]. */

public class _01SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int n = scn.nextInt();
		int[] numbers = new int[n];
		for (int i = 0; i < n; i++) {
			numbers[i]=scn.nextInt();
		}
	Arrays.sort(numbers);
	for (int i : numbers) {
		System.out.println(i+" ");
	}
	}

}
