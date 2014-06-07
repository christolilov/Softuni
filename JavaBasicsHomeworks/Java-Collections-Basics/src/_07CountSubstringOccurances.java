import java.util.Scanner;

/*Write a program to find how many times given string appears in given text as substring. 
The text is given at the first input line. The search string is given at the second input line. 
The output is an integer number. Please ignore the character casing. */

public class _07CountSubstringOccurances {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String str = scn.nextLine().toLowerCase();
		String findStr = scn.nextLine().toLowerCase();
		int count =0;
		for(int i = 0;i<str.length()-findStr.length()+1;i++){
			if(str.substring(i, i+findStr.length()).equals(findStr)){
				count++;
			}
		}
		System.out.println(count);
	}
}