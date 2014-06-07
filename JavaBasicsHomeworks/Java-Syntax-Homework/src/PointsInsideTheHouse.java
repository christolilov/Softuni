import java.util.Scanner;


public class PointsInsideTheHouse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] vars = input.nextLine().split(" ");
		int x = Integer.parseInt(vars[0]);
		int y = Integer.parseInt(vars[1]);			
		double x1 = 12.5, y1 = 8.5;
		double x2 = 17.5, y2 = 3.5;
		double x3 = 22.5, y3 = 8.5;
		double ABC = Math.abs (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
		double ABP = Math.abs (x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2));
		double APC = Math.abs (x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y));
		double PBC = Math.abs (x * (y2 - y3) + x2 * (y3 - y) + x3 * (y - y2));
		boolean isInTriangle = ABP + APC + PBC == ABC;
		if((x>=12.5 && x<=17.5) && (y<=13.5 && y>=8.5)) {
			System.out.println("Inside");
		}
		else if((x>=20 && x<=22.5) && (y<=13.5 && y>=8.5)) {
			System.out.println("Inside");
		}

	    else if(isInTriangle){
			System.out.println("Inside");
		}
	    else {
	    	System.out.println("Outside");
	    }
	}
}
