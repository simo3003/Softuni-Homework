package DataTypesAndMethods;

import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        char letter = Character.toLowerCase(input.charAt(0));

        if (Character.isDigit(letter)) {
            System.out.println("digit");
        } else if (letter == 'a'
                || letter == 'e'
                || letter == 'o'
                || letter == 'u'
                || letter == 'i') {
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }
    }
}
