import java.util.Scanner;
//Write a program to count the number of words in given sentence. Use any non-letter character as word separator.
public class _05CountAllWords {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] words = scn.nextLine().split("\\W+");
		System.out.println(words.length);
	}

}
