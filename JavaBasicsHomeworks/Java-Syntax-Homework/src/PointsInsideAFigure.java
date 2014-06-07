import java.util.Scanner;


public class PointsInsideAFigure {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] points = input.nextLine().split(" ");
		double x = Double.parseDouble(points[0]);
		double y = Double.parseDouble(points[1]);
		if((x>=12.5 && x<=17.5) && (y<=13.5 && y>=6)){
			System.out.println("Inside");
		}
		else if((x>=12.5 && x<=22.5) && (y<=8.5 && y>=6)) {
			System.out.println("Inside");
		}
		else if((x>=20 && x<=22.5) && (y<=13.5 && y>=6)) {
			System.out.println("Inside");
			
			
		}
		else {
			System.out.println("Outside");
		}
		
	}

}
