import java.util.Scanner;

/*Write a program to find how many times a word appears in given text. 
The text is given at the first input line. 
The target word is given at the second input line. 
The output is an integer number. Please ignore the character casing. 
Consider that any non-letter character is a word separator. */

public class _06CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] words = scn.nextLine().toLowerCase().split("\\W+");
		String word = scn.nextLine().toLowerCase();
		int count = 0;
		for(int i = 0;i<words.length;i++){
			if(words[i].equals(word)){
				count++;
			}
		}
		System.out.println(count);
	}

}
