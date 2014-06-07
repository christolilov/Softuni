import java.util.Scanner;

public class RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] sides = input.nextLine().split(" ");
		int sideA = Integer.parseInt(sides[0]);
		int sideB = Integer.parseInt(sides[1]);
		int area = sideA * sideB;
		System.out.println(area);

	}

}
