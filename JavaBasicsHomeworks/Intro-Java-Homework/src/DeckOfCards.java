import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.Font;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Rectangle;
import com.itextpdf.text.io.StreamUtil;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;

import java.io.FileOutputStream;

public class DeckOfCards {
	
	public static void main(String[] args) {
		try {
			Document document = new Document();
			PdfWriter.getInstance(document, new FileOutputStream("DeckOfCards.pdf"));			
			document.open();
			
			PdfPTable table = new PdfPTable(4);
			table.setWidthPercentage(100);
		    table.getDefaultCell().setFixedHeight(180);
		    table.getDefaultCell().setBorder(0);//Removes parent table border.
			
			BaseFont baseFont = BaseFont.createFont("Fonts/times.ttf", BaseFont.IDENTITY_H, true);
			Font black = new Font(baseFont, 40f, 0, BaseColor.BLACK);
			Font red = new Font(baseFont, 40f, 0, BaseColor.RED);
			char color =' ';
			String card = " ";
			for (int i = 2; i <= 14; i++) {
				switch (i) {
				case 10: card = "10"; break;
				case 11: card = " J"; break;
				case 12: card = " Q"; break;
				case 13: card = " K"; break;
				case 14: card = " A"; break;
				default: card = " " + i; break;
				}
				for (int j = 1; j <= 4; j++) {
					PdfPCell cell1 = new PdfPCell();
					cell1.setBorder(Rectangle.NO_BORDER);  //Removes parent cell border 
					PdfPCell cell2 = new PdfPCell();
					cell2.setBorder(Rectangle.NO_BORDER);   
					PdfPCell cell3 = new PdfPCell();
					cell3.setBorder(Rectangle.NO_BORDER);   
					PdfPCell cell4 = new PdfPCell();
					cell4.setBorder(Rectangle.NO_BORDER);   
					PdfPTable nestedTable = new PdfPTable(1);//A separate table used to create the card shape and spacing between cards(is inserted in a cell of the parent table)
					nestedTable.getDefaultCell().setPaddingTop(56);      //
					nestedTable.getDefaultCell().setPaddingBottom(64);//
					nestedTable.getDefaultCell().setPaddingLeft(17);//Centers the card number and color
					nestedTable.getDefaultCell().setPaddingRight(17);//
					nestedTable.getDefaultCell().setBackgroundColor(BaseColor.LIGHT_GRAY); //sets card background color
					switch (j) { //Tr00peR rulz.
					case 1: color = '♣'; nestedTable.addCell(new Paragraph(card + color + " ", black));
					cell1.addElement(nestedTable);table.addCell(cell1);//Ads a cell to the nested table
					break;
					case 2: color = '♦'; nestedTable.addCell(new Paragraph(card + color + " ", red));
					cell2.addElement(nestedTable);table.addCell(cell2);
					break;
					case 3: color = '♠'; nestedTable.addCell(new Paragraph(card + color + " ", black));
					cell3.addElement(nestedTable);table.addCell(cell3);
					break;
					case 4: color = '♥'; nestedTable.addCell(new Paragraph(card + color + " ", red));
					cell4.addElement(nestedTable);table.addCell(cell4);
					break;
					}
				}
				
			}
			document.add(table);
			document.close();			
		}
		catch (Exception e) {
			e.printStackTrace();
		}
	}

}