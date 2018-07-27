package ClassesAndObjects;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.Scanner;

public class BookLibraryModification {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int bookCount = Integer.parseInt(scanner.nextLine());
        DateTimeFormatter df = DateTimeFormatter.ofPattern("dd.MM.yyyy");
        LibraryModified library = new LibraryModified(new ArrayList<>());

        for (int index = 0; index < bookCount; index++) {
            String[] bookTokens = scanner.nextLine().split(" ");
            String title = bookTokens[0];
            String author = bookTokens[1];
            String publisher = bookTokens[2];
            LocalDate releaseDate = LocalDate.parse(bookTokens[3], df);
            String isbn = bookTokens[4];
            double price = Double.parseDouble(bookTokens[5]);
            BookModified book = new BookModified(title, author, publisher, releaseDate, isbn, price);
            library.getBooks().add(book);
        }

        LocalDate startReleaseDate = LocalDate.parse(scanner.nextLine(), df);

        library.getBooks()
                .stream()
                .filter(b -> b.getReleaseDate().isAfter(startReleaseDate))
                .sorted(Comparator.comparing(BookModified::getReleaseDate).thenComparing(BookModified::getTitle))
                .forEach(b -> System.out.println(
                        b.getTitle() + " -> " + df.format(b.getReleaseDate())));
    }
}
class BookModified {

    private String title;
    private String author;
    private String publisher;
    private LocalDate releaseDate;
    private String isbn;
    private double price;

    BookModified(String title, String author, String publisher,
         LocalDate releaseDate, String isbn, double price) {

        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.releaseDate = releaseDate;
        this.isbn = isbn;
        this.price = price;
    }

    String getTitle() {
        return title;
    }

    LocalDate getReleaseDate() {
        return releaseDate;
    }
}
class LibraryModified {

    private ArrayList<BookModified> books;

    LibraryModified(ArrayList<BookModified> books) {

        this.books = books;
    }

    ArrayList<BookModified> getBooks() {

        return books;
    }
}
