import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

/*Write a program that enters an array of strings and finds in it the largest sequence of equal elements. 
If several sequences have the same longest length, print the leftmost of them. 
The input strings are given as a single line, separated by a space. */

public class _03LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] strings = scn.nextLine().split(" ");
		int largestSequence = 0;
		int largestString = 0;

		for (int i = 0; i < strings.length; i++) {
			int tempcount = 0;
			for (int p = 0; p < strings.length; p++) {
				if (strings[i].equals(strings[p])) {
					tempcount++;
				} else {
					break;
				}
			}
			if (tempcount > largestSequence) {
				largestString = i;
				largestSequence = tempcount;
			}
		}

		for (int i = 0; i < largestSequence; i++) {
			System.out.print(strings[largestString] + " ");
		}
	}
}