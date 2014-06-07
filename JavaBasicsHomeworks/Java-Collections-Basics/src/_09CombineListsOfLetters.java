import java.util.ArrayList;
import java.util.Scanner;

/*  Write a program that reads two lists of letters l1 and l2 and combines them: 
	appends all letters c from l2 to the end of l1, but only when c does not appear in l1. 
	Print the obtained combined list. 
	All lists are given as sequence of letters separated by a single space, each at a separate line. 
	Use ArrayList<Character> of chars to keep the input and output lists.*/

public class _09CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		ArrayList<Character> arr1 = new ArrayList<Character>();
		ArrayList<Character> arr2 = new ArrayList<Character>();
		for (char ch : scn.nextLine().toCharArray()) {
			if(ch!=' ')
				arr1.add(ch);
		}
		for (char ch : scn.nextLine().toCharArray()) {
			if(ch!=' ')
				arr2.add(ch);
		}
		for(char ch: arr2){
			if(!arr1.contains(ch)){
				arr1.add(ch);
			}
		}
		System.out.println(arr1);
	}
}
