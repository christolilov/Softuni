import java.net.*;
import java.util.Scanner;
import java.io.*;

/*A web crawler (web spider) is a program that crawls the web starting from a certain URL and passing to all 
its internal and external hyperlinks recursively until stopped, until reached something or up to certain 
predefined depth. Your task is to write a web crawler that starts from certain URL and crawls all URLs 
recursively up to n levels or until stopped. The number n (e.g. 2) and the starting URL are given as 
constants. All non-html documents should be ignored (e.g. images, CSS styles and scripts). Write all 
crawled URLs in a text file "crawled-urls.txt". Don't crawl the same URL more than once. 

*/public class _13WebCrawler {
	public static void main(String[] args) throws Exception {
		Scanner scn = new Scanner(System.in);
		System.out.print("Enter the start site(starting with http://): ");
		String url = scn.nextLine();
		System.out.print("How many urls should be crawled? :");
		int i = 0, j = 0, tmp = 0, total = 0, MAX = scn.nextInt();
		String urls[] = new String[MAX];
		int start = 0, end = 0;
		String webpage = Web.getWeb(url);
		end = webpage.indexOf("<body");
		for (i = total; i < MAX; i++, total++) {
			start = webpage.indexOf("http://", end);
			if (start == -1) {
				start = 0;
				end = 0;
				try {
					webpage = Web.getWeb(urls[j++]);
				} catch (Exception e) {
				}
				end = webpage.indexOf("<body");
				if (end == -1) {
					end = start = 0;
					continue;
				}
			}
			end = webpage.indexOf("\"", start);
			tmp = webpage.indexOf("'", start);
			if (tmp < end && tmp != -1) {
				end = tmp;
			}
			url = webpage.substring(start, end);
			urls[i] = url;
			System.out.println(urls[i]);
		}
		System.out.println("Total URLS Fetched are " + total);
	}
}

class Web {
	public static String getWeb(String address) throws Exception {
		String webpage = "";
		String inputLine = "";
		URL url = new URL(address);
		BufferedReader in = new BufferedReader(new InputStreamReader(
				url.openStream()));
		while ((inputLine = in.readLine()) != null)
			webpage += inputLine;
		in.close();
		return webpage;
	}
}
