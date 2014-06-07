import java.util.Scanner;

/*Write a program to find all increasing sequences inside an array of integers. 
The integers are given in a single line, separated by a space. 
Print the sequences in the order of their appearance in the input array, each at a single line. 
Separate the sequence elements by a space. Find also the longest increasing sequence and print it at 
the last line. If several sequences have the same longest length, print the leftmost of them. */

public class _04LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] numbers = scn.nextLine().split(" ");
		int[] integers = new int[numbers.length];
		int longestIndex = 0;
		int longestCount = 1;
		for (int i = 0;i<numbers.length;i++) {
			integers[i]=Integer.parseInt(numbers[i]);
		}
		for(int i = 0;i<integers.length-1;i++){
			int tempcount = 1;
			if(integers[i]>=integers[i+1]){
				System.out.println(integers[i]);
			}
			else{
				System.out.print(integers[i]+" ");
				tempcount++;
				longestIndex=i;
			}
			if(tempcount>longestCount){
				longestCount=tempcount;
				longestIndex=i;
			}
		}
		if(integers[integers.length-1]>integers[integers.length-2]){
			System.out.print(integers[integers.length-1]);
		}
		else{
			System.out.println(integers[integers.length-1]);
		}
		System.out.println();
		System.out.print("Longest:");
		for(int i = 0,p = longestIndex-longestCount-1;i<longestCount;i--,p++){
			System.out.print(integers[p]+" ");
		}
		System.out.println();
	}

}
