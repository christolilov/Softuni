import java.util.HashMap;
import java.util.Scanner;
import java.util.Map.Entry;

/*We are given a sequence of N playing cards from a standard deck. 
The input consists of several cards (face + suit), separated by a space. 
Write a program to calculate and print at the console the frequency of each card face in format 
"card_face -> frequency". The frequency is calculated by the formula appearances / N and is expressed 
in percentages with exactly 2 digits after the decimal point. The card faces with their frequency should 
be printed in the order of the card face's first appearance in the input. The same card can appear multiple
times in the input, but it's face should be listed only once in the output.
*/

public class _12CardsFrequencies {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] cards = scn.nextLine().split("\\W+");
		HashMap<String, Integer> card = new HashMap<String, Integer>();
		for(int i = 0;i<cards.length;i++){
			int tempcount = 0;
			for(int p = 0;p<cards.length;p++){
				if(cards[i].charAt(0)==cards[p].charAt(0)){
					tempcount++;
				}
			}
			String str = "";
			str+=cards[i].charAt(0);
			if(cards[i].contains("0")){
				str+=cards[i].charAt(1);
			}
			card.put(str, tempcount);
		}
		for(Entry<String, Integer> entry : card.entrySet()){
			double value = entry.getValue();
			String key = entry.getKey();
			double percentage = value/cards.length*100;
			System.out.printf("%s -> %.2f%s\n",key,percentage,"%");
		}
	}

}
