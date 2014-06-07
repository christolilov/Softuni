import java.text.DecimalFormat;
import java.util.Scanner;


public class SmallestOfThreeNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double a = Double.parseDouble(input.nextLine());
		double b = Double.parseDouble(input.nextLine());
		double c = Double.parseDouble(input.nextLine());
		double smallest = 0;
        DecimalFormat format = new DecimalFormat();
        format.setDecimalSeparatorAlwaysShown(false);


		if(b<c){
			smallest = Math.min(a, b);
		}
		else {
			smallest = Math.min(a, c);
		}
		System.out.println( format.format(smallest));


	}

}
