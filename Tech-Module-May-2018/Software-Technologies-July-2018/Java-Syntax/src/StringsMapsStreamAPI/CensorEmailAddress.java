package StringsMapsStreamAPI;

import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] emailArr = scanner.nextLine().split("@");
        String text = scanner.nextLine();

        String username = emailArr[0];
        String domain = emailArr[1];
        String email = username + '@' + domain;

        String replacement = repeatChar('*', username.length()) + '@' + domain;
        text = text.replace(email, replacement);
        System.out.println(text);
    }

    public static String repeatChar(char symbol, int count) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; i++) {
            result.append(symbol);
        }
        return result.toString();
    }
}
