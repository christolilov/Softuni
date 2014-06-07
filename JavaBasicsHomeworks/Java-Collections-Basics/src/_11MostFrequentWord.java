import java.util.HashMap;
import java.util.Map.Entry;
import java.util.Scanner;
import java.util.TreeMap;
/*Write a program to find the most frequent word in a text and print it, as well as how many times it appears
in format "word -> count". Consider any non-letter character as a word separator. 
Ignore the character casing. If several words have the same maximal frequency, print all of them in 
alphabetical order.*/
public class _11MostFrequentWord {

	public static void main(String[] args) {
		Scanner scn = new Scanner(System.in);
		String[] words = scn.nextLine().toLowerCase().split("\\W+");
		TreeMap<String, Integer> word = new TreeMap<String, Integer>();
		int mostFrequent = 0;
		for(int i = 0;i<words.length;i++){
			int tempcount = 0;
			for(int p = 0;p<words.length;p++){
				if(words[i].equals(words[p])){
					tempcount++;
				}
			}
			if(tempcount>mostFrequent){
				mostFrequent=tempcount;
			}
			word.put(words[i], tempcount);
		}
		
		for(Entry<String, Integer> entry : word.entrySet()){
			int value = entry.getValue();
			String key = entry.getKey();
			if(value==mostFrequent){
				System.out.printf("%s -> %d times%n",key,value);
			}
		}
		
	}
}
