import java.util.Arrays;
import java.util.Scanner;


public class SortArrayOfStrings {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		String[] strings = new String[a];
		
		for(int i = 0;i<a;i++){
			strings[i] = input.next();
		}
		Arrays.sort(strings);
		for(int i = 0;i<a;i++){
			System.out.println(strings[i]);
		}
	}

}