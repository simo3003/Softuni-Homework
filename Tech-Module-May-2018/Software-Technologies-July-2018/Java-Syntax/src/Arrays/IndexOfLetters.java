package Arrays;

import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] input = scanner.nextLine().toLowerCase().toCharArray();
        for (char character : input) {
            System.out.printf("%s -> %s", character, character - 97);
            System.out.println();
        }
    }
}
