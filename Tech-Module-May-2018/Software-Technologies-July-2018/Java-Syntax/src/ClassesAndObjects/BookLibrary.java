package ClassesAndObjects;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.stream.Collectors;

public class BookLibrary {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int bookCount = Integer.parseInt(scanner.nextLine());
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd.MM.yyyy");
        Library library = new Library(new ArrayList<>());


        for (int index = 0; index < bookCount; index++) {
            String[] bookTokens = scanner.nextLine().split(" ");

            String title = bookTokens[0];
            String author = bookTokens[1];
            String publisher = bookTokens[2];
            LocalDate releaseDate = LocalDate.parse(bookTokens[3], formatter);
            String isbn = bookTokens[4];
            double price = Double.parseDouble(bookTokens[5]);

            Book book = new Book(title, author, publisher, releaseDate, isbn, price);

            library.getBooks().add(book);
        }

        library.getBooks().stream()
         .collect(Collectors.groupingBy(Book::getAuthor, Collectors.summingDouble(Book::getPrice)))
         .entrySet()
         .stream()
         .sorted((a, b) -> {
             int comparisonResult = Double.compare(b.getValue(), a.getValue());
             if (comparisonResult == 0) {
                 comparisonResult = a.getKey().compareTo(b.getKey());
             }
             return comparisonResult;
         })
         .forEach(kvp -> {
             String author = kvp.getKey();
             double pricesTotalSum = kvp.getValue();
             System.out.printf("%s -> %.2f%n", author, pricesTotalSum);
         });
    }
}

class Book {

    private String title;
    private String author;
    private String publisher;
    private LocalDate releaseDate;
    private String isbn;
    private double price;

    Book(String title, String author, String publisher,
         LocalDate releaseDate, String isbn, double price) {

        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.releaseDate = releaseDate;
        this.isbn = isbn;
        this.price = price;
    }

    String getAuthor() {
        return author;
    }

    double getPrice() {
        return price;
    }
}

class Library {

    private ArrayList<Book> books;

    Library(ArrayList<Book> books) {
        this.books = books;
    }

    ArrayList<Book> getBooks() {
        return books;
    }
}