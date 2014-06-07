import java.util.Scanner;

public class SymmetricNumbersInRange {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int start = scn.nextInt();
		int end = scn.nextInt();
		for (int i = start; i <= end; i++) {
			char[] digits = Integer.toString(i).toCharArray();
			Boolean symmetric = false;
			for (int p = 0; p < digits.length / 2; p++) {
				if (digits[p] == digits[digits.length - p - 1]) {
					symmetric = true;
				} else {
					symmetric = false;
				}
			}
			if (symmetric) {
				System.out.println(i);
			}
		}
	}
}
