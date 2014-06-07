import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

/*Write a program that enters an array of strings and finds in it all sequences of equal elements. 
 The input strings are given as a single line, separated by a space.*/

public class _02SequencesOfEqualStrings {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] strings = scn.nextLine().split(" ");
		ArrayList<String> checked = new ArrayList<String>();
		for (int i = 0; i < strings.length; i++) {
			if (!checked.contains(strings[i])) {
				System.out.print(strings[i]);
				for (int p = 0; p < strings.length; p++) {
					if (p != i && strings[i].equals(strings[p])) {
						System.out.print(" " + strings[p]);
					}
				}
				checked.add(strings[i]);
				System.out.println();
			}
		}
	}
}