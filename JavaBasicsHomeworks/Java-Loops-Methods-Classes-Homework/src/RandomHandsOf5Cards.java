import java.util.Random;
import java.util.Scanner;

public class RandomHandsOf5Cards {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		int numberOfHands = scn.nextInt();
		String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K","A"};
		String[] faces = {"♣", "♦", "♥", "♠" };
		String[] newCards = new String[52];
		int s = 0;
		for(int p = 0;p<13;p++){
			for (String face : faces) {
				String str = "";
				str+=cards[p];
				str+=face;
				newCards[s]=str;
				s++;
			}
		}
		Random rnd = new Random();
		for(int i = 0;i<numberOfHands;i++){
			
				System.out.printf("%s %s %s %s %s%n",newCards[rnd.nextInt(51)],newCards[rnd.nextInt(51)],newCards[rnd.nextInt(51)],newCards[rnd.nextInt(51)],newCards[rnd.nextInt(51)]);
		}
	}

}