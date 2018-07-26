package StringsMapsStreamAPI;

import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        if (input.length() > 20) {
            String temp = input.substring(0, 20);
            System.out.print(temp);
        } else if (input.length() < 20) {
            int diff = 20 - input.length();
            String temp = input + repeatChar('*', diff);
            System.out.print(temp);
        } else {
            System.out.print(input);
        }
    }

    public static String repeatChar(char symbol, int count) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; i++) {
            result.append(symbol);
        }
        return result.toString();
    }
}
