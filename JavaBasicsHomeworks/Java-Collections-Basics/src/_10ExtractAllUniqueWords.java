import java.util.ArrayList;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

/*At the first line at the console you are given a piece of text. 
Extract all words from it and print them in alphabetical order. 
Consider each non-letter character as word separator. Take the repeating words only once. 
Ignore the character casing. Print the result words in a single line, separated by spaces. */

public class _10ExtractAllUniqueWords {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] words = scn.nextLine().toLowerCase().split("\\W+");
		TreeSet<String> set = new TreeSet<>();
		for (String word : words) {
			set.add(word);
		}
		System.out.println(set);
	}
}
