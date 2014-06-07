import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.Date;
import java.util.Scanner;


public class DaysBetweenTwoDates {

	public static void main(String[] args) {
		try{
		Scanner scn = new Scanner(System.in);
		SimpleDateFormat formatter = new SimpleDateFormat("dd-MM-yyyy");
		Date startDate = formatter.parse(scn.nextLine());
		Date endDate = formatter.parse(scn.nextLine());
		int diffInDays = (int)( (endDate.getTime() -startDate.getTime()) 
                / (1000 * 60 * 60 * 24) );
		System.out.println(diffInDays);
		}
		catch(Exception ex){
			System.out.println("The correct date format is dd-MM-yyyy");
		}
	}

}
