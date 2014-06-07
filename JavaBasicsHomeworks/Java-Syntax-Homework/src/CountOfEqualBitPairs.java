import java.util.Scanner;


public class CountOfEqualBitPairs {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		int mask = 3;
		int count = 0;
		int leftmost =0;
		if(number!=0){
			for(int i = 0;i<32;i++){
				if((number&1<<i)>0)
				{
					leftmost = i;
				}
			}
			for(int i = 0;i<=leftmost;i++){
				if(((mask<<i&number)>>i)==3){
					count++;
				}
				else if(((mask<<i&~number)>>i)==3){
					count++;
				}
			}
			System.out.println(count);
		}
		else {
			System.out.println(0);
		}
	}

}
