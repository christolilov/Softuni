import java.util.Scanner;


public class CountOfBitsOne {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		int mask = 1;
		int count = 0;
		for(int i = 0;i<32;i++){
			if((mask<<i & number)>0){
				count++;
			}
		}
		System.out.println(count);

	}

}
