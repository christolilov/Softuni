import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Scanner;

public class ConvertDegreesRadians {

	public static void main(String[] args) {
		@SuppressWarnings("resource")
		Scanner scn = new Scanner(System.in);
		int n = Integer.parseInt(scn.next());
		ArrayList<Double> results = new ArrayList<Double>();
		for(int i = 0;i<n;i++){
			int number = scn.nextInt();
			String input = scn.nextLine();
			if(input.equals(" rad")){
				results.add(calculateRadians(number));
			}
			else if(input.equals(" deg")){
				results.add(calculateDegrees(number));
			}
		}
		for(int i = 0;i<n;i++){
			System.out.printf("%.6f%n",results.get(i));
		}
	}

	public static double calculateRadians(int number) {
		double result = number * 0.0174532925;
		return result;
	}
	
	public static double calculateDegrees(int number) {
		double result =number / 0.0174532925;
		return result;
	}

}
