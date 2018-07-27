package StringsMapsStreamAPI;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.Arrays;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        int start = input.indexOf("<upcase>");
        int end = input.indexOf("</upcase>");

        while (start != -1) {
            String temp = input.substring(start + 8, end);

            input = input.replace("<upcase>" + temp + "</upcase>", temp.toUpperCase());

            start = input.indexOf("<upcase>");
            end = input.indexOf("</upcase>");
        }

        System.out.println(input);
    }
}
