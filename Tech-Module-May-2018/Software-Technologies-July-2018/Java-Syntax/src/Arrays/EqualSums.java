package Arrays;

import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(" ");

        int[] numbs = new int[input.length];
        for (int i = 0; i < input.length; i++) {
            numbs[i] = Integer.parseInt(input[i]);
        }

        int matchIndex = -1;

        int leftSum = 0;
        int rightSum = 0;

        for (int i : numbs) {
            rightSum += i;
        }

        for (int i = 0; i < numbs.length; i++) {
            rightSum -= numbs[i];
            if (rightSum == leftSum)
            {
                matchIndex = i;
                break;
            }
            leftSum += numbs[i];
        }
        if (matchIndex == -1) {
            System.out.println("no");
        } else {
            System.out.println(matchIndex);
        }
    }
}
