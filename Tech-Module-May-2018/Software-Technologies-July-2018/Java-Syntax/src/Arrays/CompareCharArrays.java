package Arrays;

import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        char[] first = scanner.nextLine().replaceAll(" ", "").toCharArray();
        char[] second = scanner.nextLine().replaceAll(" ", "").toCharArray();
        int minLength = Math.min(first.length, second.length);

        if (new String(first).equals(new String(second))) {
            System.out.println(first);
            System.out.println(second);
        } else {
            Boolean isPartiallyEqual = false;
            for (int i = 0; i < minLength; i++) {
                if (first[i] == second[i]) {
                    isPartiallyEqual = true;
                    continue;
                }
                isPartiallyEqual = false;
            }

            if (isPartiallyEqual) {
                if (first.length < second.length) {
                    System.out.println(first);
                    System.out.println(second);
                } else if (second.length < first.length) {
                    System.out.println(second);
                    System.out.println(first);
                }
            } else {
                for (int i = 0; i < minLength; i++) {
                    if (first[i] == second[i]) {
                        continue;
                    }
                    if (first[i] < second[i]) {
                        System.out.println(first);
                        System.out.println(second);
                        return;
                    } else {
                        System.out.println(second);
                        System.out.println(first);
                        return;
                    }
                }
            }
        }
    }
}
